using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unscrambler
{
    public partial class UnscrambleForm : Form
    {
        private static Dictionary<string, string[]> dictionary = null;

        public UnscrambleForm()
        {
            this.InitializeComponent();
            this.txtDictionaryPath.Text = @"C:\Users\Jacen\Documents\Dictionaries\WordscapeDictionary.txt";
            TableLayoutPanelCellPosition pos = this.tableLayoutPanel1.GetCellPosition(this.btnGetWords);
            this.tableLayoutPanel1.RowStyles[pos.Row].Height = 0;
            this.Height = this.Height - 30;
            this.AcceptButton = this.btnLoadDictionary;
        }

        private HashSet<string> GetWordsInDictionary(string dictionaryPath, int maxLength)
        {
            HashSet<string> dictionary = new HashSet<string>();
            int counter = 0;
            using (FileStream fs = File.OpenRead(dictionaryPath))
            {
                using (TextReader reader = new StreamReader(fs))
                {
                    string word;
                    while ((word = reader.ReadLine()) != null)
                    {
                        counter++;
                        if (!String.IsNullOrWhiteSpace(word) && word.Length > 2 && word.Length <= maxLength)
                        {
                            dictionary.Add(word);
                            if (counter % 100 == 0)
                            {
                                float percentDone = (float)counter / 80368F * 100F;
                                this.bkgrndFileReader.ReportProgress(Convert.ToInt32(percentDone), word);
                            }
                        }
                    }
                }
            }

            return dictionary;
        }

        private void btnLoadDictionary_Click(object sender, EventArgs e)
        {
            this.bkgrndFileReader.RunWorkerAsync(this.txtDictionaryPath.Text);
        }

        private void bkgrndFileReader_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = string.Empty;
            if (e.Argument is string)
            {
                path = e.Argument.ToString();
                e.Result = this.GetWordsInDictionary(path, 7);
            }
            else
            {
                e.Result = new HashSet<string>();
            }
        }

        private void bkgrndFileReader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string word = e.UserState.ToString();
            int percentDone = e.ProgressPercentage;
            this.lblLoadingFile.Text = $"{word}   {percentDone}%";
        }

        private void bkgrndFileReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HashSet<string> hsDictionary = (HashSet<string>) e.Result;
            dictionary = hsDictionary
            .Select(word => new {
                Key = string.Concat(word.OrderBy(c => c)),
                Value = word
            })
            .GroupBy(item => item.Key, item => item.Value)
            .ToDictionary(chunk => chunk.Key, chunk => chunk.ToArray());

            this.Height = this.Height + 30;
            TableLayoutPanelCellPosition pos = this.tableLayoutPanel1.GetCellPosition(this.btnGetWords);
            this.tableLayoutPanel1.RowStyles[pos.Row].Height = 30;
            this.lblScrambledLetters.Visible = true;
            this.txtScrambledLetters.Visible = true;
            this.btnGetWords.Visible = true;
            this.AcceptButton = this.btnGetWords;
            this.txtScrambledLetters.Focus();
        }

        private void btnGetWords_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtScrambledLetters.Text))
            {
                MessageBox.Show("Please enter the scrambled letters", "No Letters to Unscramble", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            string source = string.Concat(this.txtScrambledLetters.Text.OrderBy(c => c));

            var results = Enumerable
                .Range(1, (1 << source.Length) - 1)
                .Select(index => string.Concat(source.Where((item, idx) => ((1 << idx) & index) != 0)))
                .SelectMany(key => {
                    if (dictionary.TryGetValue(key, out string[] words))
                        return words;
                    else
                        return new string[0];
                })
                .Distinct() // some words can be built in many ways
                .OrderBy(word => word)
                .ToArray();

            WordResultsForm wrf = new WordResultsForm(results);
            wrf.ShowDialog();
        }

        private void txtScrambledLetters_Enter(object sender, EventArgs e)
        {
            TextBox tbox = sender as TextBox;
            tbox?.Select(0, tbox.TextLength);
        }
    }
}

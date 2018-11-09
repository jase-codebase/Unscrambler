using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unscrambler
{
    public partial class WordResultsForm : Form
    {
        public WordResultsForm(string[] words)
        {
            this.InitializeComponent();

            this.ListWords(words);
        }

        private void ListWords(string[] words)
        {
            foreach (string word in words)
            {
                this.lstWords.Items.Add(word);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.lstWords.Items.Clear();
            this.Close();
        }
    }
}

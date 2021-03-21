using System;
using System.Linq;
using System.Windows.Forms;
using LanguageLibrary;

namespace WinFormsApp_LanguageTraining
{
    public partial class NewListForm : Form
    {
        public NewListForm()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (NewlisttextBox.Text == null || string.IsNullOrWhiteSpace(NewlisttextBox.Text))
            {
                MessageBox.Show("Please write a name");
                return;
            }

            var name = NewlisttextBox.Text;

            var language = textBox1.Text.Split("\r\n");
            if (language.Length < 2 || language.Contains(string.Empty))
            {
                MessageBox.Show("Please add minimun two languages, one per line");
                return;
            }

            var wordlist = new WordList(name, language);
            wordlist.Save();
            Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewlisttextBox_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
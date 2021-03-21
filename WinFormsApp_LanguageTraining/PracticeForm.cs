using System;
using System.Windows.Forms;
using LanguageLibrary;

namespace WinFormsApp_LanguageTraining
{
    public partial class PracticeForm : Form
    {
        private readonly WordList _wordList;
        private int _points;
        private Word _practiceWord;
        private int _tries;


        public PracticeForm(WordList wordList)
        {
            InitializeComponent();
            _wordList = wordList;
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitPracticeButton;
            ExitPracticeButton = MessageBox.Show("Confirm if you want to exit", "Save DataGirdView",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ExitPracticeButton == DialogResult.Yes) Close();
        }


        private void PracticeForm_Load(object sender, EventArgs e)
        {
            _practiceWord = _wordList.GetWordToPractice();
            var languageArray = _wordList.Languages;

            TranslatetextBox1.Text =
                $"Can you translate {languageArray[_practiceWord.FromLanguage]} word {_practiceWord.Translations[_practiceWord.FromLanguage]} to {languageArray[_practiceWord.ToLanguage]}";
        }


        private void okbutton_Click(object sender, EventArgs e)
        {
            var input = TranslateBox.Text;
            if (input == _practiceWord.Translations[_practiceWord.ToLanguage].ToLower())
            {
                MessageBox.Show("That is correct");
                _points++;
                _tries++;
            }
            else
            {
                MessageBox.Show("That is not correct");
                _tries++;
            }

            _practiceWord = _wordList.GetWordToPractice();
            var languageArray = _wordList.Languages;

            TranslatetextBox1.Text =
                $"Can you translate {languageArray[_practiceWord.FromLanguage]} word {_practiceWord.Translations[_practiceWord.FromLanguage]} to {languageArray[_practiceWord.ToLanguage]}";
            TranslateBox.Text = "";
            Pointlabel.Text = $"Total Point: {_points}";
            Trieslabel.Text = $"Total Tries: {_tries}";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            var message = $"You have got {_points} out of {_tries} times";
            var title = "Stop Practicing";
            MessageBox.Show(message, title);
            Close();
        }
    }
}
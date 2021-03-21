﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LanguageLibrary;

namespace WinFormsApp_LanguageTraining
{
    public partial class WordlistForm : Form
    {
        private WordList _wordList;

        public WordlistForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Removebutton.Enabled = false;
            Savebutton.Enabled = false;
            Practicebutton.Enabled = false;

            var list = WordList.GetLists();

            foreach (var i in list) listBox.Items.Add(Path.GetFileName(i).Split('.')[0]);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Removebutton.Enabled = true;
            Savebutton.Enabled = true;
            Practicebutton.Enabled = true;
            var name = listBox.GetItemText(listBox.SelectedItem);
            _wordList = WordList.LoadList(name);
            if (_wordList == null)
                return;

            const int sortBy = 0;

            var languages = _wordList.Languages;
            WorddataGridView.Columns.Clear();
            WorddataGridView.Rows.Clear();
            WorddataGridView.Refresh();
            WorldCounttextBox.Text = _wordList.Count().ToString();
            foreach (var item in languages) WorddataGridView.Columns.Add(item, item);

            _wordList.List(sortBy, x => { WorddataGridView.Rows.Add(x); });
        }


        private void AddWordbutton_Click(object sender, EventArgs e)
        {
            if (WorddataGridView.RowCount == 0) return;
            WorddataGridView.Rows.Add("");
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (_wordList.Count() == 0) MessageBox.Show("There is no word to remove");
            if (WorddataGridView.CurrentCell == null) return;

            var wordIndex = WorddataGridView.CurrentCell.RowIndex;

            if (WorddataGridView.SelectedCells[0].Value == null)
            {
                WorddataGridView.Rows.RemoveAt(wordIndex);
                return;
            }

            var word = WorddataGridView.SelectedCells[0].Value.ToString();


            WorddataGridView.Rows.RemoveAt(wordIndex);

            _wordList.Remove(0, word);
            WorldCounttextBox.Text = _wordList.Count().ToString();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            //var count = WorddataGridView.RowCount;
            for (var i = _wordList.Count(); i < WorddataGridView.RowCount; i++)
            {
                var translations = new string[_wordList.Languages.Length];

                for (var j = 0; j < translations.Length; j++)
                {
                    if (WorddataGridView.Rows[i].Cells[j].Value == null) break;

                    translations[j] = WorddataGridView.Rows[i].Cells[j].Value.ToString();
                }

                if (!translations.Contains(string.Empty)) _wordList.Add(translations);
            }


            _wordList.Save();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult Exitbutton;
            Exitbutton = MessageBox.Show("Confirm if you want to exit", "Save DataGirdView", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (Exitbutton == DialogResult.Yes) Application.Exit();
        }

        private void NewListbutton_Click(object sender, EventArgs e)
        {
            var newList = new NewListForm();
            newList.Show();
        }

        private void Practicebutton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            var name = listBox.SelectedItem.ToString();
            if (WordList.LoadList(name).Count() != 0)
            {
                var wordPractice = new PracticeForm(_wordList);
                wordPractice.Show();
            }
            else
            {
                MessageBox.Show("There is no word to practice. Please choose another file name");
            }
        }
    }
}
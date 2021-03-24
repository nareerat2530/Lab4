using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LanguageLibrary
{
    public class WordList
    {
        private static readonly char[] SplitChar = {';'};
        private readonly List<Word> _words = new();

        public WordList(string name, string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        private string Name { get; }
        public string[] Languages { get; }

        public static string[] GetLists()
        {
            var filePaths = Directory.GetFiles(Folder.SpecificFolder);
            return filePaths;
        }

        public static WordList LoadList(string name)
        {
            if (!File.Exists(Folder.GetFilePath(name))) return null;
            var str = new StreamReader(Folder.GetFilePath(name));
            var line = str.ReadLine();
            if (line == null) return null;
            var languages = line.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries);
            var wordList = new WordList(name, languages);

            while ((line = str.ReadLine()) != null)
                wordList.Add(line.Split(SplitChar, StringSplitOptions.RemoveEmptyEntries));
            str.Close();
            return wordList;
        }

        public void Save()
        {
            using var sw = new StreamWriter(Folder.GetFilePath(Name.ToLower()));

            foreach (var l in Languages) sw.Write(l + ";");
            foreach (var word in _words)
            {
                sw.Write("\n");

                for (var i = 0; i < Languages.Length; i++) sw.Write(word.Translations[i] + ";");
            }
        }

        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
                throw new ArgumentException("Not correct amount of translations");
            _words.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            if (_words.All(i => i.Translations[translation] != word.ToLower())) return false;
            var removeIndex = _words.IndexOf(_words.FirstOrDefault(i => i.Translations[translation] == word.ToLower()));
            _words.RemoveAt(removeIndex);
            Save();
            return true;
        }

        public int Count()
        {
            return _words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            var sortedList = _words.OrderBy(t => t.Translations[sortByTranslation]).ToArray();
            LoadList(Name);
            foreach (var translation in sortedList) showTranslations(translation.Translations);
        }

        public Word GetWordToPractice()
        {
            var rnd = new Random();
            var rndWord = rnd.Next(_words.Count);
            var fromLanguage = rnd.Next(Languages.Length);
            var toLanguage = rnd.Next(Languages.Length);
            var randomTranslation = _words[rndWord].Translations;
            while (fromLanguage == toLanguage) toLanguage = rnd.Next(Languages.Length);
            return new Word(fromLanguage, toLanguage, randomTranslation);
        }
    }
}
using System;
using System.IO;
using LanguageLibrary;

namespace ConsoleUI
{
    internal static class Program
    {
        private static string[] UserInput(string[] args)
        {
            var userInput = args;
            for (var i = 0; i < args.Length; i++) userInput[i] = args[i].ToLower();
            return userInput;
        }

        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                InfoForUser();
                return;
            }


            var input = UserInput(args);

            switch (input[0])
            {
                case "-lists":
                    ListMenu();
                    break;
                case "-new":
                    NewMenu(input);
                    break;
                case "-add":
                    AddMenu(input);

                    break;
                case "-remove":
                    RemoveMenu(input);
                    break;
                case "-words":
                    WordsMenu(input);
                    break;
                case "-count":
                    CountMenu(input);
                    break;
                case "-practice":

                    PracticeMenu(input);
                    break;
                default:
                    Console.WriteLine("\nPlease use one of these commands correctly\n");
                    InfoForUser();
                    break;
            }
        }

        private static void InfoForUser()
        {
            Console.WriteLine("Please choose one of those command");
            Console.WriteLine("-lists");
            Console.WriteLine(" -new <list name> <language 1> <language 2>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine(" -remove <list name> <language> <word 1> <word 2> .. <word n>");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }


        private static void ListMenu()
        {
            var list = WordList.GetLists();
            Console.WriteLine("Those are The lists in your computer:");
            foreach (var i in list) Console.WriteLine(Path.GetFileName(i).Split('.')[0]);
            //var wordlist = WordList.LoadList("");
            //wordlist.Save();
        }

        private static void NewMenu(string[] args)
        {
            var name = args[1].ToLower();
            var language = new string[args.Length - 2];

            for (var i = 0; i < language.Length; i++) language[i] = args[i + 2].ToLower();
            var wordlist = new WordList(name, language);
            Console.WriteLine("The list has been added");
            wordlist.Save();
        }

        private static void AddTranslationToList(WordList wordList)
        {
            var enterNothing = true;
            while (enterNothing)
            {
                var translations = new string[wordList.Languages.Length];
                for (var i = 0; i < wordList.Languages.Length; i++)
                {
                    Console.WriteLine($"Please write the word in {wordList.Languages[i]} ");
                    var input = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        wordList.Save();
                        enterNothing = false;
                        break;
                    }

                    translations[i] = input;
                }

                if (enterNothing) wordList.Add(translations);
            }
        }

        private static void AddMenu(string[] args)
        {
            var name = args[1].ToLower();
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine($"This list name {name} does not exit on your  computer");
                return;
            }

            AddTranslationToList(wordList);
        }

        private static void CountMenu(string[] args)
        {
            var name = args[1].ToLower();
            var wordList = WordList.LoadList(name);

            if (wordList == null)
            {
                Console.WriteLine($"This {name} file does not exit on your computer");
                return;
            }

            wordList.Count();


            Console.WriteLine($"There is  {wordList.Count()} words");
        }

        private static int GetIndex(string[] args, string[] languageIndex)
        {
            var name = args[1].ToLower();
            var wordList = WordList.LoadList(name);
            if (wordList == null) Console.WriteLine($"This list name {name} does not exit on your  computer");


            for (var i = 0; i < languageIndex.Length; i++)
                if (args[2] == languageIndex[i])
                    return i;
            wordList?.Save();
            return 0;
        }

        private static void RemoveMenu(string[] args)
        {
            var name = args[1].ToLower();
            var wordlist = WordList.LoadList(name);

            if (wordlist == null)
            {
                Console.WriteLine($"This list name {name} does not exit on your  computer");
                return;
            }

            var language = GetIndex(args, wordlist.Languages);

            for (var i = 3; i < args.Length; i++)
            {
                var wordToRemove = wordlist.Remove(language, args[i]);
                Console.WriteLine(wordToRemove
                    ? $"The {wordlist.Languages[language]} word {args[i]} was removed"
                    : "could not find word to remove");
            }

            wordlist.Save();
        }


        private static void WordsMenu(string[] args)
        {
            var name = args[1];
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }

            var languageArray = wordList.Languages;
            var sortBy = GetIndex(args, languageArray);
            foreach (var language in languageArray) Console.Write(language.PadLeft(20));
            Console.WriteLine();
            wordList.List(sortBy, x =>
            {
                Console.WriteLine();
                foreach (var l in x) Console.Write(l.PadLeft(20));
            });
        }

        private static void PracticeMenu1(WordList wordList)
        {
            var languageArray = wordList.Languages;
            var point = 0;
            var tries = 0;

            while (true)
            {
                var practiceWord = wordList.GetWordToPractice();

                Console.WriteLine(
                    $"you need to translate {languageArray[practiceWord.FromLanguage]} word \"{practiceWord.Translations[practiceWord.FromLanguage]}\"");

                Console.WriteLine($"Please write the word in {languageArray[practiceWord.ToLanguage]}");
                var input = Console.ReadLine().ToLower();

                if (input == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
                {
                    Console.WriteLine("That is correct");
                    point++;
                    tries++;
                }
                else if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("That is not correct");

                    tries++;
                }

                if (!string.IsNullOrWhiteSpace(input)) continue;
                Console.WriteLine($"You have got {point} points out of {tries} times");
                break;
            }
        }

        private static void PracticeMenu(string[] args)
        {
            var name = args[1].ToLower();
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine($"This list name {name} does not exit on your  computer");
                return;
            }

            PracticeMenu1(wordList);
        }
    }
}

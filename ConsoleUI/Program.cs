using System;
using System.IO;
using LanguageLibrary;

namespace ConsoleUI
{

    class Program
    {

        private static string[] UserInput(string[] args)
        {
            var userInput = args;
            for (var i = 0; i < args.Length; i++) userInput[i] = args[i].ToLower();
            return userInput;
        }
        static void Main(string[] args)
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
                    Console.WriteLine($"\nPlease use one of these commands correctly\n");
                    InfoForUser();
                     break;
            }

        }
        public static void InfoForUser()
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
      
        
            
        
        public static void ListMenu()
        {
            var list = WordList.GetLists();
            Console.WriteLine("Those are The lists in your computer:");
            foreach (var i in list)
            {
                
                Console.WriteLine(Path.GetFileName(i).Split('.')[0]);
            }
            //var wordlist = WordList.LoadList("");
            //wordlist.Save();
        }
        public static void NewMenu(string[] args)
        {
            // -new Food English Swedish Thai
            var name = args[1].ToLower();
            var language = new string[args.Length - 2];
            Console.WriteLine("The list has been added");
            for (int i = 0; i < language.Length; i++)
            {
                language[i] = args[i + 2].ToLower();
            }
            var wordlist = new WordList(name, language);
            wordlist.Save();
        }
       
        public static void AddTranslationToList(WordList wordList)
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

                wordList.Add(translations);


            }
        }
            public static void AddMenu(string[]args)
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
        public static void CountMenu(string[] args)
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
        public static int GetIndex(string[] args, string[] languageIndex)
        {
           
            var name = args[1].ToLower();
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine($"This list name {name} does not exit on your  computer");
                

            }



            for (var i =0; i < languageIndex.Length; i++)
            {
                if (  args[2] ==languageIndex [i]  ) 
                
                {
                    return i; 

                }
                
            }
            wordList.Save();
            return 0;

            
        }
        public static void RemoveMenu(string[] args)
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
                if (wordToRemove )
                {
                    Console.WriteLine($"The {wordlist.Languages[language]} word {args[i]} was removed");
                }
                else
                {
                    Console.WriteLine("could not find word to remove");
                }

            }
            wordlist.Save();
        }


        public static void WordsMenu(string[] args)
        {
            var name = args[1];
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }
            var languageIndex = wordList.Languages;
            var sortBy = GetIndex(args, languageIndex);
            foreach (var language in languageIndex)
            {
                Console.Write(language.PadLeft(20));

            }
            Console.WriteLine();
            wordList.List(sortBy, x =>
            {

                Console.WriteLine();
                foreach (var l in x)
                {

                    Console.Write(l.PadLeft(20));
                }

            });

        }   
         
        public static void PracticeMenu1(WordList wordList)
        {

            var languageIndex = wordList.Languages;
            var point = 0;
            var tried = 0;
            
            while (true)
            {
                var practiceWord = wordList.GetWordtoPractice();
               
                Console.WriteLine($"Can you translate {languageIndex[practiceWord.FromLanguage]} word {practiceWord.Translations[practiceWord.FromLanguage] }");

                Console.WriteLine($"Please write the word in {languageIndex[practiceWord.ToLanguage]}");
                var input = Console.ReadLine().ToLower();

                if(input == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
                {
                    Console.WriteLine("That is correct");
                    point++;
                    tried++;
                }
                else if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("That is not correct");
                   
                    tried++;
                    
                }

               if   (string.IsNullOrWhiteSpace(input))
               {
                    Console.WriteLine($"You have got {point} out of {tried} times");
                    break;
                }
            }
            
        }
        public static void PracticeMenu(string[] args)
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

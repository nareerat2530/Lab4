using System;
using System.IO;

namespace LanguageLibrary
{
    public static class Folder
    {
        private static string FilePath  => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string SpecificFolder => Path.Combine(FilePath, "LanguageLibrary");

        public static void CreateFolder()
        {
            Directory.CreateDirectory(SpecificFolder);
            
        }
        public static string GetFilePath(string name)
        {
            return $"{SpecificFolder}\\{name}.dat";
        }
    }
}
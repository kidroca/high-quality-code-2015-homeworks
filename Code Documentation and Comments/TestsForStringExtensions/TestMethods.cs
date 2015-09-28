namespace TestsForStringExtensions
{
    using System;
    using Telerik.ILS.Common;

   public class TestMethods
    {
       // Do not evaluate this it isn't a part of the homework

        private static void Main(string[] args)
        {
            string abc = "abc";

            string testMD5 = StringExtensions.ToMd5Hash(abc);
            Console.WriteLine(testMD5);

            string startString = "starty",
                    endString = "endy",
                    inputString = "the starty is longer than endy so what";

            string testGetStringsBetween = StringExtensions.GetStringBetween(inputString, startString, endString, 2);
            Console.WriteLine(testGetStringsBetween);

            Console.WriteLine(StringExtensions.CapitalizeFirstLetter(abc));

            string abtz = "абц";
            Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters(abtz));

            Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters(abtz + abc));

            string testUserName = "@#%$^Chov3k4#eP14";
            Console.WriteLine(StringExtensions.ToValidUsername(testUserName));

            Console.WriteLine(StringExtensions.ToValidLatinFileName(testUserName + " e palen bom-bok"));

            Console.WriteLine(StringExtensions.GetFirstCharacters(abc, 2));

            string testFileExtensions = "strange.file.txt";
            Console.WriteLine(StringExtensions.GetFileExtension(testFileExtensions));

            Console.WriteLine(StringExtensions.ToContentType("docx"));

            byte[] testByteArray = StringExtensions.ToByteArray(abc);

            foreach (var item in testByteArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

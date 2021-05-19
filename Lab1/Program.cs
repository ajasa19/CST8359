using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************
Student name:   Asim Jasarevic
Student number:	040922815
Section:        CST8359_303
Lab:			Lab 1 – Hello World! An introduction to C#

 ********************************/

namespace Lab1
{
    class Program
    {
        static void Main(string[] args) 
        {
            IList<string> words = new List<string>();

            // loop to display menu and get inputs until option "x" pressed
            for (int checker = 0 ; checker == 0;) { 
                Console.WriteLine("Hello World!!! My First C# App");
                Console.WriteLine("Options \n----------");
                Console.WriteLine("1 - Import Words From File");
                Console.WriteLine("2 - Bubble Sort words");
                Console.WriteLine("3 - LINQ/Lambda sort words");
                Console.WriteLine("4 - Count the Distinct Words");
                Console.WriteLine("5 - Take the first 10 words");
                Console.WriteLine("6 - Get the number of words that start with 'j' and display the count");
                Console.WriteLine("7 - Get and display of words that end with 'd' and display the count");
                Console.WriteLine("8 - Get and display of words that are greater than 4 characters long, and display the count");
                Console.WriteLine("9 - Get and display of words that are less than 3 characters long and start with the letter 'a', and display the count");
                Console.WriteLine("x – Exit\n");
                Console.WriteLine("Make a selection: ");

                string menuInput = Console.ReadLine();
                Console.Clear();

                // if-else chain to run functions depending on menu input
                if (menuInput == "1")
                {
                    Console.WriteLine("Reading Words");

                    countWords(words); // run function to get text from Word.txt and put in "words" list
                    int numWords = words.Count(); // count all indexes of list to get # of words in list

                    Console.WriteLine("Reading Words complete");
                    Console.WriteLine("Number of words found: " + numWords);
                    Console.WriteLine("\n");
                } else if (menuInput == "2")
                {
                    bubbleSort(words); // run fucntion to bubble sort temp list and return time
                } else if (menuInput == "3")
                {
                    LinqLambdaSort(words); // run fucntion to Linq sort temp list and return time
                } else if (menuInput == "4")
                {
                    countDistinct(words); // run fucntion to count all distinct words in list
                } else if (menuInput == "5")
                {
                    getFirstTen(words); // run fucntion to display first 10 words in list
                } else if (menuInput == "6")
                {
                    getJ(words); // run fucntion to display and count all words that start with ‘j’ in list
                } else if (menuInput == "7")
                {
                    getD(words); // run fucntion to display and count all words that end with ‘d’ in list
                } else if (menuInput == "8")
                {             
                    get4Char(words); // run fucntion to display and count all words that are greater than 4 characters long in list
                } else if (menuInput == "9")
                {
                    get3Char(words); // run fucntion to display and count all words that are less than 3 characters long and start with the letter ‘a’ in list
                } else if (menuInput == "x")
                {
                    checker++; //i ncrease checker var to break loop;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // change text color to red
                    Console.WriteLine("Invalid input");
                    Console.ResetColor(); // change text color back to default
                }

            } 
        }

        public static void countWords(IList<string> words) //Import Words from File
        {
            using (StreamReader r = new StreamReader("Words.txt")) 
            {
                string line;
                while ((line = r.ReadLine()) != null) // while the file still has valid text add to list
                { 
                    words.Add(line);
                }
             }
            
        }
        public static IList<string> bubbleSort(IList<string> words) //Bubble sort words
        {
            var listCopy = words.ToList();
            int listLength = listCopy.Count();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start(); //start timer

            for (int i = 0 ; i < listLength ; i++)
            {
                for (int j = 0; j < listLength-1; j++)
                {
                    if (listCopy[j].CompareTo(listCopy[j+1]) > 0)
                    {
                        string tempWord = listCopy[j];
                        listCopy[j] = listCopy[j + 1];
                        listCopy[j + 1] = tempWord;
                    }
                }
            }

            stopWatch.Stop(); //stop timer
            string sortTime = stopWatch.Elapsed.Milliseconds.ToString(); //re-format time to ms
            Console.Write("Time elapsed: " + sortTime + "ms");
            Console.Write("\n\n");

            return listCopy;

        }
        public static void LinqLambdaSort(IList<string> words) //LINQ/Lambda sort words
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start(); //start timer

              var lengths = from text in words //LINQ sort
                           orderby text.ToString()
                           select text;

            //words.Sort((a, b) => (a.ToString()[0].CompareTo(b.ToString()[0]))); //lambda sort

            stopWatch.Stop(); //stop timer
            string sortTime = stopWatch.Elapsed.Milliseconds.ToString(); //re-format time to ms
            Console.Write("Time elasped: " + sortTime + "ms");
            Console.Write("\n\n");

        }
        public static void countDistinct(IList<string> words) //Count the Distinct Words
        {
            //query to take all text with added built in functions distinct and count
            int distinctCount = (from text in words
                                 select text).Distinct().Count();

            Console.Write("The number of distinct words is: " + distinctCount);
            Console.Write("\n\n");
        }
        public static void getFirstTen(IList<string> words) //Take the first 10 words
        {
      
            var ten = words.Take(10);
            for (int i = 0; i < 10; i++) //for loop to get first ten values from list
            {          
                Console.WriteLine(words[i]);
            }
            Console.Write("\n\n");

        }
        public static void getJ(IList<string> words) //Get and display the words that start with ‘j’ and display the count
        {

            //query to take all text with added built in functions StartsWith("j")
            var firstJwords = from text in words 
                              where text.StartsWith("j") 
                              select text;
            int count = firstJwords.Count();

            foreach (var foundTxt in firstJwords) //for each var in firstJwords display text
            {
                Console.WriteLine(foundTxt);
            }

            Console.Write("Number of words that start with 'j': " + count);
            Console.Write("\n\n");
        }
        public static void getD(IList<string> words) //Get and display the words that end with ‘d’ and display the count
        {

            //query to take all text with added built in functions EndsWith("d") 
            var firstJwords = from text in words 
                              where text.EndsWith("d") 
                              select text;
            int count = firstJwords.Count();

            foreach (var foundTxt in firstJwords)
            {
                Console.WriteLine(foundTxt);
            }

            Console.Write("Number of words that ends with 'd': " + count);
            Console.Write("\n\n");
        }
        public static void get4Char(IList<string> words) //Get and display the words that are greater than 4 characters long, and display the count
        {

            //query to take all text with added where clause text.Length > 4 
            var fourChar = from text in words 
                           where text.Length > 4 
                           select text;
            int count = fourChar.Count();

            foreach (var foundTxt in fourChar) //for each var in firstJwords display text
            {
                Console.WriteLine(foundTxt);
            }

            Console.Write("Number of words longer than 4 characters: " + count);
            Console.Write("\n\n");
        }
        public static void get3Char(IList<string> words) //Get and display the words that are less than 3 characters long and start with the letter ‘a’.
        {

            //query to take all text with added where clause text.Length < 3 and built in function text.StartsWith("a") 
            var threeChar = from text in words 
                            where text.StartsWith("a") && text.Length < 3 
                            select text;
            int count = threeChar.Count();

            foreach (var foundTxt in threeChar) //for each var in firstJwords display text
            {
                Console.WriteLine(foundTxt);
            }

            Console.Write("Number of words longer less than 3 characters and start with 'a': " + count);
            Console.Write("\n\n");
        }
    }
}

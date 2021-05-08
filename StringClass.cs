using System;

namespace StringClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /string string1 = "This is a string created by assignment.";
            //Console.WriteLine(string1);
            //string string2a = "The path is C:\\PublicDocuments\\Report1.doc";
            //Console.WriteLine(string2a);
            //string string2b = @"The path is C:\PublicDocuments\Report1.doc";
            //Console.WriteLine(string2b);
            // The example displays the following output:
            //       This is a string created by assignment.
            //       The path is C:\PublicDocuments\Report1.doc
            //       The path is C:\PublicDocuments\Report1.doc

            string string1 = "Today is " + DateTime.Now.ToString("D") + ".";
            Console.WriteLine(string1);

            string string2 = "This is one sentence. " + "This is a second. ";
            string2 += "This is a third sentence.";
            Console.WriteLine(string2);
            // The example displays output like the following:
            //    Today is Tuesday, July 06, 2011.
            //    This is one sentence. This is a second. This is a third sentence.

            string sentence = "This sentence has five words.";
            // Extract the second word.
            int startPosition = sentence.IndexOf(" ") + 1;
            string word2 = sentence.Substring(startPosition,
                                              sentence.IndexOf(" ", startPosition) - startPosition);
            Console.WriteLine("Second word: " + word2);
            // The example displays the following output:
            //       Second word: sentence


            DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            double temperature = 68.3;
            string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
                                          dateAndTime, temperature);
            Console.WriteLine(result);
            // The example displays the following output:
            //       At 7:32 AM on Wednesday, July 06, 2011, the temperature was 68.3 degrees Fahrenheit.

          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };

            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);


            Console.ReadKey();
        }

        public static int designerPdfViewer(int[] h, string word)
        {
            int max = 0;
            int[] asciisOfWord = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                asciisOfWord[i] = word[i] - 97;
            }
            for (int i = 0; i < asciisOfWord.Length; i++)
            {
                if (h[asciisOfWord[i]] > max)
                    max = h[asciisOfWord[i]];
            }

            return max * word.Length;
        }

    }
}

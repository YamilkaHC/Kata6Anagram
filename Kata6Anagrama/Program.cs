using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata6Anagrama
{
    public class Program
    {

        public  class Anagram
        {
            public  Hashtable ListAnagrams;
            public  Hashtable Index;

            public TimeSpan Read(string path)
            {
                DateTime tiempoInicio = DateTime.MinValue;
                tiempoInicio = DateTime.Now;

                string line;
                ListAnagrams = new Hashtable();
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                int counter = 0;
                Index = new Hashtable();


                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    string Word = new String(line.OrderBy(x => x).ToArray()).ToLower();
                        
                    if (ListAnagrams.ContainsKey(Word))
                    {
                        ListAnagrams[Word] = (ListAnagrams[Word] + ", " + line);
                        if (!Index.ContainsKey(Word)) {
                            Index.Add(Word, Word);
                        }
                    }else
                    {
                        ListAnagrams.Add(Word, line);
                    }
                }
               /* foreach (DictionaryEntry item in Index)
                {

                    Console.WriteLine(ListAnagrams[item.Value]);
                }*/

                Console.WriteLine("CANTIDAD ANAGRMAS   :  " + Index.Count);
                Console.WriteLine("CANTIDAD DE PALABRAS:  " + counter);

               

                return (DateTime.Now - tiempoInicio);
            }
        }



        static void Main(string[] args)
        {
            
           
            var instance = new Anagram();
            string path = "C:\\Users\\maria\\Desktop\\wordlist.txt";
            Console.WriteLine("TIEMPO: {0:hh:mm:ss}", Convert.ToString(instance.Read(path)));

           
          
           
            Console.ReadLine();
        }
    }
}


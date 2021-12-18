using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class FindTheNames
    {

        private string[] boyNames = new string[1000];
        private string[] girlNames = new string[1000];
        private int[] boyNumber = new int[1000];
        private int[] girlNumber = new int[1000];

        public void readFile(string fileName)
        {
            string[] names = new string[1000];
            int[] total = new int[1000];
            char[] delimiterChars = { ' ' };
            try
            {

                using (StreamReader sr = new StreamReader(fileName))
                {
                    int counter = 0;
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(delimiterChars);
                        names[counter] = words[0];
                        total[counter] = Int32.Parse(words[1]);
                        counter++;
                    }
                }
            } catch (FileNotFoundException e)
            {
                Console.WriteLine("File cannot be found.");
            }
        }

        public void getNames()
        {
            Console.WriteLine("Enter in a name you would like to check: ");
            string name = Console.ReadLine();
            if (this.boyNames.Contains(name))
            {
                int index = Array.IndexOf(boyNames, name);
                int occurences = boyNumber[index];
                Console.WriteLine(name + " is ranked number " + index + " among boy names with " + occurences);
            }
            else
            {
                Console.WriteLine("That name was not found in the list provided.");
            }

            if(this.girlNames.Contains(name))
            {
                int index = Array.IndexOf(girlNames, name);
                int occurences = girlNumber[index];
                Console.WriteLine(name + " is ranked number " + index + " among girl names with " + occurences);
            }
            else
            {
                Console.WriteLine("Name was not found in list.");
            }

        }


    }
}

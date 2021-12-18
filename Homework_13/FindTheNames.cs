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
            
            // values that help break up the file
            string[] names = new string[1000];
            int[] total = new int[1000];
            char[] delimiterChars = { ' ' };
            // try the code below, if something goes wrong then throw an error
            try
            {
                // open the file passed into the function
                using (StreamReader sr = new StreamReader(fileName))
                {
                    // keep track of how many lines there are
                    int counter = 0;
                    // value to read the line
                    string line = null;
                    // while the text file is not null keep going
                    while ((line = sr.ReadLine()) != null)
                    {
                        // the array words will hold each value from the text file that's seperated with a space
                        string[] words = line.Split(delimiterChars);
                        // names will be stored in the names array
                        names[counter] = words[0];
                        // the id will be stored in the total array
                        total[counter] = Int32.Parse(words[1]);
                        // counter increments by one so it can be assigned to different values in each arrray
                        counter++;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                // error displayed if file cannot be opened
                Console.WriteLine("File cannot be found.");
            }
        }

        // this function will look at the value in each array
        public void getNames()
        {
            // prompts the user for a name
            Console.WriteLine("Enter in a name you would like to check: ");
            // stores the value into an empty string
            string name = Console.ReadLine();
            // if the array boyNames has the name in it
            if (this.boyNames.Contains(name))
            {
                // look up the number the name the user searched for appears at in the array and store in index
                int index = Array.IndexOf(boyNames, name);
                // check the amount of times the name was used and store in occurences
                int occurences = boyNumber[index];
                // display the results to the user
                Console.WriteLine(name + " is ranked number " + index + " among boy names with " + occurences);
            }
            else
            {
                // otherwise the name could not be found
                Console.WriteLine("That name was not found in the list provided.");
            }

            // this will function the same as the array of boys above, just with the girls array
            if (this.girlNames.Contains(name))
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

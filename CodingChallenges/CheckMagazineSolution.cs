using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CodingChallenges
{
    class CheckMagazineSolution
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            string canMake = "";
            // Key is the word, value is the count of the word
            Dictionary<string, int> magDict = new Dictionary<string, int>();
            for(int i= 0; i< magazine.Length; i++)
            {
                // Not the first occurence of the word
                if (magDict.ContainsKey(magazine[i]))
                {
                    // Increment word's count
                    magDict[magazine[i]]++;
                } else
                {
                    // First occurence of the word
                    magDict.Add(magazine[i], 1);
                }
                
            }
            
            for(int j = 0; j< note.Length; j++)
            {
                // Dictionary does not contain word or not enough occrences of the word 
                if (!magDict.ContainsKey(note[j]) || magDict[note[j]] == 0)
                {
                    // Cannot make ransom not end here
                    canMake = "No";
                    break;
                   
                } else
                {  
                    canMake = "Yes";
                    // Word has been used reduce count of the word in the dictionary
                    magDict[note[j]]--;

                }
            }
            Console.WriteLine(canMake);

        }
        //static void Main(string[] args)
        //{
            
        //    string[] magazine = { "two", "times", "three", "is", "not", "four" };
        //    string[] note = { "two", "times", "two", "is", "four" };

        //    checkMagazine(magazine, note);
        //}
    }
        
}

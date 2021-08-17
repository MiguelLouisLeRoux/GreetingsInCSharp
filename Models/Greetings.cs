using System;
using System.Collections.Generic;

namespace GreetingsInCSharp.Models
{
    public class GreetingsModel
    {
        public Dictionary<string, int> namesList = new Dictionary<string, int>(); 
        public string nameVal {get; set;}

        public string language { get; set;}
        public int count {get; set;}

        public string theGreeting {get; set;}

        public void GetNameAndLanguage(string theName, string theLanguage)
        {
            nameVal = theName.Trim();
            language = theLanguage;
        }

        public void GreetName()
        {
           
            if (!namesList.ContainsKey(nameVal))
            {
                namesList.Add(nameVal, 0);
            } else if (namesList.ContainsKey(nameVal))
            {
                namesList[nameVal] += 1;
            }
            
            if(language == "Portuguese")
            {
                theGreeting = $"Olá {nameVal}!";
            }
            else if(language == "Swedish")
            {
                theGreeting = $"Hej {nameVal}!";
            }
            else if (language == "Japanese")
            {
                theGreeting = $"こんにちは {nameVal}!";
            }

            count = namesList.Count;
        }
    }
}
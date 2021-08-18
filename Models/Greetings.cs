using System;
using System.Collections.Generic;

namespace GreetingsInCSharp.Models
{
    public class GreetingsModel
    {
        public static Dictionary<string, int> namesList = new Dictionary<string, int>();
        public static string nameVal {get; set;}

        public static string language {get; set;}
        public static int count {get; set;}

        public static string exception {get; set;}

        public static string theGreeting {get; set;}
        public static void GetNameAndLanguage(string theName, string theLanguage)
        {
            try
            {
                nameVal = theName.Trim();
                language = theLanguage;
            }
            catch (Exception e)
            {
                exception = e.Message; 
            
            }
            

        }

        public static void GreetName()
        {

            if (!namesList.ContainsKey(nameVal))
            {
                namesList.Add(nameVal, 0);
            }
            else if (namesList.ContainsKey(nameVal))
            {
                namesList[nameVal] += 1;
            }

            if (language == "Portuguese")
            {
                theGreeting = $"Olá {nameVal}!";
            }
            else if (language == "Swedish")
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
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
            if (string.IsNullOrEmpty(theName) && string.IsNullOrEmpty(theLanguage))
            {
                exception = "Enter a name, then select a language.";
                nameVal = "";
                language = "";
                theGreeting = "";
            }
            else if (string.IsNullOrEmpty(theLanguage) && !string.IsNullOrEmpty(theName))
            {
                exception = "Select a language";
                nameVal = "";
                language = "";
                theGreeting = "";
            }
            else if (string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                exception = "Enter a name.";
                nameVal = "";
                language = "";
                theGreeting = "";
            }
            else if (!string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                string upName = char.ToUpper(theName[0]) + theName.Substring(1);
                nameVal = upName.Trim();
                language = theLanguage;
                exception = "";
            }
        }

        public static void GreetName()
        {
            if (!string.IsNullOrWhiteSpace(nameVal))
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
            }

            count = namesList.Count;
        }

        public static void ClearMessages()
        {
            exception = "";
            theGreeting = "";
            nameVal = "";
        }

        public static void ClearGreets()
        {
            count = 0;
            namesList.Clear();
            exception = "";
            theGreeting = "";
            nameVal = "";
            language = "";
        }
    } 
}
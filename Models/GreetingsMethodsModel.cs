using System;
using System.Text.RegularExpressions;

namespace GreetingsInCSharp.Models
{
    public class GreetingsMethodsModel
    {
        public void GetNameAndLanguage(string theName, string theLanguage)
        {

            Regex regexPattern1 = new Regex(@"[A-ZA-z]\s[A-Za-z]+$");
            Regex regexPattern2 = new Regex(@"[A-ZA-z]+$");

            if (string.IsNullOrEmpty(theName) && string.IsNullOrEmpty(theLanguage))
            {
                GreetingsModel.exception = "Enter a name, then select a language.";
                GreetingsModel.nameVal = "";
                GreetingsModel.language = "";
                GreetingsModel.theGreeting = "";
            }
            else if (string.IsNullOrEmpty(theLanguage) && !string.IsNullOrEmpty(theName))
            {
                GreetingsModel.exception = "Select a language";
                GreetingsModel.nameVal = "";
                GreetingsModel.language = "";
                GreetingsModel.theGreeting = "";
            }
            else if (string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                GreetingsModel.exception = "Enter a name.";
                GreetingsModel.nameVal = "";
                GreetingsModel.language = "";
                GreetingsModel.theGreeting = "";
            }
            else if (regexPattern1.IsMatch(theName) || regexPattern2.IsMatch(theName))
            {
                string upName = char.ToUpper(theName[0]) + theName.Substring(1);
                GreetingsModel.nameVal = upName.Trim();
                GreetingsModel.language = theLanguage;
                GreetingsModel.exception = "";
            }
            else
            {
                GreetingsModel.exception = "Special characters are not accepted.";
                GreetingsModel.nameVal = "";
                GreetingsModel.language = "";
                GreetingsModel.theGreeting = "";
            }
        }

        public void GreetName()
        {
            if (!string.IsNullOrWhiteSpace(GreetingsModel.nameVal))
            {
                if (!GreetingsModel.namesList.ContainsKey(GreetingsModel.nameVal))
                {
                    GreetingsModel.namesList.Add(GreetingsModel.nameVal, 1);
                }
                else if (GreetingsModel.namesList.ContainsKey(GreetingsModel.nameVal))
                {
                    GreetingsModel.namesList[GreetingsModel.nameVal] += 1;
                }

                if (GreetingsModel.language == "Portuguese")
                {
                    GreetingsModel.theGreeting = $"Olá {GreetingsModel.nameVal}!";
                }
                else if (GreetingsModel.language == "Swedish")
                {
                    GreetingsModel.theGreeting = $"Hej {GreetingsModel.nameVal}!";
                }
                else if (GreetingsModel.language == "Japanese")
                {
                    GreetingsModel.theGreeting = $"こんにちは {GreetingsModel.nameVal}!";
                }
            }

            GreetingsModel.count = GreetingsModel.namesList.Count;

            DateTime theGreetTime = DateTime.Now;
            theGreetTime.ToString();
            SelectedNameDataModel greetData = new SelectedNameDataModel(GreetingsModel.nameVal, GreetingsModel.language, theGreetTime);
            GreetingsModel.SelectedNamesData.Add(greetData);
        }

        public void SetSellectedNameValues(string theSelectedName)
        {
            GreetingsModel.selectedName = theSelectedName;
            GreetingsModel.selectedNameGreetCount = GreetingsModel.namesList[theSelectedName];
        }

        public void ClearMessages()
        {
            GreetingsModel.exception = "";
            GreetingsModel.theGreeting = "";
            GreetingsModel.nameVal = "";
        }

        public void ClearGreets()
        {
            GreetingsModel.count = 0;
            GreetingsModel.namesList.Clear();
            GreetingsModel.SelectedNamesData.Clear();
            GreetingsModel.exception = "";
            GreetingsModel.theGreeting = "";
            GreetingsModel.nameVal = "";
            GreetingsModel.language = "";
        }

        public void RemoveName(string theNameValue)
        {
            for(int i = 0; i < GreetingsModel.SelectedNamesData.Count; i++)
            {
                var item = GreetingsModel.SelectedNamesData[i];
                if(item.theName == theNameValue)
                {
                    GreetingsModel.SelectedNamesData.RemoveAt(i);
                }
            }

            if(GreetingsModel.namesList.ContainsKey(theNameValue))
            {
                GreetingsModel.namesList.Remove(theNameValue);
                GreetingsModel.count = GreetingsModel.namesList.Count;
            }
        }
    }
}
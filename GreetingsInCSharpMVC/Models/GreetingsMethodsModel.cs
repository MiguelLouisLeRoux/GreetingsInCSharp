using System;
using System.Text.RegularExpressions;

namespace GreetingsInCSharp.Models
{
    public class GreetingsMethodsModel
    {
        public void GetNameAndLanguage(string theName, string theLanguage)
        {
            string trimmedName = theName;

            if (!string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                trimmedName = theName.Trim();
            }

            GreetingsModel.exception = "";
            GreetingsModel.nameVal = "";
            GreetingsModel.language = "";
            GreetingsModel.theGreeting = "";
            GreetingsModel.indexSuccessMessage = "";
            GreetingsModel.namesListSuccessMessage = "";

            Regex regexPattern1 = new Regex(@"[A-ZA-z]\s[A-Za-z]+$");
            Regex regexPattern2 = new Regex(@"[A-ZA-z]+$");

            if (string.IsNullOrEmpty(trimmedName) && string.IsNullOrEmpty(theLanguage))
            {
                GreetingsModel.exception = "Enter a name, then select a language.";
                return;
            }
            else if (string.IsNullOrEmpty(theLanguage) && !string.IsNullOrEmpty(trimmedName))
            {
                GreetingsModel.exception = "Select a language.";
                return;
            }
            else if (string.IsNullOrEmpty(trimmedName) && !string.IsNullOrEmpty(theLanguage))
            {
                GreetingsModel.exception = "Enter a name.";
                return;
            }
            else if (regexPattern1.IsMatch(trimmedName) || regexPattern2.IsMatch(trimmedName))
            {
                string upperName = char.ToUpper(trimmedName[0]) + trimmedName.Substring(1);
                GreetingsModel.nameVal = upperName;
                GreetingsModel.language = theLanguage;
                return;
            }
            else
            {
                GreetingsModel.exception = "Special characters and digits are not accepted.";
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
            GreetingsModel.namesListSuccessMessage = "";
        }

        public void ClearMessages()
        {
            GreetingsModel.exception = "";
            GreetingsModel.theGreeting = "";
            GreetingsModel.nameVal = "";
            GreetingsModel.namesListSuccessMessage = "";
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
            GreetingsModel.namesListSuccessMessage = "";
            GreetingsModel.indexSuccessMessage = "All greets succesfully cleared.";
        }

        public void RemoveName(string theNameValue)
        {
            for(int i = 0; i < GreetingsModel.SelectedNamesData.Count; i++)
            {
                var item = GreetingsModel.SelectedNamesData[i];
                if(item.theName == theNameValue)
                {
                    GreetingsModel.SelectedNamesData.Remove(item);
                }
            }

            for(int i = 0; i < GreetingsModel.SelectedNamesData.Count; i++)
            {
                var item = GreetingsModel.SelectedNamesData[i];
                if(item.theName == theNameValue)
                {
                    GreetingsModel.SelectedNamesData.Remove(item);
                }
            }

            if(GreetingsModel.namesList.ContainsKey(theNameValue))
            {
                GreetingsModel.namesList.Remove(theNameValue);
                GreetingsModel.count = GreetingsModel.namesList.Count;
            }

            GreetingsModel.namesListSuccessMessage = $"{theNameValue} has been succesfully removed.";
        }
    }
}
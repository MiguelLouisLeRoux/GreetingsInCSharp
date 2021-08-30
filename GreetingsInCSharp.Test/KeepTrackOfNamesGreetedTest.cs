using System;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class KeepTrackOfNamesGreetedTest
    {

        [Fact] 
        public void ShouldReturnAListOfAllNamesGreeted()
        {

            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Swedish");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Jack", "Portuguese");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Tess", "Japanese");
            greetings.GreetName();
            Console.WriteLine(greetings.namesList.Count);
            
            Assert.Equal(new Dictionary<String, Int32>() {{"Pete", 1}, {"Jack", 1}, {"Tess", 1}}, greetings.namesList);

        }
        
    }
}

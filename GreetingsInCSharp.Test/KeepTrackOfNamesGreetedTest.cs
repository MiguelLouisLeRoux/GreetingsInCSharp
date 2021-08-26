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

            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Pete", "Swedish");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Jack", "Portuguese");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Tess", "Japanese");
            greetMethod.GreetName();

            var serializedExpectedList = JsonSerializer.Serialize(new Dictionary<String, Int32>() {{"Pete", 1}, {"Jack", 1}, {"Tess", 1}});
            var serializedTestValue = JsonSerializer.Serialize(GreetingsModel.namesList);
            
            Assert.Equal(serializedExpectedList, serializedTestValue);
            greetMethod.ClearGreets();

        }
        
    }
}

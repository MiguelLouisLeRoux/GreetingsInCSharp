using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class KeepTrackOfTotalGreetCountTest
    {

        [Fact] 
        public void ShouldBeCountTotalOf4Greets()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Swedish");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Jack", "Portuguese");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Tess", "Japanese");
            greetings.GreetName();

            Assert.Equal(3, greetings.namesList.Count);
        }

        [Fact] 
        public void ShouldNotIncrementTotalGreetsCountWhenANameHasBeenEnteredMoreThanOnce()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Swedish");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Jack", "Portuguese");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Tess", "Japanese");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Tess", "Japanese");
            greetings.GreetName();

            Assert.Equal(3, greetings.namesList.Count);

        }   
    }
}

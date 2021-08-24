using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class KeepTrackOfTotalGreetCountTest
    {

        [Fact] 
        public void ShouldBeCountTotalOf4Greets()
        {
            var greetMethod = new GreetingsMethodsModel();

            greetMethod.GetNameAndLanguage("Pete", "Swedish");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Jack", "Portuguese");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Tess", "Japanese");
            greetMethod.GreetName();

            Assert.Equal(3, GreetingsModel.count);
        }

        [Fact] 
        public void ShouldNotIncrementTotalGreetsCountWhenANameHasBeenEnteredMoreThanOnce()
        {
            var greetMethod = new GreetingsMethodsModel();

            greetMethod.GetNameAndLanguage("Pete", "Swedish");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Jack", "Portuguese");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Tess", "Japanese");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Tess", "Japanese");
            greetMethod.GreetName();

            Assert.Equal(3, GreetingsModel.count);
        }   
    }
}

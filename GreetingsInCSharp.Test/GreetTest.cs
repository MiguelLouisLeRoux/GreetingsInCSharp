using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class GreetTest
    {
        [Fact] 
        public void ShouldBeAbleToGreetPeteInSwedish()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Swedish");
            greetings.GreetName();

            Assert.Equal("Hej Pete!", greetings.TheGreeting);

        }

        [Fact] 
        public void ShouldBeAbleToGreetTessInPortuguese()
        {

            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Tess", "Portuguese");
            greetings.GreetName();

            Assert.Equal("Olá Tess!", greetings.TheGreeting);

        }
    }
}

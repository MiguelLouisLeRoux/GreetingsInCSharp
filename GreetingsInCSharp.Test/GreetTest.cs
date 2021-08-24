using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class GreetTest
    {
        [Fact] 
        public void ShouldBeAbleToGreetPeteInSwedish()
        {
            var greetMethod = new GreetingsMethodsModel();

            greetMethod.GetNameAndLanguage("Pete", "Swedish");
            greetMethod.GreetName();

            Assert.Equal("Hej Pete!", GreetingsModel.theGreeting);

        }

        [Fact] 
        public void ShouldBeAbleToGreetTessInPortuguese()
        {

            var greetMethod = new GreetingsMethodsModel();

            greetMethod.GetNameAndLanguage("Tess", "Portuguese");
            greetMethod.GreetName();

            Assert.Equal("Olá Tess!", GreetingsModel.theGreeting);

        }
    }
}

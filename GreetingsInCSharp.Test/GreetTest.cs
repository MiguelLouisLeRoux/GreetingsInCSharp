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
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Pete", "Swedish");
            greetMethod.GreetName();

            Assert.Equal("Hej Pete!", GreetingsModel.theGreeting);
            greetMethod.ClearGreets();

        }

        [Fact] 
        public void ShouldBeAbleToGreetTessInPortuguese()
        {

            var greetMethod = new GreetingsMethodsModel();

            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Tess", "Portuguese");
            greetMethod.GreetName();

            Assert.Equal("Olá Tess!", GreetingsModel.theGreeting);
            greetMethod.ClearGreets();

        }
    }
}

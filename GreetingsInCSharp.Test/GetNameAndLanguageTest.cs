using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class GetNameAndLanguageTest
    {
        [Fact] 
        public void ShouldBeAbleToGetNameTessAndLanguagePortuguese()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Tess", "Portuguese");

            Assert.Equal("Tess", GreetingsModel.nameVal);
            Assert.Equal("Portuguese", GreetingsModel.language);
        }

        [Fact] 
        public void ShouldBeAbleToGetNameJackAndLanguageSwedish()
        {
            var greetMethod = new GreetingsInCSharp.Models.GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Pete", "Swedish");

            Assert.Equal("Pete", GreetingsModel.nameVal);
            Assert.Equal("Swedish", GreetingsModel.language);

        }
    }
}

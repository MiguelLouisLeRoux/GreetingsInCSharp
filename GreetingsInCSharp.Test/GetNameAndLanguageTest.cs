using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class GetNameAndLanguageTest
    {
        [Fact] 
        public void ShouldBeAbleToGetNameTessAndLanguagePortuguese()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Tess", "Portuguese");

            Assert.Equal("Tess", greetings.NameVal);
            Assert.Equal("Portuguese", greetings.Language);
        }

        [Fact] 
        public void ShouldBeAbleToGetNameJackAndLanguageSwedish()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Swedish");

            Assert.Equal("Pete", greetings.NameVal);
            Assert.Equal("Swedish", greetings.Language);
        }
    }
}

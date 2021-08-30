using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class ErrorAndSuccessMessagesTest
    {

        [Fact] 
        public void ShouldReturnEnterNameAndSelectLanguageErrorMesageWhenANameAndLanguageHasNotBeenEntered()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage(null, null);

            Assert.Equal("Enter a name, then select a language.", greetings.Exception);

        }

        [Fact] 
        public void ShouldReturnEnterNameErrorMesageWhenANameHasNotBeenEnteredButALanguageHasBeenSelected()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage(null, "Swedish");

            Assert.Equal("Enter a name.", greetings.Exception);
        }

        [Fact] 
        public void ShouldReturnSelectLanguageErrorMesageWhenANameHasBeenEnteredButALanguageHasNotBeenSelected()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", null);

            Assert.Equal("Select a language.", greetings.Exception);
        }

        [Fact] 
        public void ShouldReturnInvalidInputErrorMessageWhenSpecialCharacterOrDigitsAreEnteredForName()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("12%$@34#$5", "Swedish");

            Assert.Equal("Special characters and digits are not accepted.", greetings.Exception);
        }

        [Fact] 
        public void ShouldReturnSuccessMessageWhenGreetsTotalHasBeenCleared()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Portuguese");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Tess", "Swedish");
            greetings.GreetName();
            greetings.ClearGreets();

            Assert.Equal("All greets succesfully cleared.", greetings.SuccessMessage);
        }

        [Fact] 
        public void ShouldReturnSuccessMessageWhenANameHasBeenSuccessfullyRemovedFromGreetList()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Portuguese");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Tess", "Swedish");
            greetings.GreetName();
            greetings.RemoveName("Pete");

            Assert.Equal("Pete has been succesfully removed.", greetings.SecondPageSuccessMessage);
        }
        
    }
}

using System;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class ErrorAndSuccessMessagesTest
    {

        [Fact] 
        public void ShouldReturnEnterNameAndSelectLanguageErrorMesageWhenANameAndLanguageHasNotBeenEntered()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage(null, null);

            Assert.Equal("Enter a name, then select a language.", GreetingsModel.exception);
            greetMethod.ClearGreets();

        }

        [Fact] 
        public void ShouldReturnEnterNameErrorMesageWhenANameHasNotBeenEnteredButALanguageHasBeenSelected()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage(null, "Swedish");

            Assert.Equal("Enter a name.", GreetingsModel.exception);
            greetMethod.ClearGreets();


        }

        [Fact] 
        public void ShouldReturnSelectLanguageErrorMesageWhenANameHasBeenEnteredButALanguageHasNotBeenSelected()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Pete", null);

            Assert.Equal("Select a language.", GreetingsModel.exception);
            greetMethod.ClearGreets();


        }

        [Fact] 
        public void ShouldReturnInvalidInputErrorMessageWhenSpecialCharacterOrDigitsAreEnteredForName()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("12%$@34#$5", "Swedish");

            Assert.Equal("Special characters and digits are not accepted.", GreetingsModel.exception);
            greetMethod.ClearGreets();

        }

        [Fact] 
        public void ShouldReturnSuccessMessageWhenGreetsTotalHasBeenCleared()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Pete", "Portuguese");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Tess", "Swedish");
            greetMethod.GreetName();
            greetMethod.ClearGreets();

            Assert.Equal("All greets succesfully cleared.", GreetingsModel.indexSuccessMessage);
            greetMethod.ClearGreets();


        }

        [Fact] 
        public void ShouldReturnSuccessMessageWhenANameHasBeenSuccessfullyRemovedFromGreetList()
        {
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.ClearGreets();

            greetMethod.GetNameAndLanguage("Pete", "Portuguese");
            greetMethod.GreetName();
            greetMethod.GetNameAndLanguage("Tess", "Swedish");
            greetMethod.GreetName();
            greetMethod.RemoveName("Pete");

            Assert.Equal("Pete has been succesfully removed.", GreetingsModel.namesListSuccessMessage);
            greetMethod.ClearGreets();

        }
        
    }
}

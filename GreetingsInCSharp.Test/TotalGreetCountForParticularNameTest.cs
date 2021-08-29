using System;
using System.Collections.Generic;
using Xunit;

namespace GreetingsInCSharp.Models.Test
{
    public class TotalGreetCountForParticularNameTest
    {

        [Fact] 
        public void ShouldReturnATotalGreetCountOf4ForPete()
        {
            var greetings = new GreetingsModel();
            greetings.ClearGreets();

            greetings.GetNameAndLanguage("Pete", "Swedish");
            greetings.GreetName();
            greetings.GetNameAndLanguage("Pete", "Swedish");
            greetings.GreetName();

            Assert.Equal(2, GreetingsModel.namesList["Pete"]);
        }
        
    }
}

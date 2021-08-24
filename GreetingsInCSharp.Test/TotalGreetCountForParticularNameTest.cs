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
            var greetMethod = new GreetingsMethodsModel();
            greetMethod.GetNameAndLanguage("Pete", "Swedish");
            greetMethod.GreetName();

            Assert.Equal(2, GreetingsModel.namesList["Pete"]);

        }
        
    }
}

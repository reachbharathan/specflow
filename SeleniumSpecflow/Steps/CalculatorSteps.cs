using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.Steps
{
    [Binding]
    public sealed class CalculatorSteps
    {
        public int Num2 { get; set; }

        public int Num1 { get; set; }

        public int Result { get; set; }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int inputNumber)
        {
            if (Num1 != 0)
            {
                Num2 = inputNumber;
                var displayString = string.Format("I have entered {0} into the calculator", inputNumber);
                Console.Write(displayString);
            }
            else
            {
                Num1 = inputNumber;
                var displayString = string.Format("I have entered {0} into the calculator", inputNumber);
                Console.Write(displayString);
            }
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            Console.Write("Adding two Numbers");
            Result = Num1 + Num2;
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, Result, "Result Incorrect");
        }
    }
}

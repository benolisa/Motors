using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Motors.StepDefinitions
{
    [Binding]
    public sealed class ProductDetailsStep
    {
        IWebDriver driver;
        IWebElement agreeButton;
        IWebElement postCodeField;
        IWebElement carMake;

        [Given(@"I navigate to Motors homepage")]
        public void GivenINavigateToMotorsHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.motors.co.uk/");
            driver.Manage().Window.Maximize();

            agreeButton = driver.FindElement(By.ClassName("banner_continue--2NyXA"));
            agreeButton.Click();
                 
                
        }

        [When(@"I enter postcode")]
        public void WhenIEnterPostcode()
        {
            postCodeField = driver.FindElement(By.Name("PostCode"));
            postCodeField.SendKeys("SK4 1TB");
        }

        [When(@"i select the make of the car")]
        public void WhenISelectTheMakeOfTheCar()
        {
            carMake = driver.FindElement(By.Id("Make"));
            SelectElement select = new SelectElement(carMake);
            select.SelectByText("Audi");
        }   

        [When(@"I select the model of the car")]
        public void WhenISelectTheModelOfTheCar()
        {
           
        }

        [When(@"i click on search button")]
        public void WhenIClickOnSearchButton()
        {
            
        }

        [When(@"i click on the first result")]
        public void WhenIClickOnTheFirstResult()
        {
            
        }

        [Then(@"the price of the car selected is displayed")]
        public void ThenThePriceOfTheCarSelectedIsDisplayed()
        {
           
        }

    }
}

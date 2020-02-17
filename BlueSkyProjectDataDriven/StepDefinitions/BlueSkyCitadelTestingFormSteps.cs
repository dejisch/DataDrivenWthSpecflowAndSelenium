using BlueSkyProject2.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {
        AutomationTestingFormPage automationTestingFormPage;
        public BlueSkyCitadelTestingFormSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }

        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string message)
        {
            
        }


        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            
        }


        [Given(@"I navigate to the BlueSky Testing Form")]
        public void GivenINavigateToTheBlueSkyTestingForm()
        {
            automationTestingFormPage.NavigateToForm();

        }
        
        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            automationTestingFormPage.EnterSingleLineText();
        }
        
        [When(@"I select One in the Select box")]
        public void WhenISelectOneInTheSelectBox()
        {
            automationTestingFormPage.SelectOneFromSelectOneTwoThree();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingFormPage.SelectMultiSelector();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            automationTestingFormPage.SelectOneFromSelectRadio();
        }
        
        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
           
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int p0)
        {
            automationTestingFormPage.SelectDateFromCalendar();
        }
    }
}

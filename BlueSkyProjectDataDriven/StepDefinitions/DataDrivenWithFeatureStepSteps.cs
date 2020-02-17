using BlueSkyProject2.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProjectDataDriven.StepDefinitions
{
    [Binding]
    public class DataDrivenWithFeatureStepSteps
    {
        AutomationTestingFormPage automationTestingFormPage;

        public DataDrivenWithFeatureStepSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }

        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            automationTestingFormPage.NavigateToFormWithParameter(url);
        }
        
        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            automationTestingFormPage.EnterEmail(email);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationTestingFormPage.EnterPassword(password);
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the form is submited")]
        public void ThenTheFormIsSubmited()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

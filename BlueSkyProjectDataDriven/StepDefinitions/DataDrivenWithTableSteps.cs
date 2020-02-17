using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BlueSkyProjectDataDriven;
using BlueSkyProjectDataDriven.PageObjects;

namespace BlueSkyProjectDataDriven.StepDefinitions
{
    [Binding]
    public class DataDrivenWithTableSteps
    {

        DataTablePage dataTablePage;


        public DataDrivenWithTableSteps()
        {
            dataTablePage = new DataTablePage();
        }

        [When(@"I enter email and password")]
        public void WhenIEnterEmailAndPassword(Table table)
        {
            var emailAndPassword = table.CreateInstance<Details>();

            string email = emailAndPassword.Email;
            string password = emailAndPassword.Password;

            dataTablePage.EnterEmailAndPassword(email, password);
        }
    }
}

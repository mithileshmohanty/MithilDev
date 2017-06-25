using TechTalk.SpecFlow;

namespace BillManagement.UnitManagement
{
    [Binding]
    public class RegistrationOfNewUserSteps
    {
        private NewRegistration newManagement = new NewRegistration();

        [Given(@"User ""(.*)"" is a new user")]
        public void GivenUserIsANewUser(string userId)
        {
            newManagement.UserId = userId;
        }
        
        [Given(@"User ""(.*)"" is a new user and already entered all the details")]
        public void GivenUserIsANewUserAndAlreadyEnteredAllTheDetails(string userId)
        {
            newManagement.UserId = userId;
        }
        
        [Given(@"User ""(.*)"" is a new user and ""(.*)"" is a registered userid")]
        public void GivenUserIsANewUserAndIsARegisteredUserid(string userId, string p1)
        {
            newManagement.UserId = userId;
        }
        
        [When(@"click on ""(.*)"" after the data entry")]
        public void WhenClickOnAfterTheDataEntry(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on ""(.*)""")]
        public void WhenClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user enters ""(.*)"" in ""(.*)"" field")]
        public void WhenUserEntersInField(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"message box shows ""(.*)"" and user is redirected to ""(.*)"" page\.")]
        public void ThenMessageBoxShowsAndUserIsRedirectedToPage_(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all the entered fields are cleared and user is not redirected to any other page\.")]
        public void ThenAllTheEnteredFieldsAreClearedAndUserIsNotRedirectedToAnyOtherPage_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"error message is shown ""(.*)"" in red color And ""(.*)"" button is disabled\.")]
        public void ThenErrorMessageIsShownInRedColorAndButtonIsDisabled_(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"error message is shown ""(.*)"" in red color")]
        public void ThenErrorMessageIsShownInRedColor(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" button is disabled\.")]
        public void ThenButtonIsDisabled_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

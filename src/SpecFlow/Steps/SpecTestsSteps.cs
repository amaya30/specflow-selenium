using System;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class SpecTestsSteps
    {
        [Given(@"I have my browser open")]
        public void GivenIHaveMyBrowserOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have Google's homepage loaded")]
        public void GivenIHaveGoogleSHomepageLoaded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have performed a Google search")]
        public void GivenIHavePerformedAGoogleSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the search results are currently displayed")]
        public void GivenTheSearchResultsAreCurrentlyDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I type in Google's URL into the navigation bar")]
        public void WhenITypeInGoogleSURLIntoTheNavigationBar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Enter")]
        public void WhenIPressEnter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I type ""(.*)"" into the search box")]
        public void WhenITypeIntoTheSearchBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click ""(.*)""")]
        public void WhenIClick(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the top search result link")]
        public void WhenIClickOnTheTopSearchResultLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the browser will navigate to Google")]
        public void ThenTheBrowserWillNavigateToGoogle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the search results for ""(.*)"" will be displayed")]
        public void ThenTheSearchResultsForWillBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be navigated to that website")]
        public void ThenIWillBeNavigatedToThatWebsite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

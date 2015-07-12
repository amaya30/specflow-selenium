Feature: SpecTests
	
@mytag
Scenario: Navigate to Google
	Given I have my browser open
	When I type in Google's URL into the navigation bar
	And I press Enter
	Then the browser will navigate to Google

Scenario: Perform Google Search
	Given I have Google's homepage loaded
	When I type "lolcat" into the search box
	And I click "Google Search"
	Then the search results for "lolcat" will be displayed

Scenario: Click Search Result
	Given I have performed a Google search
	And the search results are currently displayed
	When I click on the top search result link
	Then I will be navigated to that website


@blueskyform
Feature: BlueSkyCitadelTestingForm
	In order to be a guru tester
	I want test the BlueSky Citadel Testing
	Which has a lot of elements that I will be automating in future

@regression 
Scenario: Valid Form Submission
	Given I navigate to the BlueSky Testing Form 
	When I enter the Single Line Text
	And I select One in the Select box
	And I enter Email
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom as Country
	And I select 12th of the current month
	And I click on the Submit button
	Then the message "Your form has been successfully submitted."
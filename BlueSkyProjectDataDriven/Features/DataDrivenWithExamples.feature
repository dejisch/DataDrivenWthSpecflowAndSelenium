Feature: DataDrivenWithExamples
	In order not to repeat my data or to be able to update my data from feature file
	I want add my data to the feature file


@mytag
Scenario Outline: Validate Form Example
	Given I navigate to site "http://www.giftrete.com"
	And I navigate to site "http://blueskycitadel.com/automation-testing-form/"
	When I enter email "<Email>"
	And I enter password "<Passwords>"
	#And I click on submit button
	#Then the form is submited

Examples: 
| Email           | Passwords         |
| mytest@test.com | mysecurePassword |
| mytest1@test.com | mysecurePassword2 |



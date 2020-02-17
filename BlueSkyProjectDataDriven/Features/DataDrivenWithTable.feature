Feature: DataDrivenWithTable
	In order not to repeat my data or to be able to update my data from feature file
	I want add my data to the feature file


@mytag
Scenario Outline: Validate Form With Table
	Given I navigate to site "http://blueskycitadel.com/automation-testing-form/"
	When I enter email and password
	| Email            | Password   |
	| mytest1@test.com | mypassword |
Feature: SpecFlowFeature1
	As a user
	I want to be able to enter message in the text field

@mytag
Scenario: Enter message in tedt field
	Given I navigate to seleniumeasy website
	When I enter 'message' in input text field
	And I click Show message button
	Then I should see successful message "Your message 'string'"

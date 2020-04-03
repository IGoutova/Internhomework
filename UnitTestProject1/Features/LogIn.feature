Feature: SpecFlowFeature1
	As a registered user
	I want to log in successfully

@positive
Scenario: Log in to
	Given I navigate to .... homepage
	When I enter "admin" in the username field
	And I enter "12345" in the password field
	And I click on Log in button
	Then I should see welcome message

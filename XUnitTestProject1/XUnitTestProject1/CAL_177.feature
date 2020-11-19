Feature: CAL_177
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Validate contact registration
	Given I have opened Home Page
	And I have pressed contact form
	And I have entered name field
	And I have entered email field
	And I have entered subject field
	And I have entered message field
	When I press Send button
	Then I should registered contact message.
Feature: CAL_174


@flow
Scenario: Unregistered user is able to sign up into the system
	Given I have opened HomePage.
	And I have clicked on Sign up button.
	And I have entered my name.
	And I have entered my email.
	And I have entered my Password.
	And I have entered my Confirmation password.
	When I press Sign up  button.
	Then Successfully authentication and redirected to Main Page
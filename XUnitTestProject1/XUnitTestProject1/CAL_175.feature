﻿Feature: CAL_175


@Smoke
Scenario: User is able to Sign IN
	Given I have clicked on Sign IN button
	And I have entered my Name.
	And I have entered my Email.
	When I press Sign In button. 
	Then My account should be successful logged.
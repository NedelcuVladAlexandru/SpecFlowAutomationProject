Feature: AccountRegistration

Testing the new account registration feature

@tag1
Scenario: 01.Selecting the register tab
	Given I am connected to the Home tab
	When I press the register option
	Then I will be sent to the register page

Scenario: 02.Inputing names
	Given I will input the <UserName> name
	When I try to register
	Then I will be prompted to fill another field

	Examples: 
	| UserName |
	| 1234     |
	| test     |
	| *$^!&@   |

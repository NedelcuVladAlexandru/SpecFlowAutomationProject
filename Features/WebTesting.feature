@WebTesting
Feature: WebTesting
Testing multiple scenarios for Web Testing

Scenario: Going to the home tab of BlazeDemo
	Given I have connected to the website
	When I select the home tab
	Then I will be sent to the home tab

Scenario: Registering a new account
	Given I have connected to the home tab
	When I have selected the register tab
	Then I will input my name
	And I will input my company name
	And I will input my e-mail address
	And I will input my password
	And I will confirm my password
	And I will press the Register button


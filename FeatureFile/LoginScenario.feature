Feature: LoginScenario
	In order to login to the website
	I want to be able to login successfully

@LoginTests
Scenario: Successful login
	When the user enters a correct username and password
	Then the homepage is shown

Scenario: Incorrect user name
	When the user enters incorrect username
	Then the login page is shown

Scenario: Incorrect password
	When the user enter incorrect password
	Then the login page is shown

Scenario: Appropriate error message is shown
	When the user clicks on Login button with no valid inputs
	Then the appropriate error messages are shown
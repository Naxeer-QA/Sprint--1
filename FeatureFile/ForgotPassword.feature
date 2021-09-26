Feature: ForgotPassword
	In order to regain access to the website
	As a known user
	I want to be able to receive reset password link

@mytag
Scenario: Display forgot password module
	When the user clicks on Forgot password link
	Then the forgot password module is shown

Scenario: Display appropriate error message
	When the user clicks on Send Verification Email button with no valid inputs
	Then the appropriate error message is shown

Scenario: Display verification message
	When the user enter valid email address
	And clicks on Send verification email button
	Then the user receives an email
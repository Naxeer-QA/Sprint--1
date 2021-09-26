Feature: DeleteProfileDetails
	In order to delete profile details
	As a known user
	I want to be able to do so

Background: Given the user has signed-in and the profile tab is opened

@deleteProfileDetails
Scenario: Delete language
	When the user clicks remove icon from language tab
	Then the removed language is not shown

Scenario: Delete skill
	When the user clicks remove icon from skill tab
	Then the removed skill is not shown

Scenario: Delete education
	When the user clicks remove icon from education tab
	Then the removed education is not shown

Scenario: Delete certification
	When the user clicks remove icon from certification tab
	Then the removed certification is not shown
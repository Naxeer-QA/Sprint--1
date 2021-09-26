Feature: ProfileUpdateScenario
	In order to update profile
	As a known user
	I want to be able to do so

Background: Given the user has signed-in and the profile tab is opened

@UpdateProfile
Scenario: Add description
	When the user adds descirption
	Then the added description is reflected

Scenario: Add language
	When the user enters new language
	And clicks add button
	Then the added language is shown

Scenario: Add skill
	When the user enter new skill
	And clicks on add button
	Then the added skill is shown

Scenario: Add education
	When the user enter new education
	And clicks on add button
	Then the added education is shown

Scenario: Add Certifications
	When the user enter new certification
	And clicks on add button
	Then the added certification is shown
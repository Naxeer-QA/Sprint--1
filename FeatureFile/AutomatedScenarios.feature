Feature: AutomatedScenarios
	AS an automation tester
	working on onboarding task
	I am advised to automate 3 most critical scenarios

@webAutomationTests
Scenario: Seller registers and logs in to the website
	Given the new seller signs up and logs in to the website
	Then the profile page is shown

Scenario: Seller adds the profile details
	Given the seller is logged in to the website
	When the seller adds the description
	Then the added details are shown in the description box
	When the seller adds language details
	Then the added details are shown in the language tab
	When the seller adds the skills
	Then the added details are shown in the skills tab
	When the seller adds the education details
	Then the added details are shown in the education tab
	When the seller adds the certification details
	Then the added details are shown in the certification tab

Scenario: Seller updates the profile details
	Given the seller is logged in to the website
	When the seller edits the description
	Then the edited details are shown
	When the seller edits the language
	Then the edited language is shown
	When the seller edits skills
	Then the edited skills are shown
	When the seller edits education details
	Then the education details edited successfully
	When the seller edits the certification details
	Then the certification details edited successfully


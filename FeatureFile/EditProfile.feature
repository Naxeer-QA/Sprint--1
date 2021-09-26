Feature: EditProfile
	In order to Edit profile
	As a known user
	I want to be able to do so

Background: Given the user has signed-in and the profile tab is opened

@editProfile
Scenario: Edit description
	When the user edits description
	And clicks save button
	Then the edited description is shown

Scenario: Edit language
	When the user clicks update buttom from language tab
	And edits language and level of proficiency 
	And clicks on update button
	Then the newly edited language is shown

Scenario: Edit skill
	When the user clicks update buttom from skill tab
	And edits skill and level of proficiency 
	And clicks on update button
	Then the newly edited skill is shown

Scenario: Edit education
	When the user clicks update buttom from education tab
	And edits education details
	And clicks on update button
	Then the edited education is shown

Scenario: Edit certification
	When the user clicks update buttom from certification tab
	And edits certification details 
	And clicks on update button
	Then the edited certification is shown

Scenario: Abort editing
	When the user clicks on cancel button
	Then the profile tab is shown
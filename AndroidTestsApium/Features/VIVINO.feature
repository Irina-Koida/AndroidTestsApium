Feature: Registrarion
I am as a user
I want to register
Then in order to use the application to the fullest

Background: 

#Given Application with opened
#
@Registration
Scenario: Check the possibility of registration in the application through the registration form
	When Tap the Get started button
	When Tap the gall button
	When Enter 'email' 
	When Create 'a' password
	When Tap Next
	Then Open 'Create account' page with registration
	When Enter your 'first name' name
	When Enter your 'last name' last name
	When Accept the Terms of Use and the Privacy Policy
	When Tap "Done" in the upper right corner
	Then The page with you profile opened

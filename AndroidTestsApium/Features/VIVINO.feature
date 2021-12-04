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
	When Enter 'your' email
#	When Create a password
#	When Tap Next
#	Then Open next page with registration
#	When Enter your first and last name
#	When Select country and language
#	When Accept the Terms of Use and the Privacy Policy
#	When Tap "Done" in the upper right corner
#	Then The page with you profile opened

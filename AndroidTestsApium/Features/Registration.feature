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
	When Enter 'Email' 
	When Create 'Password' 
	When Tap Next
	Then Open "Great user" page with registration
	When Enter your 'first name' name
	When Enter your 'last name' last name
	When Select state country
	When Select state
	When Accept the Terms of Use and the Privacy Policy
	When Tap Done in the upper right corner
	Then The page with you profile opened

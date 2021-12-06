Feature: LogIn
	I am as a user
I want to enter the application being registered
In order not to create more accounts

@mytag
Scenario: Checking the login to the application for a registered user
	When Tap I have account button
	When Input 'gogi1234@gmail.com' email
	When Input 'gogi1234))' password
	When Tap logIn button
	When Closed save password window 
	Then the result should be 'For you'
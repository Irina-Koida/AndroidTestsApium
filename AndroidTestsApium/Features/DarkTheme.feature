Feature: DarkTeme
	The user has registered
	I want to switch on a dark theme
	In order load on the eyes will be less

@mytag
Scenario: Check the possibility to switch on a dark theme in the application
    When I tap I have an account button
	When I tap Email field
	When I put personal emai 'gogi1234@gmail.com'
	When I tap on Password field
	When I put password 'gogi1234))'
	When I tap on Log in button  
	When Tap in the upper right corner of the Kebab Menu
	When From the offered list of options, select Settings
	When Swipe down
	When Find the Dark Mode field 
	When Select Always in Dark Mode
	Then The start page is displayed with a 'dark' theme

Feature: ChangeStartPage
	Simple calculator for adding two numbers
	As I user
	I want change to start page
	Then this is more comfortable

@mytag
Scenario: Check the possibility to change the start page 
	When Tap in the upper right corner of the Kebab Menu
	When From the offered list of options, select Settings
	When Find the App starts
	When Select page, what  you want to see like start page
	When Tap the button back
	Then The start page changed


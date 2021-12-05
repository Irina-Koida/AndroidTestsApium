Feature: DarkTeme
	The user has registered
	I want to switch on a dark theme
	Then load on the eyes will be less

@mytag
Scenario: Check the possibility to switch on a dark theme in the application
	When Tap in the upper right corner of the Kebab Menu
	When From the offered list of options, select Settings
	When Swipe down
	When Find the Dark Mode field 
	When Select Always in Dark Mode
	Then The start page is displayed with a 'dark' theme

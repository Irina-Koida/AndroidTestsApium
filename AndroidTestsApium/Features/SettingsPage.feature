Feature: ChangeStartPage
	Simple calculator for adding two numbers
	As I user
	I want change to start page
	Then this is more comfortable

@mytag
Scenario: Check the possibility to change the start page 
	When Tap in the upper right corner of the Kebab Menu
	When From the offered list of options, select Settings
	When Find the App start
	When Select page, what you want to see like start page
	When Tap to the button back
	Then The start page 'changed'

	
	@Settings @StartPage 
Scenario: Check the possibility of changing the country
	When Tap in the upper right corner of the Kebab Menu
	When From the offered list of options, select Settings
	When Select state country
	When Select state
	Then Country changed 'Idaho'

		
	@Settings @StartPage 
	Scenario: Check the possibility to select language
	When Tap in the upper right corner of the Kebab Menu
	When From the offered list of options, select Settings
	When Tap to choose the language
	When Select language
	Then Check that the settings are steel 'Impostazioni'
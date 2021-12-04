Feature: UseAppWithoutRegistering
	As a user
	I want to use the Vivino mobile app without registration
	In order to familiarize yourself with the application and understand if I will use it

@without @registration
Scenario: Go to the start page without registration
	When I tap a "Try us out" button
	When I tap "Next" button
	When I tap "Next" button
	When I tap "Next" button
	When I tap "Next" button
	When I select a "Continue without account" button
	Then My profile page is open

@without @registration
Scenario: It is possible to navigate to the selected wine
	When I tap "Search" section
	When I tap "Red" type
	Then I see a info text "Red"
	Then I see text with the count of wines "522 wines"
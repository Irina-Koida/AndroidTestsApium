﻿Feature: WhenUserSignIn
	As a user
	I want to sign in in app
	In order to use the full functionality

Scenario: It is possible to navigate to the selected wine
	When I tap I have an account button
	Then Welcome Back page with text "SIGN IN WITH EMAIL" opens
	When I tap Email field
	When I put personal emai "kataleua634@gmail.com"
	When I tap on Password field
	When I put password "naruto"
	When I tap on Log in button
	When I tap Search section
	When I tap "Red" type
	Then I see a info text "Red"
	Then I see text with the count of wines "521 wines"

Scenario: It is possible to navigate to the selected combination of something with wine
	When I tap I have an account button
	Then Welcome Back page with text "SIGN IN WITH EMAIL" opens
	When I tap Email field
	When I put personal emai "kataleua634@gmail.com"
	When I tap on Password field
	When I put password "naruto"
	When I tap on Log in button
	When I tap Search section
	When I tap "PAIRING" subsection
	When I tap "Lamb" pair
	Then I see a information text "Lamb"
	Then I see a text with the count of wines "344 wines"

Scenario: It is possible to navigate to the selected wine style
	When I tap I have an account button
	Then Welcome Back page with text "SIGN IN WITH EMAIL" opens
	When I tap Email field
	When I put personal emai "kataleua634@gmail.com"
	When I tap on Password field
	When I put password "naruto"
	When I tap on Log in button
	When I tap Search section
	When I tap subsection "STYLE"
	When I tap "Californian Cabernet Sauvignon" style
	Then I see a text "Californian Cabernet Sauvignon"
	Then I see text with the count of selected wines by style "1 wine"

Scenario: It is possible to navigate to the notifications page
	When I tap I have an account button
	Then Welcome Back page with text "SIGN IN WITH EMAIL" opens
	When I tap Email field
	When I put personal emai "kataleua634@gmail.com"
	When I tap on Password field
	When I put password "naruto"
	When I tap on Log in button
	When Tap the Notifications icon, it looks like a bell in the upper right corner
	Then I see text "You have no notifications"
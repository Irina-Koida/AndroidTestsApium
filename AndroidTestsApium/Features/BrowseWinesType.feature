Feature: BrowseWinesType
As a user
I want see full list of wines type in the Search page
In order to find fast the wine I need
  
Background:
Given User autorized
Given Search page is open

@TypeOfWines
Scenario: Check product card opens in list of Browse Wines Types
  When I tap "Type" item on header menu
  When I tap "Red" item on BrowseWines menu
  When I tap first product card
  Then Product card with title "Mica Cabernet Sauvignon 2018" opens
  When I tap on "Calculate your personal match" button
  Then Message window with title "You're a mystery to us" opens

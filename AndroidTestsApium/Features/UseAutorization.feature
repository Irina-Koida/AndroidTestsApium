Feature: UseAutorization
As a user
I want to autorized in the Sign in page
In order to get access to choose and buy wine


 @useAutorization 
Scenario: Check personal account opens when I do autorization
  When I tap I have an account button
  Then Welcome Back page with text "SIGN IN WITH EMAIL" opens 
  When I tap Email field 
  When I put personal emai "marineriscr@gmail.com"
  When I tap on Password field
  When I put password "14"
  When I tap on Log in button 
  Then For you page with title "Picked for you" opens 

  @useAutorization @typeOfWines
Scenario: Check product card opens in list of Browse Wines Types
  When I tap "Type" item on header menu
  When I tap "Red" item on BrowseWines menu
  When I tap first product card
  Then Product card with title "Mica Cabernet Sauvignon 2018" opens
  When I tap on "Calculate your personal match" button
  Then Message window with title "You're a mystery to us" opens

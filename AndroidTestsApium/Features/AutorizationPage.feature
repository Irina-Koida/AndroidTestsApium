Feature: AutorizationPage


@Autorization
Scenario: Autorization user want to go to app
	When I tap I have an account button
	When I tap Email field
	When I put personal emai 'gogi1234@gmail.com'
	When I tap on Password field
	When I put password 'gogi1234))'
	When I tap on Log in button
	Then For you page with title 'For you' opens
	
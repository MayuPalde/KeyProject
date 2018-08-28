Feature: Login
	In order to see my properties
	As a Property Owner 
	I want be able to login to the dashboard 

@mytag
Scenario: Successful Login By Owner 
	Given I Navigate to the login page 	
	When  I login with Username and Password on the Login Page 
	Then Owners dashboard page should be seen on the screen 
	
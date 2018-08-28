Feature: ListAsRental
	As a property owner 
	I want be able to add my property as a Rental Property




@mytag
Scenario: Add property as a rental property
	Given I Log in into the application
	 And  I navigate to List rental property page 
	And   I fill all the details of List Rental Property page
	  
	When I click on Save button 
	Then I should navigate to Rental Listing And Tenant Application page 



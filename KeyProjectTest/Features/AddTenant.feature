Feature: AddTenant
	As a Property Owner
	I want to be able to add new tenant to my property 

@mytag
Scenario: Add Tenant to the property 
	Given I log in into the application
	And  I fill the Tenant details page 
	And  I fill the Liability details page 

	When I click on 'Sumbit' button
	
	Then  Tenant Should be added to the property 
	
	
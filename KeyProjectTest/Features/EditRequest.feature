Feature: EditRequest
	In order to edit the request
	As a property owner 
	I want to be alredy send the request to my property tenant

@mytag
Scenario: Edit Tenant Request By sending new Periodic inspection date to the tenant
	Given I have logged in into the application 
	And   I navigated to My request page 
	And   I navigated to Edit request Page 
	When  I Enter New inspection date in description
	And   I  Click on Save Button 
	Then   I am able to see "Item Edited Successfully!" message on the screen 



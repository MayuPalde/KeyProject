Feature: DeleteRequest
	In order to  Delete the request
	As a property owner 
	I want to be already send the request to my property tenant 




	@mytag
Scenario: Delete Tenant Request if it is not valid 
	Given I logged in into the application
	And   I navigated to Myrequest page 
	And   I navigated to Delete Request page 
	When  I click on Confirm button  
	Then  I am able see "Item Deleted Successfully!" message on the screen 
	
Feature: AddNewRequest
	In order to send new request to the tenant
	As a property owner
	I want to have a tenant to my property 

@mytag
Scenario: Send New Request to the tenant
	Given I have logged in into the Application
	And  I navigated to My Request page 
	And  I Clicked on Add New Request
	And  I filled all the inforamtion on My request page 
	


	When I clicked on Save button
	Then I can see "Request Sent Successfully!" message on the screen











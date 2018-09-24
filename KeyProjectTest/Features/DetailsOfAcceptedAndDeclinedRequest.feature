Feature: DetailsOfAcceptedAndDeclinedRequest
	In order to see the details of my accepted and declined request by tenant 
	As a property owner 
	I want to be already send the rquest to the tenant 

@AcceptedRequestDetails
Scenario: As a property owner I am able to see the details of "Accepted" request by tenant
	Given I log in into the application
	And I navigate to "My Request" page 
	And I clicked on Acccepted link

	When I click on Details button
	Then I am able to see Details of accepted request 

@DeclinedRequestDetails
Scenario: As a property owner I am able to see the details of "Declined" request by tenant
	Given I log in into the application
	And I navigate to "My Request" page 
	And I clicked on Declined link

	When I click on Details button
	Then I am able to see Details of declined request 

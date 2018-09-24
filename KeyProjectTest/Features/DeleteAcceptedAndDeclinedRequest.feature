Feature: DeleteAcceptedAndDeclinedRequest
	In order to delete Accepted and Declined request
	As a Property Owner
	I want to be already have send request to my tenant

@DeleteAccepetdRequest
Scenario:Check if property owner can delete the accepted request
	Given I  have logged in into the application
	And I navigated to "MyRequest" page 
	And I clicked on Accepted link

	When I click on Delete button and Confirm my Delete request on accpted request page 
	Then I  am able to see "Item Deleted Successfully!" message on the screen

	@DeleteDeclinedRequest
	Scenario: Check if property owner can delete the declined request
	Given I  have logged in into the application
	And I navigated to "MyRequest" page 
	And I clicked on  Declined link

	When I click on Delete button and confirm my delete request on declined request page 
	Then I  am able to see "Item Deleted Successfully!" message on the screen
	
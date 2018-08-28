Feature: SendRequest
	In order to inform to my Tenant
	As a proprty Owner 
	I want to be able send request to them regarding routine inspection

@mytag
Scenario: Send request to the tenant for routine inspection 

	Given I Log in into the Application
	And  I navigate to General Request Page 
	And  I fill all the information regarding routine inspection request

	When I click on Save Button 
	Then  Request should be successfully send to the respective tenant 




Feature: PULLFeature
	This feature validates the different APIs in PULL functionality.


	@Retriving pull request details
Scenario: API which gives a particular pull request details
	Given I have configured the API with respective pull request 
	And I provided all the required details
	When I invoke the API with all the  parameters
	Then I should see all the pull request details


@creating a pull request - POST Request
Scenario: Creating a pull request for a given repo between source and target branch
	Given I have configured the API with necessary parameters
	And provided values for all required parameters
	When I invoke the API with required data
	Then it should create a pull request

	@Retrieving the pull commit detais
Scenario: API whih list out the commits in a particular pull request.
	Given I have configured the API with necessary details
	And provided all required inputs
	When I invoke the API with all the input parameters
	Then It should provide all the commits of a particular pull request

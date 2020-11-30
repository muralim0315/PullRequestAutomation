Feature: Merge
	This will perform various validations while creatng a pull request.

Background: 
Given I have navigated to the application
	And I see application opened
	When I enter below UserName and Password
	| UserName              | Password     |
	| muralim0315@gmail.com | asaisiri303 |
	And I click sign in button 
	Then I should get navigated to Homepage

@When Target and source have no differences
Scenario: When Target and source branches have no differences.
	Given I have navigated to HarbourbridgeRepo
	And I see landed in the correct repo page
	Then I try to create a new pull request
	And I select source branch
	Then Pull request option should not be there.

@When Source is ahead of target
Scenario: When source brach is ahead of target branch
	Given I have navigated to Kakadu repo
	And I see landed in to the correct repo page
	When I try to create a new pull request
	And I Select the source branch inorder to merge into the target branch
	Then I should see the create pull request option available to merge into target branch.
	 
@When there is already a pull request exists.
Scenario: When already one existing pull request exists
	Given I have navigated to Campbell town repo
	And I see landed into the correct repo page
	When I try to  create a new pull request
	And I Select the  source branch inorder to merge into the target branch
	Then I should see the view pull request option instead creating a new one 

@When source and target branches are same
Scenario: When try to merge same branch to target branch
	Given I have navigated to OperaHouse repo
	And I landed into the OperaHouse repo page
	Then I try to create a new pull request for the repo
	When I select the soure branch same as target branch
	Then I should see the validation message stating source and target should not be the same


	
Feature: Login
	

@mytag
Scenario: Login With Property Owner
	Given I have logged in home page with valid Owner
	When I try to add new job
	Then the job gets added
@mytag
	Scenario: Login With Service Supplier
	Given I have logged in with valid Service Supplier
	When I try to apply for new job
	Then I can successfully apply for the jo
@Add @Calc
Feature: Calculator Add

@add
Scenario: Add two numbers
	Given I have entered 80 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 150 on the screen

@add
Scenario: Add same two numbers
	Given I have entered 60 into the calculator
	And I have entered 60 into the calculator
	When I press add
	Then the result should be 120 on the screen

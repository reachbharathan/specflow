@Subract @Calc
Feature: Calculator Subract

@subtract
Scenario: Subract two numbers
	Given I have entered 80 into the calculator
	And I have entered 70 into the calculator
	When I press subract
	Then the result should be 10 on the screen

@subtract
Scenario: Subract same two numbers
	Given I have entered 60 into the calculator
	And I have entered 60 into the calculator
	When I press subract
	Then the result should be 0 on the screen

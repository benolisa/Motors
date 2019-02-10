Feature: CustomerCanViewCarPrice
	In order to know the cost of a car
	As a Customer
	I want the ability to view car price


Scenario: Customer can view the cost of a car
	Given I navigate to Motors homepage
	When I enter postcode
	And i select the make of the car
	And I select the model of the car
	And i click on search button
	And i click on the first result
	Then the price of the car selected is displayed

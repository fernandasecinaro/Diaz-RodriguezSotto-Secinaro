Feature: ChargePoints

A short summary of the feature

@tag1
Scenario: Create charging point with valid data
	Given the id 1234
	And the name "punto de carga"
	And the address "cuareim"
	And the tourist spot 1
	And the description "Un nuevo punto de carga"
	When I click "Add charging point"
	Then a new charging point is added

Scenario: Create charging point with invalid id
	Given the id 12345
	And the name "punto de carga"
	And the address "cuareim"
	And the tourist spot 1
	And the description "Un nuevo punto de carga"
	When I click "Add charging point"
	Then I recieve a message showing "Invalid id" 


Scenario: Create charging point with invalid name
	Given the id 1234
	And the name "punto de cargaaaaaaaaa"
	And the address "cuareim"
	And the tourist spot 1
	And the description "Un nuevo punto de carga"
	When I click "Add charging point"
	Then I recieve a message showing "Invalid name"

Scenario: Create charging point with invalid address
	Given the id 1234
	And the name "punto de carga"
	And the address "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
	And the tourist spot 1
	And the description "Un nuevo punto de carga"
	When I click "Add charging point"
	Then I recieve a message showing "Invalid address" 

Scenario: Create charging point with invalid tourist spot
	Given the id 1234
	And the name "punto de carga"
	And the address "cuareim"
	And the tourist spot "xyz"
	And the description "Un nuevo punto de carga"
	When I click "Add charging point"
	Then I recieve a message showing "Invalid tourist spot" 

Scenario: Create charging point with invalid description
	Given the id 1234
	And the name "punto de carga"
	And the address "cuareim"
	And the tourist spot 1
	And the description "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
	When I click "Add charging point"
	Then I recieve a message showing "Invalid description" 

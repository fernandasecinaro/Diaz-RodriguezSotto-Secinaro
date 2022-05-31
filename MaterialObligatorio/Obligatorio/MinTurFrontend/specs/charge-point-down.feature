Feature: Charging Point Elimination

    Eliminates a charging point from the system

  Scenario: Eliminate a charging point using a valid id
    Given the id "1234"
    When I press the "Dar de baja" button
    Then I should see the message "El punto de carga ha sido dado de baja"

  Scenario: Eliminate a charging point using an invalid id
    Given the url "http://localhost:4200/remove-charging-points"
    Given the id "12345"
    When I click the "Dar de baja" button
    When I wait for 2 seconds
    Then I should see the message "Id invalida"

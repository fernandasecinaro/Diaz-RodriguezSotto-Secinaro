Feature: Charging Point Elimination

    Eliminates a charging point from the system

  Scenario: Eliminate a charging point using a valid id
    Given the url "http://localhost:4200/remove-charging-point"
    Given the id "1264"
    When I click the "Dar de baja" button
    When I wait for 2000 ms
    Then I should see the message "El punto de carga ha sido dado de baja"


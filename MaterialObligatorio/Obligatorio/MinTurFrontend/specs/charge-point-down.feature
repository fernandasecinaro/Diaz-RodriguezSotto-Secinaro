Feature: Charging Point Elimination

    Eliminates a charging point from the system

  Scenario: Eliminate a charging point using a valid id
    Given I view the "http://localhost:4200/charging-points-registration"
    Given the id to delete is 1264
    When I click on "Dar de baja" button
    Then the charging point is deleted and a success message "El punto de carga ha sido dado de baja" is shown

  Scenario: Eliminate a charging point using an invalid id
    Given I view the "http://localhost:4200/charging-points-registration"
    Given the id to delete is 164
    When I click on "Dar de baja" button
    Then the charging point is not deleted and an error message "El id debe ser de 4 dígitos" is shown

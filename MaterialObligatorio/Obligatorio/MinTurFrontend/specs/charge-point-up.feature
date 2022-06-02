Feature: Charging Point Registration 

  Scenario: Valid charging point registration
    Given I view the "http://localhost:4200/charging-points-registration"
    And the Id input has the value 1234
    And the name input has the value "Parque Prado"
    And the address input has the Value "Cuareim"
    And the region input has the value 1
    And the description input has the value "Punto de carga Prado"
    When I click on button "Dar de alta"
    Then the charging point is registered and a success message "¡Éxito!" is shown

  Scenario: Charging point registration with invalid id
    Given I view the "http://localhost:4200/charging-points-registration"
    And the Id input has the value 123
    And the name input has the value "Parque Prado"
    And the address input has the Value "Cuareim"
    And the region input has the value 1
    And the description input has the value "Punto de carga Prado"
    When I click on button "Dar de alta"
    Then the charging point is not registered and an error message "El id debe ser de 4 dígitos" is shown

  Scenario: Charging point registration with invalid name
    Given I view the "http://localhost:4200/charging-points-registration"
    And the Id input has the value 1234
    And the name input has the value ""
    And the address input has the Value "Cuareim"
    And the region input has the value 1
    And the description input has the value "Punto de carga Prado"
    When I click on button "Dar de alta"
    Then the charging point is not registered and an error message "Es necesario especificar un nombre" is shown

  Scenario: Charging point registration with invalid address
    Given I view the "http://localhost:4200/charging-points-registration"
    And the Id input has the value 1234
    And the name input has the value "Parque Prado"
    And the address input has the Value ""
    And the region input has the value 1
    And the description input has the value "Punto de carga Prado"
    When I click on button "Dar de alta"
    Then the charging point is not registered and an error message "Es necesario especificar una dirección" is shown

  Scenario: Charging point registration with invalid region
    Given I view the "http://localhost:4200/charging-points-registration"
    And the Id input has the value 1234
    And the name input has the value "Parque Prado"
    And the address input has the Value "Cuareim"
    And the region input has the value 0
    And the description input has the value "Punto de carga Prado"
    When I click on button "Dar de alta"
    Then the charging point is not registered and an error message "Es necesario especificar una región" is shown

  Scenario: Charging point registration with invalid description
    Given I view the "http://localhost:4200/charging-points-registration"
    And the Id input has the value 1234
    And the name input has the value "Parque Prado"
    And the address input has the Value "Cuareim"
    And the region input has the value 1
    And the description input has the value ""
    When I click on button "Dar de alta"
    Then the charging point is not registered and an error message "Es necesario especificar una dirección" is shown
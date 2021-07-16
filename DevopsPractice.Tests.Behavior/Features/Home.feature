Feature: Home

    
Scenario: Send get request to /
    Given I input the app url
    When I send the get request
    Then The result should be 'Welcome to calculator web api!'
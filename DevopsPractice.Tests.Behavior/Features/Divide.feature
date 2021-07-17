Feature: Divide

Scenario: Divide two numbers
	Given I input numbers <num1> and <num2>
    When I send divide request
    Then the result <result> should be the division

    Examples:
        | num1 | num2  | result  |
        | 2    | 2     | 1       |
        | 1    | 4     | 0.25    |
        | 100  | 20    | 5       |
        | 0    | 47    | 0       |
        | 1    | -1    | Invalid |
        | -5   | 3     | Invalid |
        | 4    | 0     | Invalid |

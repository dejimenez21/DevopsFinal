Feature: Multiply

Scenario: Multiply two numbers
	Given I input numbers <num1> and <num2>
    When I send multiply request
    Then the result <result> should be the multiplication

    Examples:
        | num1 | num2  | result  |
        | 2    | 2     | 4       |
        | 1    | 12    | 12      |
        | 100  | 20    | 2000    |
        | 0    | 0     | 0       |
        | 0    | 47    | 0       |
        | 1    | -1    | Invalid |
        | -5   | 3     | Invalid |

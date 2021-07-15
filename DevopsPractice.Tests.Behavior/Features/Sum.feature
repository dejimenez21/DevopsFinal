Feature: Sum
	Simple calculator for adding two numbers

Scenario: Add two numbers
	Given I input numbers <num1> and <num2>
    When I send sum request
    Then the result <result> should be the sum

    Examples:
        | num1 | num2  | result  |
        | 2    | 2     | 4       |
        | 1    | 12    | 13      |
        | 100  | 1000  | 1100    |
        | 0    | 0     | 0       |
        | 1    | -1    | Invalid |

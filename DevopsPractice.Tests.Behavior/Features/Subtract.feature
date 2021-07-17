Feature: Subtract

Scenario: Subtract two numbers
	Given I input numbers <num1> and <num2>
    When I send subtract request
    Then the result <result> should be the subtraction

    Examples:
        | num1 | num2 | result  |
        | 2    | 2    | 0       |
        | 5    | 3    | 2       |
        | 1000 | 500  | 500     |
        | 0    | 0    | 0       |
        | 1    | -2   | Invalid |
        | -8   | 2    | Invalid |
        | 4    | 8    | Invalid |
        | 100  | 200  | Invalid |

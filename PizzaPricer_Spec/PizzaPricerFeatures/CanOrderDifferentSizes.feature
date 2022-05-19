Feature: Multiple Sized Pizzas can be ordered

    As a pizza lover 
    I want to be able to order different sizes of pizzas 
    so I can match my appetite

    Scenario: The customer can get the price of a small pizza with no toppings
    Given a customer orders 1 small pizza
    When the order is summarized
    Then the order summary shows: 1 small pizza - $6.00

    Scenario: The customer can get the price of a medium pizza with no toppings
    Given a customer orders 1 medium pizza
    When the order is summarized
    Then the order summary shows: 1 medium pizza - $9.00

    Scenario: The customer can get the price of a large pizza with no toppings
    Given a customer orders 1 large pizza
    When the order is summarized
    Then the order summary shows: 1 large pizza - $12.00
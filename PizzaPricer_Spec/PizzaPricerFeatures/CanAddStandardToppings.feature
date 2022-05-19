Feature: Customer can order a pizza with standard toppings
As a pizza lover
I want to be able to choose my toppings
So I can get a pizza that suits my tastes

#Each Standard topping adds 8% to the the base price of the pizza ordered

Scenario: The customer can order a medium pizza with one standard topping
Given a customer orders 1 medium pizza
    And 1 standard topping is added to the pizza
When the order is summarized
Then the order summary shows: 1 medium pizza (1 standard topping) - $9.72

Scenario: The customer can order a small pizza with two standard toppings
Given a customer orders 1 small pizza
    And 2 standard toppings are added to the pizza
When the order is summarized
Then the order summary shows: 1 small pizza (2 standard toppings) - $6.96
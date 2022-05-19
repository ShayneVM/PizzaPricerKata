# PizzaPricerKata
Test Driven Development/Emergent Design Kata based around building a pricing model for pizza

## Scenario
You're being asked to write a module that prices the pizzas that Pizza Driven Development sells. They offer several sizes, as well as two different categories of toppings. The price of the toppings are a percentage of the base pizza price

### Supported Sizes
| Size   | Price |
| ------ | ----- |
| small  | $6    |
| medium | $9    |
| large  | $12   |

### Supported Toppings
| Type | Percentage |
|----|---|
| Standard | 8% |
| Premium | 12% |

### Examples
- A small pizza with 2 toppings would generate this output: "1 small pizza (toppings: 2 standard) - $6.96"
- A large pizza with 1 standard and 2 premium toppings would generate this output: "1 large pizza (toppings: 1 standard, 2 premium) - $15.84"

## Contents
- PizzaPricer: Pricing module library with basic functionality, that will be extended as people work through the problem.
- PizzaPricer_Spec: Tests for the PizzaPricer. These are both in standard simple Unit Tests as well as SpecFlow features and Step definition. The SpecFlow material is intentionally incomplete. Also, of note this uses MSTest (based on my client's needs), this can be easily modified to other frameworks with minimal work.
- OrderConsole: Simple console test harness to exercise the code in a plausible way. Very basic, and rudimentary.

## Facilitation Notes
This Kata can be facilitated in many ways. It starts simple but gets very complex quickly. It can also be tweaked and adjusted in ways that put the cohort's designs to the test.

### Most Primitive form
*Primary goal: TDD and Pairing*

Introduce the problem and the interface (IPizzaOrderPricer) to the cohort, with the OrderConsole using it. Consider having a stub implment the interface. Have them implement the system. Encourage Test Driven Iterative development and pairing.

### Intro to BDD
*Primary goal: Illustrate basic Cucumber/Specflow functionality*

Use the files as posted. There is a simple application in the library that prices the pizza sizes, but none of the toppings. The feature for ordering different sizes of pizza is completely hooked up and functional. The feature for adding standard toppings is missing step definitions, and the feature for adding premium toppings is missing scenarios. 
1. Start by showing the current state of the console application (will only price correctly the sizes of pizzas). 
2. Run the tests and show the results. Focus on the order different sizes feature. Consider tweaking the feature file to illustrate that the tests are actually testing the code.
3. Show the adding standard toppings feature and the non-implemented steps.
4. Work with the group to implement the step definition, and show the correctly failing test
5. Work with the group in making that test pass
6. Work with the group creating the scenarios for premium toppings. Challenge them to come up with edge cases etc.

## Twists
There are many twists and curveballs you can add if people find this too easy, and also as a way to challenge their design. Here are a few that I've used, or plan to use (many of these would require changes to the test harness)
- Add another size or topping type (such as Extra-Large, or Gourmet Toppings)
- Have them name the toppings (pepperoni, sausage, olives, goat cheese), and return that in the topping list, grouped and priced appropriately

### Requiring Interface changes
- Add another product, such as calzones
- Add a quantity of pizzas to be ordered and/or allow different halves to have different prices (Pepperoni on one half, and sausage and mushrooms on the other)
- Add the ability to revise your order (remove a topping)

### If you want to give a major challenge
Write a really bad implementation of the system that "works" make sure it has side effects and other weird gotchas, but on the whole it meets the requirements, and do everything opposite of making good code. If you do provide tests, have them really bad... like test themselves not the code etc. Also don't skimp on bad naming. Have the cohort get that code, and extend it in some way.... The intent is to give the experience of maintaining bad code, and how they might work to make headway in that environment. This can be used as a way to teach and encourage charactaristic testing.
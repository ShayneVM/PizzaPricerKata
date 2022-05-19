
// See https://aka.ms/new-console-template for more information

class Program
{
    private enum PizzaSizes{ small, medium, large};

    private enum ToppingTypes {standard, premium};

    static void Main(string[] args)
    {        
        Console.WriteLine ("Welcome to the Pizza Ordering System");
        var pizzaPricer = PizzaOrderPricer.GetInstance();
        var doneOrdering = false;
        while(!doneOrdering){
            Console.WriteLine("================================");
            var orderActive = NewPizzaOrder(pizzaPricer);

            while (orderActive){
                Console.WriteLine("[A]dd Toppings | [S]ummarize Order | [N]ew Order | [Q]uit");
                
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        var addingToppings = true;
                        while(addingToppings)
                        {
                            addingToppings = AddToppings(pizzaPricer);
                        }
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine();
                        Console.WriteLine("Order Summary:");
                        Console.WriteLine(pizzaPricer.GetSummary());
                        Console.WriteLine();
                        break;
                    case ConsoleKey.N:
                        orderActive = false;
                        break;
                    case ConsoleKey.Q:
                        orderActive = false;
                        doneOrdering = true;
                        break;
                }
                
            }
        }
        Console.WriteLine ("Quitting Pizza Ordering System");
    }

    private static bool NewPizzaOrder(IPizzaOrderPricer pricer){
        Console.WriteLine("What size of pizza would you like? ([S]mall | [M]edium | [L]arge");
        var selectedSize = string.Empty;
        switch(Console.ReadKey(true).Key)
        {
            case ConsoleKey.S:
                selectedSize = "small";
                break;
            case ConsoleKey.M:
                selectedSize = "medium";
                break;
            case ConsoleKey.L:
                selectedSize = "large";
                break;
            default:
                return false;
        }
        pricer.StartOrder(selectedSize);
        Console.WriteLine();
        Console.WriteLine("Started an order of a {0} pizza", selectedSize);
        return true;
    }

    private static bool AddToppings(IPizzaOrderPricer pricer)
    {
        Console.WriteLine("Add a topping? ([S]tandard | [P]remium | [SpaceBar] when done)");
        var selectedToppingType = string.Empty;
        switch(Console.ReadKey(true).Key)
        {
            case ConsoleKey.Spacebar:
                return false;
            case ConsoleKey.S:
                selectedToppingType = "standard";
                break;
            case ConsoleKey.P:
                selectedToppingType = "premium";
                break;
        }
        
        if(selectedToppingType!=string.Empty){
            Console.WriteLine("{0} topping added",selectedToppingType);
            pricer.AddTopping(selectedToppingType);
        }
        return true;
    }

}
namespace PizzaPricer
{
    public interface IPizzaOrderPricer
    {
        public void StartOrder(string size);
        public void AddTopping(string toppingType);
        public string GetSummary();
    }
}
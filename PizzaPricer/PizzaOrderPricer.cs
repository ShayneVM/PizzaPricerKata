

namespace PizzaPricer
{

    public class PizzaOrderPricer : IPizzaOrderPricer 
    {
        private Dictionary<string, decimal> _pizzaPrices = new Dictionary<string, decimal>()
            {
                {"small", 6m},
                {"medium", 9m},
                {"large", 12m}
            };

        private string _selectedSize = string.Empty;

        public static IPizzaOrderPricer GetInstance()
        {
            return new PizzaOrderPricer();
        }

        private PizzaOrderPricer()
        {
        }
        public void StartOrder(string size)
        {
            _selectedSize = size;
        }

        public void AddTopping(string toppingType){
            
        }
        public string GetSummary()
        {
            var price = _pizzaPrices[_selectedSize];

            return string.Format("1 {0} pizza - ${1:0.00}",_selectedSize, price);
        }
    }
}
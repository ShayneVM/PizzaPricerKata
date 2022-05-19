
namespace PizzaPricer_Spec{

    [TestClass]
    public class CustomerCanPriceDifferentSizedPizzas
    {

        [TestMethod]
        public void CustomerCanOrderASingleSmallPizza(){
            var pizzaOrderPricer = PizzaOrderPricer.GetInstance();
            pizzaOrderPricer.StartOrder("small");
            Assert.AreEqual("1 small pizza - $6.00",pizzaOrderPricer.GetSummary());
        }
        
        [TestMethod]
        public void CustomerCanOrderASingleMediumPizza(){
            var pizzaOrderPricer = PizzaOrderPricer.GetInstance();
            pizzaOrderPricer.StartOrder("medium");
            Assert.AreEqual("1 medium pizza - $9.00",pizzaOrderPricer.GetSummary());
        }
        
        [TestMethod]
        public void CustomerCanOrderASingleLargePizza(){
            var pizzaOrderPricer = PizzaOrderPricer.GetInstance();
            pizzaOrderPricer.StartOrder("large");
            Assert.AreEqual("1 large pizza - $12.00",pizzaOrderPricer.GetSummary());
        }
    }
}
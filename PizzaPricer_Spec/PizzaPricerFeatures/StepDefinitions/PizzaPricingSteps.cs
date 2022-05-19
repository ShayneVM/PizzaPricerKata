using System;
using TechTalk.SpecFlow;

namespace PizzaPricingSteps
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PizzaOrderContext _pizzaOrderContext;

        public StepDefinitions(PizzaOrderContext pizzaOrderContext, ScenarioContext scenarioContext)
        {
            _pizzaOrderContext = pizzaOrderContext;
            _scenarioContext = scenarioContext;
        }
        [Given(@"a customer orders 1 (.*) pizza")]
        public void GivenACustomerOrdersOnePizza(string size)
        {
            _pizzaOrderContext.Size = size;
        }
        
        [When(@"the order is summarized")]
        public void WhenTheOrderIsSummarized()
        {
            var pizzaOrderPricer = PizzaOrderPricer.GetInstance();
            pizzaOrderPricer.StartOrder(_pizzaOrderContext.Size);
            _pizzaOrderContext.Summary = pizzaOrderPricer.GetSummary();
        }
        
        [Then(@"the order summary shows: (.*)")]
        public void ThenTheOrderSummaryShows(string orderSummary)
        {
            Assert.AreEqual(orderSummary, _pizzaOrderContext.Summary);
        }

    }

    public class PizzaOrderContext {
        public string Size {get;set;}
        public string Summary {get;set;}
    }
}

using MarketManager.View;

namespace MarketManager.Controller
{
    public class StockController
    {
        public StockView View { get; }

        public StockController(StockView view)
        {
            View = view;
        }
    }
}

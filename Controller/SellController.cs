using MarketManager.View;

namespace MarketManager.Controller
{
    public class SellController
    {
        public SellView View { get; }

        public SellController(SellView view)
        {
            View = view;
        }
    }
}

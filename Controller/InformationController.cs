using MarketManager.View;

namespace MarketManager.Controller
{
    public class InformationController
    {
        public InformationView View { get; }

        public InformationController(InformationView view)
        {
            View = view;
        }
    }
}

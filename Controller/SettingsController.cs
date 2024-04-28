using MarketManager.View;

namespace MarketManager.Controller
{
    public class SettingsController
    {
        public SettingsView View { get; }

        public SettingsController(SettingsView view)
        {
            View = view;
        }

    }
}

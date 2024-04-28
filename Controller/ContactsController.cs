using MarketManager.View;

namespace MarketManager.Controller
{
    public class ContactsController
    {
        public ContactsView View { get; }

        public ContactsController(ContactsView view)
        {
            View = view;
        }
    }
}

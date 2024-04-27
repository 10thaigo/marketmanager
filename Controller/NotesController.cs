using MarketManager.View;

namespace MarketManager.Controller
{
    public class NotesController
    {
        public NotesView View { get; }

        public NotesController(NotesView view)
        {
            View = view;
        }

    }
}

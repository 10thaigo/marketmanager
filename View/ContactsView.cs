using System.Windows.Forms;

namespace MarketManager.View
{
    public partial class ContactsView : Form
    {
        public ContactsView()
        {
            InitializeComponent();
        }

        public void UpdateLabel(string text)
        {
            label_info.Visible = true;
            panel_contacts.Visible = false;
            label_info.Text = text;
        }
    }
}

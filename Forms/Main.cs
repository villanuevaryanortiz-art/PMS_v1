using pms_UI.User_Controls;
using PMS_v1.UserControls;

namespace pms_UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            header1.MenuToggleClicked += Header_MenuToggleClicked;
            sideMenu1.PageRequested += ShowPage;
            sideMenuCompact1.PageRequested += ShowPage;
        }

        private void Header_MenuToggleClicked(object? sender, EventArgs e)
        {
            bool goCompact = sideMenu1.Visible;
            sideMenu1.Visible = !goCompact;
            sideMenuCompact1.Visible = goCompact;
        }

        private void ShowPage(string name)
        {
            // Swap the page into your content panel, for example:
            //contentPanel.Controls.Clear();
            //var page = new DashboardPage { Dock = DockStyle.Fill };
            //contentPanel.Controls.Add(page);
        }
    }
}

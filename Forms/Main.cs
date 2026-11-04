using Krypton.Toolkit;
using pms_UI.User_Controls;
using PMS_v1.UserControls;
using System.Configuration;

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

            sideMenu1.PageRequested += SideMenu_PageRequested;
            sideMenuCompact1.PageRequested += SideMenu_PageRequested;

        }

        private void Header_MenuToggleClicked(object? sender, EventArgs e)
        {
            bool goCompact = sideMenu1.Visible;
            sideMenu1.Visible = !goCompact;
            sideMenuCompact1.Visible = goCompact;
        }

        private void SideMenu_PageRequested(string page)
        {
            switch (page)
            {
                //case "Dashboard": ShowPage(new DashboardPage()); break;
                //case "Properties": ShowPage(new PropertiesPage()); break;
                //case "Tenants": ShowPage(new TenantsPage()); break;
                //case "Leasing": ShowPage(new LeasingPage()); break;
                //case "Billing": ShowPage(new BillingPage()); break;
                //case "Payment": ShowPage(new PaymentPage()); break;
                //case "Maintenance": ShowPage(new MaintenancePage()); break;
                //case "Reports": ShowPage(new ReportsPage()); break;
                //case "Settings": ShowPage(new SettingsPage()); break;
                case "Logout": Logout(); break;
            }
        }

        private void ShowPage(string name)
        {
            // Swap the page into your content panel, for example:
            //contentPanel.Controls.Clear();
            //var page = new DashboardPage { Dock = DockStyle.Fill };
            //contentPanel.Controls.Add(page);
        }

        public bool LoggedOut { get; private set; }

        private void Logout()
        {
            var result = MessageBox.Show(this, "Are you sure you want to log out?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            LoggedOut = true;
            Close();
        }
    }
}

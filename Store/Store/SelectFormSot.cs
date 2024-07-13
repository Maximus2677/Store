using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class SelectFormSot : Form
    {
        bool ad;

        public SelectFormSot(bool ad)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ad = ad;
        }

        private void AdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        private void SelectFormSot_Load(object sender, EventArgs e)
        {
            if (ad)
            {
                AdminPanel.Enabled = true;
            }
        }

        private void Katalog_Click(object sender, EventArgs e)
        {
            Katalog katalog = new Katalog(true, 0);
            katalog.ShowDialog();
        }

        private void Zakazes_Click(object sender, EventArgs e)
        {
            OrdersView ordersView = new OrdersView(true , 0);
            ordersView.ShowDialog();
        }
    }
}

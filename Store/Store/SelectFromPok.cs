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
    public partial class SelectFromPok : Form
    {
        int idu;

        public SelectFromPok(int idu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.idu = idu;
        }

        private void SelectFromPok_Load(object sender, EventArgs e)
        {

        }

        private void Katalog_Click(object sender, EventArgs e)
        {
            Katalog katalog = new Katalog(false, idu);
            katalog.ShowDialog();
        }

        private void Kabinet_Click(object sender, EventArgs e)
        {
            Kabinet kabinet = new Kabinet(idu);
            kabinet.ShowDialog();
        }

        private void Zakazes_Click(object sender, EventArgs e)
        {
            OrdersView ordersView = new OrdersView(false , idu);
            ordersView.ShowDialog();
        }
    }
}

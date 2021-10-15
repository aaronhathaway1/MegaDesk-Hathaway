using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hathaway
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            //Add Enums into surface material combo box
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                                                .Cast<DesktopMaterial>()
                                                .ToList();
            cmbSurfaceMaterial.DataSource = materials;
            cmbSurfaceMaterial.SelectedIndex = -1;

            //Add Enums into shipping combo box
            List<ShippingSpeed> shipping = Enum.GetValues(typeof(ShippingSpeed))
                                           .Cast<ShippingSpeed>()
                                           .ToList();
            cmbShipping.DataSource = shipping;
            cmbShipping.SelectedIndex = -1;

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            this.Hide();
        }

        
    }
}

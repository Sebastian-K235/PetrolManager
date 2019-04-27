using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PetrolManager
{
    public partial class FormSimulation : Form
    {
        #region Properties
        #endregion

        #region Methods
        public FormSimulation()
        {
            InitializeComponent();
            Data.AccessControls(this);
            Data.GeneratePumps();

        }

        private void btnSimBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void FormSimulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Data.StopGeneratingVehicles();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Data.GenerateVehicles();
            lblTest1.Text = this.Contains(pcbPump1).ToString();
        }
        #endregion
    }
}

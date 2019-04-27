using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolManager
{
    public partial class FormMenu : Form
    {
        #region Properties
        FormSimulation simulationForm = new FormSimulation();
        #endregion

        #region Methods

        public FormMenu()
        {
            InitializeComponent();
        }
        
        
        /// <summary>
        /// Button click event to exit the whole program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /// <summary>
        /// Opens up the simulation form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            simulationForm.Show();
            this.Hide();
        }
        #endregion


    }
}

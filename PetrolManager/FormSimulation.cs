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
        public static List<PictureBox> PumpPictures = new List<PictureBox>();
        public List<PictureBox> QueuePictures = new List<PictureBox>();
        #endregion

        #region Methods
        public FormSimulation()
        {
            InitializeComponent();
            ListPictures();
            Data.InitializeGeneration();
            Counters.SetPrices();
        }

        private void ListPictures()
        {
            ListPumpPictures();
            ListQueuePictures();
        }
        private void ListPumpPictures()
        {
            PumpPictures.Add(pcbPump1);
            PumpPictures.Add(pcbPump2);
            PumpPictures.Add(pcbPump3);
            PumpPictures.Add(pcbPump4);
            PumpPictures.Add(pcbPump5);
            PumpPictures.Add(pcbPump6);
            PumpPictures.Add(pcbPump7);
            PumpPictures.Add(pcbPump8);
            PumpPictures.Add(pcbPump9);
        }
        private void ListQueuePictures()
        {
            QueuePictures.Add(pcbVehicle1);
            QueuePictures.Add(pcbVehicle2);
            QueuePictures.Add(pcbVehicle3);
            QueuePictures.Add(pcbVehicle4);
            QueuePictures.Add(pcbVehicle5);
        }

        #endregion

        #region Events


        private void tmrAppLoop_Tick(object sender, EventArgs e)
        {
            Data.CheckQueue();
            Display.DisplayUI(this);
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

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Data.StartGeneratingVehicles();
        }

        #endregion

    }
}

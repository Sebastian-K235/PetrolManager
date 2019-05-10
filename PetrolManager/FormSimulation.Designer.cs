namespace PetrolManager
{
    partial class FormSimulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimulation));
            this.btnSimBack = new System.Windows.Forms.Button();
            this.pnlPumps = new System.Windows.Forms.Panel();
            this.lblLane3 = new System.Windows.Forms.Label();
            this.lblLane2 = new System.Windows.Forms.Label();
            this.lblLane1 = new System.Windows.Forms.Label();
            this.pcbPump7 = new System.Windows.Forms.PictureBox();
            this.pcbPump4 = new System.Windows.Forms.PictureBox();
            this.pcbPump5 = new System.Windows.Forms.PictureBox();
            this.pcbPump8 = new System.Windows.Forms.PictureBox();
            this.pcbPump9 = new System.Windows.Forms.PictureBox();
            this.pcbPump6 = new System.Windows.Forms.PictureBox();
            this.pcbPump2 = new System.Windows.Forms.PictureBox();
            this.pcbPump3 = new System.Windows.Forms.PictureBox();
            this.pcbPump1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStationQueue = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.pcbVehicle2 = new System.Windows.Forms.PictureBox();
            this.pcbVehicle1 = new System.Windows.Forms.PictureBox();
            this.pcbVehicle5 = new System.Windows.Forms.PictureBox();
            this.pcbVehicle3 = new System.Windows.Forms.PictureBox();
            this.pcbVehicle4 = new System.Windows.Forms.PictureBox();
            this.tbxTransactionList = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalUnleaded = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblVehiclesServiced = new System.Windows.Forms.Label();
            this.lblVehiclesUnserviced = new System.Windows.Forms.Label();
            this.tmrAppLoop = new System.Windows.Forms.Timer(this.components);
            this.lblTotalLPG = new System.Windows.Forms.Label();
            this.lblTotalDiesel = new System.Windows.Forms.Label();
            this.tmrQueueCheck = new System.Windows.Forms.Timer(this.components);
            this.lblTransactionList = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlPumps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimBack
            // 
            this.btnSimBack.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimBack.Location = new System.Drawing.Point(339, 581);
            this.btnSimBack.Name = "btnSimBack";
            this.btnSimBack.Size = new System.Drawing.Size(83, 39);
            this.btnSimBack.TabIndex = 0;
            this.btnSimBack.Text = "Back";
            this.btnSimBack.UseVisualStyleBackColor = true;
            this.btnSimBack.Click += new System.EventHandler(this.btnSimBack_Click);
            // 
            // pnlPumps
            // 
            this.pnlPumps.Controls.Add(this.lblLane3);
            this.pnlPumps.Controls.Add(this.lblLane2);
            this.pnlPumps.Controls.Add(this.lblLane1);
            this.pnlPumps.Controls.Add(this.pcbPump7);
            this.pnlPumps.Controls.Add(this.pcbPump4);
            this.pnlPumps.Controls.Add(this.pcbPump5);
            this.pnlPumps.Controls.Add(this.pcbPump8);
            this.pnlPumps.Controls.Add(this.pcbPump9);
            this.pnlPumps.Controls.Add(this.pcbPump6);
            this.pnlPumps.Controls.Add(this.pcbPump2);
            this.pnlPumps.Controls.Add(this.pcbPump3);
            this.pnlPumps.Controls.Add(this.pcbPump1);
            this.pnlPumps.Location = new System.Drawing.Point(512, 13);
            this.pnlPumps.Name = "pnlPumps";
            this.pnlPumps.Size = new System.Drawing.Size(370, 351);
            this.pnlPumps.TabIndex = 10;
            // 
            // lblLane3
            // 
            this.lblLane3.AutoSize = true;
            this.lblLane3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane3.Location = new System.Drawing.Point(290, 250);
            this.lblLane3.Name = "lblLane3";
            this.lblLane3.Size = new System.Drawing.Size(71, 18);
            this.lblLane3.TabIndex = 30;
            this.lblLane3.Text = "3rd Lane";
            // 
            // lblLane2
            // 
            this.lblLane2.AutoSize = true;
            this.lblLane2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane2.Location = new System.Drawing.Point(290, 136);
            this.lblLane2.Name = "lblLane2";
            this.lblLane2.Size = new System.Drawing.Size(75, 18);
            this.lblLane2.TabIndex = 29;
            this.lblLane2.Text = "2nd Lane";
            // 
            // lblLane1
            // 
            this.lblLane1.AutoSize = true;
            this.lblLane1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane1.Location = new System.Drawing.Point(290, 19);
            this.lblLane1.Name = "lblLane1";
            this.lblLane1.Size = new System.Drawing.Size(66, 18);
            this.lblLane1.TabIndex = 28;
            this.lblLane1.Text = "1st Lane";
            // 
            // pcbPump7
            // 
            this.pcbPump7.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump7.Image")));
            this.pcbPump7.Location = new System.Drawing.Point(11, 19);
            this.pcbPump7.Name = "pcbPump7";
            this.pcbPump7.Size = new System.Drawing.Size(80, 85);
            this.pcbPump7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump7.TabIndex = 27;
            this.pcbPump7.TabStop = false;
            // 
            // pcbPump4
            // 
            this.pcbPump4.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump4.Image")));
            this.pcbPump4.Location = new System.Drawing.Point(11, 136);
            this.pcbPump4.Name = "pcbPump4";
            this.pcbPump4.Size = new System.Drawing.Size(80, 85);
            this.pcbPump4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump4.TabIndex = 24;
            this.pcbPump4.TabStop = false;
            // 
            // pcbPump5
            // 
            this.pcbPump5.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump5.Image")));
            this.pcbPump5.Location = new System.Drawing.Point(108, 136);
            this.pcbPump5.Name = "pcbPump5";
            this.pcbPump5.Size = new System.Drawing.Size(80, 85);
            this.pcbPump5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump5.TabIndex = 23;
            this.pcbPump5.TabStop = false;
            // 
            // pcbPump8
            // 
            this.pcbPump8.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump8.Image")));
            this.pcbPump8.Location = new System.Drawing.Point(108, 19);
            this.pcbPump8.Name = "pcbPump8";
            this.pcbPump8.Size = new System.Drawing.Size(80, 85);
            this.pcbPump8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump8.TabIndex = 26;
            this.pcbPump8.TabStop = false;
            // 
            // pcbPump9
            // 
            this.pcbPump9.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump9.Image")));
            this.pcbPump9.Location = new System.Drawing.Point(204, 19);
            this.pcbPump9.Name = "pcbPump9";
            this.pcbPump9.Size = new System.Drawing.Size(80, 85);
            this.pcbPump9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump9.TabIndex = 25;
            this.pcbPump9.TabStop = false;
            // 
            // pcbPump6
            // 
            this.pcbPump6.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump6.Image")));
            this.pcbPump6.Location = new System.Drawing.Point(204, 136);
            this.pcbPump6.Name = "pcbPump6";
            this.pcbPump6.Size = new System.Drawing.Size(80, 85);
            this.pcbPump6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump6.TabIndex = 22;
            this.pcbPump6.TabStop = false;
            // 
            // pcbPump2
            // 
            this.pcbPump2.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump2.Image")));
            this.pcbPump2.Location = new System.Drawing.Point(108, 250);
            this.pcbPump2.Name = "pcbPump2";
            this.pcbPump2.Size = new System.Drawing.Size(80, 85);
            this.pcbPump2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump2.TabIndex = 21;
            this.pcbPump2.TabStop = false;
            // 
            // pcbPump3
            // 
            this.pcbPump3.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump3.Image")));
            this.pcbPump3.Location = new System.Drawing.Point(204, 250);
            this.pcbPump3.Name = "pcbPump3";
            this.pcbPump3.Size = new System.Drawing.Size(80, 85);
            this.pcbPump3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump3.TabIndex = 20;
            this.pcbPump3.TabStop = false;
            // 
            // pcbPump1
            // 
            this.pcbPump1.Image = ((System.Drawing.Image)(resources.GetObject("pcbPump1.Image")));
            this.pcbPump1.Location = new System.Drawing.Point(11, 250);
            this.pcbPump1.Name = "pcbPump1";
            this.pcbPump1.Size = new System.Drawing.Size(80, 85);
            this.pcbPump1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPump1.TabIndex = 19;
            this.pcbPump1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStationQueue);
            this.panel2.Controls.Add(this.lblQueue);
            this.panel2.Controls.Add(this.pcbVehicle2);
            this.panel2.Controls.Add(this.pcbVehicle1);
            this.panel2.Controls.Add(this.pcbVehicle5);
            this.panel2.Controls.Add(this.pcbVehicle3);
            this.panel2.Controls.Add(this.pcbVehicle4);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 91);
            this.panel2.TabIndex = 34;
            // 
            // lblStationQueue
            // 
            this.lblStationQueue.AutoSize = true;
            this.lblStationQueue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationQueue.Location = new System.Drawing.Point(3, 3);
            this.lblStationQueue.Name = "lblStationQueue";
            this.lblStationQueue.Size = new System.Drawing.Size(59, 18);
            this.lblStationQueue.TabIndex = 46;
            this.lblStationQueue.Text = "Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(18, 35);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(52, 19);
            this.lblQueue.TabIndex = 33;
            this.lblQueue.Text = "label1";
            // 
            // pcbVehicle2
            // 
            this.pcbVehicle2.Location = new System.Drawing.Point(327, 3);
            this.pcbVehicle2.Name = "pcbVehicle2";
            this.pcbVehicle2.Size = new System.Drawing.Size(75, 80);
            this.pcbVehicle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVehicle2.TabIndex = 29;
            this.pcbVehicle2.TabStop = false;
            // 
            // pcbVehicle1
            // 
            this.pcbVehicle1.Location = new System.Drawing.Point(408, 3);
            this.pcbVehicle1.Name = "pcbVehicle1";
            this.pcbVehicle1.Size = new System.Drawing.Size(75, 80);
            this.pcbVehicle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVehicle1.TabIndex = 28;
            this.pcbVehicle1.TabStop = false;
            // 
            // pcbVehicle5
            // 
            this.pcbVehicle5.Location = new System.Drawing.Point(84, 3);
            this.pcbVehicle5.Name = "pcbVehicle5";
            this.pcbVehicle5.Size = new System.Drawing.Size(75, 80);
            this.pcbVehicle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVehicle5.TabIndex = 32;
            this.pcbVehicle5.TabStop = false;
            // 
            // pcbVehicle3
            // 
            this.pcbVehicle3.Location = new System.Drawing.Point(246, 3);
            this.pcbVehicle3.Name = "pcbVehicle3";
            this.pcbVehicle3.Size = new System.Drawing.Size(75, 80);
            this.pcbVehicle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVehicle3.TabIndex = 30;
            this.pcbVehicle3.TabStop = false;
            // 
            // pcbVehicle4
            // 
            this.pcbVehicle4.Location = new System.Drawing.Point(165, 3);
            this.pcbVehicle4.Name = "pcbVehicle4";
            this.pcbVehicle4.Size = new System.Drawing.Size(75, 80);
            this.pcbVehicle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVehicle4.TabIndex = 31;
            this.pcbVehicle4.TabStop = false;
            // 
            // tbxTransactionList
            // 
            this.tbxTransactionList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTransactionList.Location = new System.Drawing.Point(12, 132);
            this.tbxTransactionList.Multiline = true;
            this.tbxTransactionList.Name = "tbxTransactionList";
            this.tbxTransactionList.ReadOnly = true;
            this.tbxTransactionList.Size = new System.Drawing.Size(491, 443);
            this.tbxTransactionList.TabIndex = 35;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 581);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 39);
            this.btnStart.TabIndex = 36;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(93, 581);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 39);
            this.btnStop.TabIndex = 37;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(428, 581);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 39);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotalUnleaded
            // 
            this.lblTotalUnleaded.AutoSize = true;
            this.lblTotalUnleaded.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnleaded.Location = new System.Drawing.Point(520, 397);
            this.lblTotalUnleaded.Name = "lblTotalUnleaded";
            this.lblTotalUnleaded.Size = new System.Drawing.Size(86, 20);
            this.lblTotalUnleaded.TabIndex = 39;
            this.lblTotalUnleaded.Text = "Total Litres:";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(520, 491);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(87, 20);
            this.lblTotalProfit.TabIndex = 40;
            this.lblTotalProfit.Text = "Total Profit:";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommission.Location = new System.Drawing.Point(520, 513);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(102, 20);
            this.lblCommission.TabIndex = 41;
            this.lblCommission.Text = "Commission: ";
            // 
            // lblVehiclesServiced
            // 
            this.lblVehiclesServiced.AutoSize = true;
            this.lblVehiclesServiced.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiclesServiced.Location = new System.Drawing.Point(520, 534);
            this.lblVehiclesServiced.Name = "lblVehiclesServiced";
            this.lblVehiclesServiced.Size = new System.Drawing.Size(144, 20);
            this.lblVehiclesServiced.TabIndex = 42;
            this.lblVehiclesServiced.Text = "Vehicles Serviced:";
            // 
            // lblVehiclesUnserviced
            // 
            this.lblVehiclesUnserviced.AutoSize = true;
            this.lblVehiclesUnserviced.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiclesUnserviced.Location = new System.Drawing.Point(520, 555);
            this.lblVehiclesUnserviced.Name = "lblVehiclesUnserviced";
            this.lblVehiclesUnserviced.Size = new System.Drawing.Size(164, 20);
            this.lblVehiclesUnserviced.TabIndex = 43;
            this.lblVehiclesUnserviced.Text = "Vehicles UnServiced:";
            // 
            // tmrAppLoop
            // 
            this.tmrAppLoop.Enabled = true;
            this.tmrAppLoop.Interval = 33;
            this.tmrAppLoop.Tick += new System.EventHandler(this.tmrAppLoop_Tick);
            // 
            // lblTotalLPG
            // 
            this.lblTotalLPG.AutoSize = true;
            this.lblTotalLPG.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLPG.Location = new System.Drawing.Point(520, 418);
            this.lblTotalLPG.Name = "lblTotalLPG";
            this.lblTotalLPG.Size = new System.Drawing.Size(83, 20);
            this.lblTotalLPG.TabIndex = 44;
            this.lblTotalLPG.Text = "Total LPG: ";
            // 
            // lblTotalDiesel
            // 
            this.lblTotalDiesel.AutoSize = true;
            this.lblTotalDiesel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiesel.Location = new System.Drawing.Point(520, 438);
            this.lblTotalDiesel.Name = "lblTotalDiesel";
            this.lblTotalDiesel.Size = new System.Drawing.Size(97, 20);
            this.lblTotalDiesel.TabIndex = 45;
            this.lblTotalDiesel.Text = "Total Diesel: ";
            // 
            // tmrQueueCheck
            // 
            this.tmrQueueCheck.Enabled = true;
            this.tmrQueueCheck.Interval = 500;
            this.tmrQueueCheck.Tick += new System.EventHandler(this.tmrQueueCheck_Tick);
            // 
            // lblTransactionList
            // 
            this.lblTransactionList.AutoSize = true;
            this.lblTransactionList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionList.Location = new System.Drawing.Point(9, 110);
            this.lblTransactionList.Name = "lblTransactionList";
            this.lblTransactionList.Size = new System.Drawing.Size(120, 18);
            this.lblTransactionList.TabIndex = 46;
            this.lblTransactionList.Text = "Transaction List:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(509, 375);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 18);
            this.lblData.TabIndex = 47;
            this.lblData.Text = "Data:";
            // 
            // FormSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(891, 635);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTransactionList);
            this.Controls.Add(this.lblTotalDiesel);
            this.Controls.Add(this.lblTotalLPG);
            this.Controls.Add(this.lblVehiclesUnserviced);
            this.Controls.Add(this.lblVehiclesServiced);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.lblTotalUnleaded);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxTransactionList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPumps);
            this.Controls.Add(this.btnSimBack);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSimulation";
            this.Text = "PetrolManager - Simulation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSimulation_FormClosed);
            this.pnlPumps.ResumeLayout(false);
            this.pnlPumps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPump1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.PictureBox pcbVehicle1;
        public System.Windows.Forms.PictureBox pcbVehicle2;
        public System.Windows.Forms.PictureBox pcbVehicle3;
        public System.Windows.Forms.PictureBox pcbVehicle4;
        public System.Windows.Forms.PictureBox pcbVehicle5;
        public System.Windows.Forms.PictureBox pcbPump1;
        public System.Windows.Forms.Panel pnlPumps;
        public System.Windows.Forms.PictureBox pcbPump7;
        public System.Windows.Forms.PictureBox pcbPump8;
        public System.Windows.Forms.PictureBox pcbPump9;
        public System.Windows.Forms.PictureBox pcbPump4;
        public System.Windows.Forms.PictureBox pcbPump5;
        public System.Windows.Forms.PictureBox pcbPump6;
        public System.Windows.Forms.PictureBox pcbPump2;
        public System.Windows.Forms.PictureBox pcbPump3;
        private System.Windows.Forms.Timer tmrAppLoop;
        public System.Windows.Forms.Label lblTotalUnleaded;
        public System.Windows.Forms.Label lblTotalProfit;
        public System.Windows.Forms.Label lblCommission;
        public System.Windows.Forms.Label lblVehiclesServiced;
        public System.Windows.Forms.Label lblVehiclesUnserviced;
        public System.Windows.Forms.Label lblQueue;
        public System.Windows.Forms.TextBox tbxTransactionList;
        public System.Windows.Forms.Label lblTotalLPG;
        public System.Windows.Forms.Label lblTotalDiesel;
        public System.Windows.Forms.Timer tmrQueueCheck;
        private System.Windows.Forms.Label lblLane3;
        private System.Windows.Forms.Label lblLane2;
        private System.Windows.Forms.Label lblLane1;
        private System.Windows.Forms.Label lblStationQueue;
        private System.Windows.Forms.Label lblTransactionList;
        private System.Windows.Forms.Label lblData;
    }
}
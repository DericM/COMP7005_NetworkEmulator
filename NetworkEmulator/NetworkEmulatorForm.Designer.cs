namespace NetworkEmulator
{
    partial class NetworkEmulatorForm
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
            this.listBoxLogIn = new System.Windows.Forms.ListBox();
            this.listBoxLogOut = new System.Windows.Forms.ListBox();
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.groupBoxLogOut = new System.Windows.Forms.GroupBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxListen = new System.Windows.Forms.GroupBox();
            this.labelListenPort = new System.Windows.Forms.Label();
            this.numericUpDownB2in = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxHostIP = new System.Windows.Forms.TextBox();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelB2out = new System.Windows.Forms.Label();
            this.numericUpDownB2out = new System.Windows.Forms.NumericUpDown();
            this.textBoxB2OutIP = new System.Windows.Forms.TextBox();
            this.labelB2Outip = new System.Windows.Forms.Label();
            this.labelHostIP = new System.Windows.Forms.Label();
            this.groupBoxCharacteristics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownlatency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.labelLatency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownVariance = new System.Windows.Forms.NumericUpDown();
            this.trackBarDrop = new System.Windows.Forms.TrackBar();
            this.groupBoxLogIn.SuspendLayout();
            this.groupBoxLogOut.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxListen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2in)).BeginInit();
            this.groupBoxConnect.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2out)).BeginInit();
            this.groupBoxCharacteristics.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownlatency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLogIn
            // 
            this.listBoxLogIn.FormattingEnabled = true;
            this.listBoxLogIn.Location = new System.Drawing.Point(6, 19);
            this.listBoxLogIn.Name = "listBoxLogIn";
            this.listBoxLogIn.Size = new System.Drawing.Size(298, 420);
            this.listBoxLogIn.TabIndex = 0;
            this.listBoxLogIn.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLogIn_DrawItem);
            // 
            // listBoxLogOut
            // 
            this.listBoxLogOut.FormattingEnabled = true;
            this.listBoxLogOut.Location = new System.Drawing.Point(6, 15);
            this.listBoxLogOut.Name = "listBoxLogOut";
            this.listBoxLogOut.Size = new System.Drawing.Size(289, 420);
            this.listBoxLogOut.TabIndex = 1;
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.Controls.Add(this.listBoxLogIn);
            this.groupBoxLogIn.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(316, 444);
            this.groupBoxLogIn.TabIndex = 2;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Text = "In Log";
            // 
            // groupBoxLogOut
            // 
            this.groupBoxLogOut.Controls.Add(this.listBoxLogOut);
            this.groupBoxLogOut.Location = new System.Drawing.Point(533, 12);
            this.groupBoxLogOut.Name = "groupBoxLogOut";
            this.groupBoxLogOut.Size = new System.Drawing.Size(306, 444);
            this.groupBoxLogOut.TabIndex = 3;
            this.groupBoxLogOut.TabStop = false;
            this.groupBoxLogOut.Text = "Out Log";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.groupBoxListen);
            this.groupBoxControls.Controls.Add(this.buttonStart);
            this.groupBoxControls.Controls.Add(this.textBoxHostIP);
            this.groupBoxControls.Controls.Add(this.groupBoxConnect);
            this.groupBoxControls.Controls.Add(this.labelHostIP);
            this.groupBoxControls.Location = new System.Drawing.Point(334, 12);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(193, 219);
            this.groupBoxControls.TabIndex = 4;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Network Controls";
            // 
            // groupBoxListen
            // 
            this.groupBoxListen.Controls.Add(this.labelListenPort);
            this.groupBoxListen.Controls.Add(this.numericUpDownB2in);
            this.groupBoxListen.Location = new System.Drawing.Point(6, 53);
            this.groupBoxListen.Name = "groupBoxListen";
            this.groupBoxListen.Size = new System.Drawing.Size(181, 44);
            this.groupBoxListen.TabIndex = 7;
            this.groupBoxListen.TabStop = false;
            this.groupBoxListen.Text = "Listen To";
            // 
            // labelListenPort
            // 
            this.labelListenPort.AutoSize = true;
            this.labelListenPort.Location = new System.Drawing.Point(6, 16);
            this.labelListenPort.Name = "labelListenPort";
            this.labelListenPort.Size = new System.Drawing.Size(26, 13);
            this.labelListenPort.TabIndex = 1;
            this.labelListenPort.Text = "Port";
            // 
            // numericUpDownB2in
            // 
            this.numericUpDownB2in.Location = new System.Drawing.Point(69, 14);
            this.numericUpDownB2in.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownB2in.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB2in.Name = "numericUpDownB2in";
            this.numericUpDownB2in.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownB2in.TabIndex = 0;
            this.numericUpDownB2in.Value = new decimal(new int[] {
            7002,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(58, 190);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxHostIP
            // 
            this.textBoxHostIP.Location = new System.Drawing.Point(71, 23);
            this.textBoxHostIP.Name = "textBoxHostIP";
            this.textBoxHostIP.ReadOnly = true;
            this.textBoxHostIP.Size = new System.Drawing.Size(116, 20);
            this.textBoxHostIP.TabIndex = 3;
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxConnect.Location = new System.Drawing.Point(6, 103);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(181, 81);
            this.groupBoxConnect.TabIndex = 2;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect To";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.64497F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.35503F));
            this.tableLayoutPanel2.Controls.Add(this.labelB2Outip, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxB2OutIP, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownB2out, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelB2out, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelB2out
            // 
            this.labelB2out.AutoSize = true;
            this.labelB2out.Location = new System.Drawing.Point(3, 26);
            this.labelB2out.Name = "labelB2out";
            this.labelB2out.Size = new System.Drawing.Size(59, 26);
            this.labelB2out.TabIndex = 3;
            this.labelB2out.Text = "Transmitter Port";
            // 
            // numericUpDownB2out
            // 
            this.numericUpDownB2out.Location = new System.Drawing.Point(69, 29);
            this.numericUpDownB2out.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownB2out.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB2out.Name = "numericUpDownB2out";
            this.numericUpDownB2out.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownB2out.TabIndex = 2;
            this.numericUpDownB2out.Value = new decimal(new int[] {
            7003,
            0,
            0,
            0});
            // 
            // textBoxB2OutIP
            // 
            this.textBoxB2OutIP.Location = new System.Drawing.Point(69, 3);
            this.textBoxB2OutIP.Name = "textBoxB2OutIP";
            this.textBoxB2OutIP.Size = new System.Drawing.Size(97, 20);
            this.textBoxB2OutIP.TabIndex = 5;
            this.textBoxB2OutIP.Text = "localhost";
            // 
            // labelB2Outip
            // 
            this.labelB2Outip.AutoSize = true;
            this.labelB2Outip.Location = new System.Drawing.Point(3, 0);
            this.labelB2Outip.Name = "labelB2Outip";
            this.labelB2Outip.Size = new System.Drawing.Size(59, 26);
            this.labelB2Outip.TabIndex = 4;
            this.labelB2Outip.Text = "Transmitter IP";
            // 
            // labelHostIP
            // 
            this.labelHostIP.AutoSize = true;
            this.labelHostIP.Location = new System.Drawing.Point(14, 25);
            this.labelHostIP.Name = "labelHostIP";
            this.labelHostIP.Size = new System.Drawing.Size(42, 13);
            this.labelHostIP.TabIndex = 1;
            this.labelHostIP.Text = "Host IP";
            // 
            // groupBoxCharacteristics
            // 
            this.groupBoxCharacteristics.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxCharacteristics.Location = new System.Drawing.Point(334, 345);
            this.groupBoxCharacteristics.Name = "groupBoxCharacteristics";
            this.groupBoxCharacteristics.Size = new System.Drawing.Size(193, 111);
            this.groupBoxCharacteristics.TabIndex = 4;
            this.groupBoxCharacteristics.TabStop = false;
            this.groupBoxCharacteristics.Text = "Network Characteristics";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.71429F));
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownlatency, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPercent, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelLatency, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownVariance, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(175, 85);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // numericUpDownlatency
            // 
            this.numericUpDownlatency.Location = new System.Drawing.Point(62, 3);
            this.numericUpDownlatency.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownlatency.Name = "numericUpDownlatency";
            this.numericUpDownlatency.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownlatency.TabIndex = 0;
            this.numericUpDownlatency.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownlatency.ValueChanged += new System.EventHandler(this.numericUpDownlatency_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Droped Rate";
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(62, 59);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.ReadOnly = true;
            this.textBoxPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxPercent.TabIndex = 7;
            // 
            // labelLatency
            // 
            this.labelLatency.AutoSize = true;
            this.labelLatency.Location = new System.Drawing.Point(3, 0);
            this.labelLatency.Name = "labelLatency";
            this.labelLatency.Size = new System.Drawing.Size(45, 13);
            this.labelLatency.TabIndex = 1;
            this.labelLatency.Text = "Latency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Varience";
            // 
            // numericUpDownVariance
            // 
            this.numericUpDownVariance.Location = new System.Drawing.Point(62, 31);
            this.numericUpDownVariance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVariance.Name = "numericUpDownVariance";
            this.numericUpDownVariance.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownVariance.TabIndex = 2;
            this.numericUpDownVariance.ValueChanged += new System.EventHandler(this.numericUpDownVariance_ValueChanged);
            // 
            // trackBarDrop
            // 
            this.trackBarDrop.Location = new System.Drawing.Point(12, 462);
            this.trackBarDrop.Maximum = 100;
            this.trackBarDrop.Name = "trackBarDrop";
            this.trackBarDrop.Size = new System.Drawing.Size(827, 45);
            this.trackBarDrop.TabIndex = 5;
            this.trackBarDrop.Scroll += new System.EventHandler(this.trackBarDrop_Scroll);
            // 
            // NetworkEmulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.groupBoxCharacteristics);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.trackBarDrop);
            this.Controls.Add(this.groupBoxLogOut);
            this.Controls.Add(this.groupBoxLogIn);
            this.Name = "NetworkEmulatorForm";
            this.Text = "NetworkEmulator";
            this.Load += new System.EventHandler(this.NetworkEmulatorForm_Load);
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogOut.ResumeLayout(false);
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            this.groupBoxListen.ResumeLayout(false);
            this.groupBoxListen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2in)).EndInit();
            this.groupBoxConnect.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2out)).EndInit();
            this.groupBoxCharacteristics.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownlatency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogIn;
        private System.Windows.Forms.ListBox listBoxLogOut;
        private System.Windows.Forms.GroupBox groupBoxLogIn;
        private System.Windows.Forms.GroupBox groupBoxLogOut;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Label labelHostIP;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.Label labelB2out;
        private System.Windows.Forms.NumericUpDown numericUpDownB2out;
        private System.Windows.Forms.Label labelListenPort;
        private System.Windows.Forms.NumericUpDown numericUpDownB2in;
        private System.Windows.Forms.TextBox textBoxHostIP;
        private System.Windows.Forms.GroupBox groupBoxCharacteristics;
        private System.Windows.Forms.TextBox textBoxPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownVariance;
        private System.Windows.Forms.Label labelLatency;
        private System.Windows.Forms.NumericUpDown numericUpDownlatency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelB2Outip;
        private System.Windows.Forms.TextBox textBoxB2OutIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxListen;
    }
}


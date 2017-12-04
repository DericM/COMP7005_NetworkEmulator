namespace Sender
{
    partial class TransmitterForm
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
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxBridge1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxHostIP = new System.Windows.Forms.TextBox();
            this.labelHostIP = new System.Windows.Forms.Label();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumPackets = new System.Windows.Forms.Label();
            this.numericUpDownWinSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumPackets = new System.Windows.Forms.NumericUpDown();
            this.labelWinSize = new System.Windows.Forms.Label();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxBridge1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBoxSend.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWinSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPackets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(193, 12);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(392, 426);
            this.groupBoxLog.TabIndex = 0;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(6, 19);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(369, 394);
            this.listBoxLog.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(62, 77);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxBridge1
            // 
            this.groupBoxBridge1.Controls.Add(this.buttonConnect);
            this.groupBoxBridge1.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxBridge1.Location = new System.Drawing.Point(6, 45);
            this.groupBoxBridge1.Name = "groupBoxBridge1";
            this.groupBoxBridge1.Size = new System.Drawing.Size(181, 104);
            this.groupBoxBridge1.TabIndex = 2;
            this.groupBoxBridge1.TabStop = false;
            this.groupBoxBridge1.Text = "Connect To";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(62, 74);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.70732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.29268F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelIP, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 53);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(56, 3);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 5;
            this.textBoxIP.Text = "localhost";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(56, 29);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPort.TabIndex = 0;
            this.numericUpDownPort.Value = new decimal(new int[] {
            7002,
            0,
            0,
            0});
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(3, 26);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(3, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "IP";
            // 
            // textBoxHostIP
            // 
            this.textBoxHostIP.Location = new System.Drawing.Point(72, 19);
            this.textBoxHostIP.Name = "textBoxHostIP";
            this.textBoxHostIP.ReadOnly = true;
            this.textBoxHostIP.Size = new System.Drawing.Size(116, 20);
            this.textBoxHostIP.TabIndex = 5;
            // 
            // labelHostIP
            // 
            this.labelHostIP.AutoSize = true;
            this.labelHostIP.Location = new System.Drawing.Point(15, 21);
            this.labelHostIP.Name = "labelHostIP";
            this.labelHostIP.Size = new System.Drawing.Size(42, 13);
            this.labelHostIP.TabIndex = 4;
            this.labelHostIP.Text = "Host IP";
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSend.Controls.Add(this.buttonSend);
            this.groupBoxSend.Location = new System.Drawing.Point(6, 155);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(181, 104);
            this.groupBoxSend.TabIndex = 6;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "Send";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.95266F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.04734F));
            this.tableLayoutPanel2.Controls.Add(this.labelNumPackets, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownWinSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownNumPackets, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelWinSize, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 52);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // labelNumPackets
            // 
            this.labelNumPackets.AutoSize = true;
            this.labelNumPackets.Location = new System.Drawing.Point(3, 0);
            this.labelNumPackets.Name = "labelNumPackets";
            this.labelNumPackets.Size = new System.Drawing.Size(46, 13);
            this.labelNumPackets.TabIndex = 3;
            this.labelNumPackets.Text = "Packets";
            // 
            // numericUpDownWinSize
            // 
            this.numericUpDownWinSize.Location = new System.Drawing.Point(56, 29);
            this.numericUpDownWinSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWinSize.Name = "numericUpDownWinSize";
            this.numericUpDownWinSize.Size = new System.Drawing.Size(109, 20);
            this.numericUpDownWinSize.TabIndex = 4;
            this.numericUpDownWinSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownNumPackets
            // 
            this.numericUpDownNumPackets.Location = new System.Drawing.Point(56, 3);
            this.numericUpDownNumPackets.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNumPackets.Name = "numericUpDownNumPackets";
            this.numericUpDownNumPackets.Size = new System.Drawing.Size(109, 20);
            this.numericUpDownNumPackets.TabIndex = 2;
            this.numericUpDownNumPackets.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelWinSize
            // 
            this.labelWinSize.AutoSize = true;
            this.labelWinSize.Location = new System.Drawing.Point(3, 26);
            this.labelWinSize.Name = "labelWinSize";
            this.labelWinSize.Size = new System.Drawing.Size(46, 26);
            this.labelWinSize.TabIndex = 5;
            this.labelWinSize.Text = "Window Size";
            // 
            // TransmitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 477);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.textBoxHostIP);
            this.Controls.Add(this.labelHostIP);
            this.Controls.Add(this.groupBoxBridge1);
            this.Controls.Add(this.groupBoxLog);
            this.Name = "TransmitterForm";
            this.Text = "Transmitter";
            this.Load += new System.EventHandler(this.SenderForm_Load);
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxBridge1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBoxSend.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWinSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPackets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBoxBridge1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxHostIP;
        private System.Windows.Forms.Label labelHostIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelNumPackets;
        private System.Windows.Forms.NumericUpDown numericUpDownWinSize;
        private System.Windows.Forms.NumericUpDown numericUpDownNumPackets;
        private System.Windows.Forms.Label labelWinSize;
    }
}


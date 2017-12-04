namespace Receiver
{
    partial class ReceiverForm
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
            this.groupBoxBridge1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxHostIP = new System.Windows.Forms.TextBox();
            this.labelHostIP = new System.Windows.Forms.Label();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxBridge1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(199, 12);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(394, 460);
            this.groupBoxLog.TabIndex = 0;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(18, 28);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(370, 420);
            this.listBoxLog.TabIndex = 0;
            // 
            // groupBoxBridge1
            // 
            this.groupBoxBridge1.Controls.Add(this.buttonConnect);
            this.groupBoxBridge1.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxBridge1.Location = new System.Drawing.Point(12, 49);
            this.groupBoxBridge1.Name = "groupBoxBridge1";
            this.groupBoxBridge1.Size = new System.Drawing.Size(181, 83);
            this.groupBoxBridge1.TabIndex = 3;
            this.groupBoxBridge1.TabStop = false;
            this.groupBoxBridge1.Text = "Listen Port";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(62, 52);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Start";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.70732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.29268F));
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownPort, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(56, 3);
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
            7003,
            0,
            0,
            0});
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(3, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            // 
            // textBoxHostIP
            // 
            this.textBoxHostIP.Location = new System.Drawing.Point(72, 22);
            this.textBoxHostIP.Name = "textBoxHostIP";
            this.textBoxHostIP.ReadOnly = true;
            this.textBoxHostIP.Size = new System.Drawing.Size(116, 20);
            this.textBoxHostIP.TabIndex = 7;
            // 
            // labelHostIP
            // 
            this.labelHostIP.AutoSize = true;
            this.labelHostIP.Location = new System.Drawing.Point(15, 24);
            this.labelHostIP.Name = "labelHostIP";
            this.labelHostIP.Size = new System.Drawing.Size(42, 13);
            this.labelHostIP.TabIndex = 6;
            this.labelHostIP.Text = "Host IP";
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 484);
            this.Controls.Add(this.textBoxHostIP);
            this.Controls.Add(this.labelHostIP);
            this.Controls.Add(this.groupBoxBridge1);
            this.Controls.Add(this.groupBoxLog);
            this.Name = "ReceiverForm";
            this.Text = "Receiver";
            this.Load += new System.EventHandler(this.ReceiverForm_Load);
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxBridge1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.GroupBox groupBoxBridge1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxHostIP;
        private System.Windows.Forms.Label labelHostIP;
    }
}


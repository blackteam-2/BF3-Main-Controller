namespace BF3_Main_Controller
{
    partial class MainClass
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
            this.btnComConnect = new System.Windows.Forms.Button();
            this.grBCom = new System.Windows.Forms.GroupBox();
            this.ChBxRTS = new System.Windows.Forms.CheckBox();
            this.ChBxDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBPairity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBBaud = new System.Windows.Forms.ComboBox();
            this.CBCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grBCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComConnect
            // 
            this.btnComConnect.BackColor = System.Drawing.Color.LightCoral;
            this.btnComConnect.Location = new System.Drawing.Point(12, 217);
            this.btnComConnect.Name = "btnComConnect";
            this.btnComConnect.Size = new System.Drawing.Size(172, 23);
            this.btnComConnect.TabIndex = 40;
            this.btnComConnect.Text = "Connect";
            this.btnComConnect.UseVisualStyleBackColor = false;
            this.btnComConnect.Click += new System.EventHandler(this.btnComConnect_Click);
            // 
            // grBCom
            // 
            this.grBCom.Controls.Add(this.ChBxRTS);
            this.grBCom.Controls.Add(this.ChBxDTR);
            this.grBCom.Controls.Add(this.label5);
            this.grBCom.Controls.Add(this.CBStopBits);
            this.grBCom.Controls.Add(this.label4);
            this.grBCom.Controls.Add(this.CBDataBits);
            this.grBCom.Controls.Add(this.label3);
            this.grBCom.Controls.Add(this.CBPairity);
            this.grBCom.Controls.Add(this.label2);
            this.grBCom.Controls.Add(this.CBBaud);
            this.grBCom.Controls.Add(this.CBCom);
            this.grBCom.Controls.Add(this.label1);
            this.grBCom.Location = new System.Drawing.Point(12, 12);
            this.grBCom.Name = "grBCom";
            this.grBCom.Size = new System.Drawing.Size(172, 199);
            this.grBCom.TabIndex = 39;
            this.grBCom.TabStop = false;
            this.grBCom.Text = "ComPort";
            // 
            // ChBxRTS
            // 
            this.ChBxRTS.AutoSize = true;
            this.ChBxRTS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBxRTS.Checked = true;
            this.ChBxRTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBxRTS.Location = new System.Drawing.Point(6, 178);
            this.ChBxRTS.Name = "ChBxRTS";
            this.ChBxRTS.Size = new System.Drawing.Size(84, 17);
            this.ChBxRTS.TabIndex = 43;
            this.ChBxRTS.Text = "RTS Enable";
            this.ChBxRTS.UseVisualStyleBackColor = true;
            // 
            // ChBxDTR
            // 
            this.ChBxDTR.AutoSize = true;
            this.ChBxDTR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBxDTR.Checked = true;
            this.ChBxDTR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBxDTR.Location = new System.Drawing.Point(6, 155);
            this.ChBxDTR.Name = "ChBxDTR";
            this.ChBxDTR.Size = new System.Drawing.Size(85, 17);
            this.ChBxDTR.TabIndex = 42;
            this.ChBxDTR.Text = "DTR Enable";
            this.ChBxDTR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Stop Bits";
            // 
            // CBStopBits
            // 
            this.CBStopBits.FormattingEnabled = true;
            this.CBStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.CBStopBits.Location = new System.Drawing.Point(63, 101);
            this.CBStopBits.Name = "CBStopBits";
            this.CBStopBits.Size = new System.Drawing.Size(90, 21);
            this.CBStopBits.TabIndex = 40;
            this.CBStopBits.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Data Bits";
            // 
            // CBDataBits
            // 
            this.CBDataBits.FormattingEnabled = true;
            this.CBDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CBDataBits.Location = new System.Drawing.Point(63, 74);
            this.CBDataBits.Name = "CBDataBits";
            this.CBDataBits.Size = new System.Drawing.Size(90, 21);
            this.CBDataBits.TabIndex = 38;
            this.CBDataBits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Pairity";
            // 
            // CBPairity
            // 
            this.CBPairity.FormattingEnabled = true;
            this.CBPairity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBPairity.Location = new System.Drawing.Point(63, 128);
            this.CBPairity.Name = "CBPairity";
            this.CBPairity.Size = new System.Drawing.Size(90, 21);
            this.CBPairity.TabIndex = 36;
            this.CBPairity.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Baud Rate";
            // 
            // CBBaud
            // 
            this.CBBaud.FormattingEnabled = true;
            this.CBBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.CBBaud.Location = new System.Drawing.Point(63, 47);
            this.CBBaud.Name = "CBBaud";
            this.CBBaud.Size = new System.Drawing.Size(90, 21);
            this.CBBaud.TabIndex = 34;
            this.CBBaud.Text = "9600";
            // 
            // CBCom
            // 
            this.CBCom.FormattingEnabled = true;
            this.CBCom.Location = new System.Drawing.Point(63, 19);
            this.CBCom.Name = "CBCom";
            this.CBCom.Size = new System.Drawing.Size(90, 21);
            this.CBCom.TabIndex = 8;
            this.CBCom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CBCom_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "COM Port";
            // 
            // MainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComConnect);
            this.Controls.Add(this.grBCom);
            this.Name = "MainClass";
            this.Text = "MainClass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainClass_FormClosing);
            this.Load += new System.EventHandler(this.MainClass_Load);
            this.grBCom.ResumeLayout(false);
            this.grBCom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComConnect;
        private System.Windows.Forms.GroupBox grBCom;
        private System.Windows.Forms.CheckBox ChBxRTS;
        private System.Windows.Forms.CheckBox ChBxDTR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBPairity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBBaud;
        private System.Windows.Forms.ComboBox CBCom;
        private System.Windows.Forms.Label label1;
    }
}
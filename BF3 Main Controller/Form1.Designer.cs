namespace BF3_Main_Controller
{
    partial class frmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            this.btnComConnect = new System.Windows.Forms.Button();
            this.grBGameMode = new System.Windows.Forms.GroupBox();
            this.rbtnModeDeathmatch = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnModeCTF = new System.Windows.Forms.RadioButton();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvRFID = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAddy = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inUseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rFIDTagListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addyListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grBCom.SuspendLayout();
            this.grBGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFIDTagListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addyListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 793);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1762, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            this.grBCom.Location = new System.Drawing.Point(12, 27);
            this.grBCom.Name = "grBCom";
            this.grBCom.Size = new System.Drawing.Size(172, 199);
            this.grBCom.TabIndex = 37;
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
            // btnComConnect
            // 
            this.btnComConnect.BackColor = System.Drawing.Color.LightCoral;
            this.btnComConnect.Location = new System.Drawing.Point(12, 232);
            this.btnComConnect.Name = "btnComConnect";
            this.btnComConnect.Size = new System.Drawing.Size(172, 23);
            this.btnComConnect.TabIndex = 38;
            this.btnComConnect.Text = "Connect";
            this.btnComConnect.UseVisualStyleBackColor = false;
            this.btnComConnect.Click += new System.EventHandler(this.btnComConnect_Click);
            // 
            // grBGameMode
            // 
            this.grBGameMode.Controls.Add(this.rbtnModeDeathmatch);
            this.grBGameMode.Controls.Add(this.rbtnModeCTF);
            this.grBGameMode.Location = new System.Drawing.Point(12, 278);
            this.grBGameMode.Name = "grBGameMode";
            this.grBGameMode.Size = new System.Drawing.Size(172, 250);
            this.grBGameMode.TabIndex = 39;
            this.grBGameMode.TabStop = false;
            this.grBGameMode.Text = "Game Mode";
            // 
            // rbtnModeDeathmatch
            // 
            this.rbtnModeDeathmatch.AutoSize = true;
            this.rbtnModeDeathmatch.Location = new System.Drawing.Point(6, 51);
            this.rbtnModeDeathmatch.Name = "rbtnModeDeathmatch";
            this.rbtnModeDeathmatch.Size = new System.Drawing.Size(84, 17);
            this.rbtnModeDeathmatch.TabIndex = 1;
            this.rbtnModeDeathmatch.TabStop = true;
            this.rbtnModeDeathmatch.Text = "DeathMatch";
            this.rbtnModeDeathmatch.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnModeCTF
            // 
            this.rbtnModeCTF.AutoSize = true;
            this.rbtnModeCTF.Location = new System.Drawing.Point(7, 28);
            this.rbtnModeCTF.Name = "rbtnModeCTF";
            this.rbtnModeCTF.Size = new System.Drawing.Size(103, 17);
            this.rbtnModeCTF.TabIndex = 0;
            this.rbtnModeCTF.TabStop = true;
            this.rbtnModeCTF.Text = "Capture the Flag";
            this.rbtnModeCTF.UseVisualStyleBackColor = true;
            // 
            // rtbDebug
            // 
            this.rtbDebug.Location = new System.Drawing.Point(1356, 27);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(394, 568);
            this.rtbDebug.TabIndex = 40;
            this.rtbDebug.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvRFID
            // 
            this.dgvRFID.AutoGenerateColumns = false;
            this.dgvRFID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRFID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tagNumDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.tagLabelDataGridViewTextBoxColumn,
            this.typeUseDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.inUseDataGridViewCheckBoxColumn});
            this.dgvRFID.DataSource = this.rFIDTagListBindingSource;
            this.dgvRFID.Location = new System.Drawing.Point(908, 49);
            this.dgvRFID.Name = "dgvRFID";
            this.dgvRFID.Size = new System.Drawing.Size(442, 263);
            this.dgvRFID.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(908, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "RFID Tag List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(908, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Addy Table";
            // 
            // dgvAddy
            // 
            this.dgvAddy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddy.Location = new System.Drawing.Point(908, 332);
            this.dgvAddy.Name = "dgvAddy";
            this.dgvAddy.Size = new System.Drawing.Size(442, 263);
            this.dgvAddy.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 745);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 763);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "label9";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tagNumDataGridViewTextBoxColumn
            // 
            this.tagNumDataGridViewTextBoxColumn.DataPropertyName = "TagNum";
            this.tagNumDataGridViewTextBoxColumn.HeaderText = "TagNum";
            this.tagNumDataGridViewTextBoxColumn.Name = "tagNumDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // tagLabelDataGridViewTextBoxColumn
            // 
            this.tagLabelDataGridViewTextBoxColumn.DataPropertyName = "TagLabel";
            this.tagLabelDataGridViewTextBoxColumn.HeaderText = "TagLabel";
            this.tagLabelDataGridViewTextBoxColumn.Name = "tagLabelDataGridViewTextBoxColumn";
            // 
            // typeUseDataGridViewTextBoxColumn
            // 
            this.typeUseDataGridViewTextBoxColumn.DataPropertyName = "TypeUse";
            this.typeUseDataGridViewTextBoxColumn.HeaderText = "TypeUse";
            this.typeUseDataGridViewTextBoxColumn.Name = "typeUseDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // inUseDataGridViewCheckBoxColumn
            // 
            this.inUseDataGridViewCheckBoxColumn.DataPropertyName = "InUse";
            this.inUseDataGridViewCheckBoxColumn.HeaderText = "InUse";
            this.inUseDataGridViewCheckBoxColumn.Name = "inUseDataGridViewCheckBoxColumn";
            // 
            // rFIDTagListBindingSource
            // 
            this.rFIDTagListBindingSource.DataSource = typeof(BF3_Main_Controller.RFIDTagList);
            // 
            // addyListBindingSource
            // 
            this.addyListBindingSource.DataSource = typeof(BF3_Main_Controller.AddyList);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(307, 534);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 815);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAddy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRFID);
            this.Controls.Add(this.rtbDebug);
            this.Controls.Add(this.grBGameMode);
            this.Controls.Add(this.btnComConnect);
            this.Controls.Add(this.grBCom);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF3 Main Controller";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBCom.ResumeLayout(false);
            this.grBCom.PerformLayout();
            this.grBGameMode.ResumeLayout(false);
            this.grBGameMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFIDTagListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addyListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
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
        private System.Windows.Forms.Button btnComConnect;
        private System.Windows.Forms.GroupBox grBGameMode;
        private System.Windows.Forms.RadioButton rbtnModeDeathmatch;
        private System.Windows.Forms.RadioButton rbtnModeCTF;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeUseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inUseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource rFIDTagListBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAddy;
        private System.Windows.Forms.BindingSource addyListBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


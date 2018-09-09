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
            this.grBGameMode = new System.Windows.Forms.GroupBox();
            this.rbtnModeDeathmatch = new System.Windows.Forms.RadioButton();
            this.rbtnModeCTF = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvRFID = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inUseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rFIDTagListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAddy = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.addyListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grBGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFIDTagListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddy)).BeginInit();
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
            // grBGameMode
            // 
            this.grBGameMode.Controls.Add(this.rbtnModeDeathmatch);
            this.grBGameMode.Controls.Add(this.rbtnModeCTF);
            this.grBGameMode.Location = new System.Drawing.Point(12, 27);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbDebug
            // 
            this.rtbDebug.Location = new System.Drawing.Point(1359, 27);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(393, 568);
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
            this.dgvRFID.Location = new System.Drawing.Point(606, 49);
            this.dgvRFID.Name = "dgvRFID";
            this.dgvRFID.Size = new System.Drawing.Size(744, 263);
            this.dgvRFID.TabIndex = 42;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "RFID Tag List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Addy Table";
            // 
            // dgvAddy
            // 
            this.dgvAddy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddy.Location = new System.Drawing.Point(606, 332);
            this.dgvAddy.Name = "dgvAddy";
            this.dgvAddy.Size = new System.Drawing.Size(744, 263);
            this.dgvAddy.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 312);
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
            this.button3.Location = new System.Drawing.Point(93, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addyListBindingSource
            // 
            this.addyListBindingSource.DataSource = typeof(BF3_Main_Controller.AddyList);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 51;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(109, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 52;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(350, 283);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 53;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 815);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF3 Main Controller";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBGameMode.ResumeLayout(false);
            this.grBGameMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFIDTagListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addyListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}


namespace POSRestuarant.FormUI.FRMRegisterDatabase
{
    partial class FRMRegisteration
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.CboChooseExistingDB = new System.Windows.Forms.ComboBox();
            this.ChkExistingDB = new System.Windows.Forms.RadioButton();
            this.ChkCreateNewDB = new System.Windows.Forms.RadioButton();
            this.TxtCreateNewDB = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.TxtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(359, 528);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(151, 45);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(123, 528);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(151, 45);
            this.BtnExit.TabIndex = 18;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CboChooseExistingDB
            // 
            this.CboChooseExistingDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CboChooseExistingDB.Enabled = false;
            this.CboChooseExistingDB.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CboChooseExistingDB.FormattingEnabled = true;
            this.CboChooseExistingDB.Location = new System.Drawing.Point(297, 477);
            this.CboChooseExistingDB.Margin = new System.Windows.Forms.Padding(20);
            this.CboChooseExistingDB.Name = "CboChooseExistingDB";
            this.CboChooseExistingDB.Size = new System.Drawing.Size(213, 24);
            this.CboChooseExistingDB.TabIndex = 16;
            // 
            // ChkExistingDB
            // 
            this.ChkExistingDB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChkExistingDB.AutoSize = true;
            this.ChkExistingDB.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ChkExistingDB.Location = new System.Drawing.Point(53, 479);
            this.ChkExistingDB.Name = "ChkExistingDB";
            this.ChkExistingDB.Size = new System.Drawing.Size(193, 21);
            this.ChkExistingDB.TabIndex = 14;
            this.ChkExistingDB.TabStop = true;
            this.ChkExistingDB.Text = "Choose Existing Database :";
            this.ChkExistingDB.UseVisualStyleBackColor = true;
            this.ChkExistingDB.CheckedChanged += new System.EventHandler(this.ChkExistingDB_CheckedChanged);
            // 
            // ChkCreateNewDB
            // 
            this.ChkCreateNewDB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChkCreateNewDB.AutoSize = true;
            this.ChkCreateNewDB.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ChkCreateNewDB.Location = new System.Drawing.Point(53, 409);
            this.ChkCreateNewDB.Name = "ChkCreateNewDB";
            this.ChkCreateNewDB.Size = new System.Drawing.Size(166, 21);
            this.ChkCreateNewDB.TabIndex = 15;
            this.ChkCreateNewDB.TabStop = true;
            this.ChkCreateNewDB.Text = "Create New Database :";
            this.ChkCreateNewDB.UseVisualStyleBackColor = true;
            this.ChkCreateNewDB.CheckedChanged += new System.EventHandler(this.ChkCreateNewDB_CheckedChanged);
            // 
            // TxtCreateNewDB
            // 
            this.TxtCreateNewDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCreateNewDB.Enabled = false;
            this.TxtCreateNewDB.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtCreateNewDB.Location = new System.Drawing.Point(297, 408);
            this.TxtCreateNewDB.Margin = new System.Windows.Forms.Padding(20);
            this.TxtCreateNewDB.Name = "TxtCreateNewDB";
            this.TxtCreateNewDB.Size = new System.Drawing.Size(213, 24);
            this.TxtCreateNewDB.TabIndex = 10;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtPassword.Location = new System.Drawing.Point(297, 338);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(20);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(213, 24);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPassword.Location = new System.Drawing.Point(53, 341);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password :";
            // 
            // TxtUserID
            // 
            this.TxtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtUserID.Location = new System.Drawing.Point(297, 268);
            this.TxtUserID.Margin = new System.Windows.Forms.Padding(20);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(213, 24);
            this.TxtUserID.TabIndex = 12;
            this.TxtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserID_KeyPress);
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUserID.Location = new System.Drawing.Point(53, 271);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(62, 17);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "User ID :";
            // 
            // TxtServerName
            // 
            this.TxtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtServerName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtServerName.Location = new System.Drawing.Point(297, 198);
            this.TxtServerName.Margin = new System.Windows.Forms.Padding(20);
            this.TxtServerName.Name = "TxtServerName";
            this.TxtServerName.Size = new System.Drawing.Size(213, 24);
            this.TxtServerName.TabIndex = 13;
            this.TxtServerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtServerName_KeyPress);
            // 
            // lblServerName
            // 
            this.lblServerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblServerName.Location = new System.Drawing.Point(53, 201);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(121, 17);
            this.lblServerName.TabIndex = 9;
            this.lblServerName.Text = "Server Name / IP :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Database Registeration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 711);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel2.Controls.Add(this.TxtServerName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtUserID, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtPassword, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtCreateNewDB, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.CboChooseExistingDB, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.ChkExistingDB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ChkCreateNewDB, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblServerName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnExit, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblUserID, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(541, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 703);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(536, 709);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // FRMRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "FRMRegisteration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMRegisteration";
            this.Load += new System.EventHandler(this.FRMRegisteration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ComboBox CboChooseExistingDB;
        private System.Windows.Forms.RadioButton ChkExistingDB;
        private System.Windows.Forms.RadioButton ChkCreateNewDB;
        private System.Windows.Forms.TextBox TxtCreateNewDB;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox TxtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
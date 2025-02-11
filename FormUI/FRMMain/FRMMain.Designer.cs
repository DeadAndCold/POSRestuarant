namespace POSRestuarant.FormUI.FRMMain
{
    partial class FRMMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMain));
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.lblChildFormName = new System.Windows.Forms.Label();
            this.tlpExit = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNavigation = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.BtnTables = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUsername = new System.Windows.Forms.Button();
            this.tlpFormContainer = new System.Windows.Forms.TableLayoutPanel();
            this.navigationBar = new System.Windows.Forms.Timer(this.components);
            this.tlpForm.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.tlpExit.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.BackColor = System.Drawing.Color.White;
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpForm.Controls.Add(this.panelUpper, 1, 0);
            this.tlpForm.Controls.Add(this.tlpExit, 2, 0);
            this.tlpForm.Controls.Add(this.tlpNavigation, 0, 0);
            this.tlpForm.Controls.Add(this.tlpFormContainer, 1, 1);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 2;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tlpForm.Size = new System.Drawing.Size(1455, 587);
            this.tlpForm.TabIndex = 0;
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.lblChildFormName);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpper.Location = new System.Drawing.Point(218, 0);
            this.panelUpper.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1164, 23);
            this.panelUpper.TabIndex = 0;
            // 
            // lblChildFormName
            // 
            this.lblChildFormName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChildFormName.AutoSize = true;
            this.lblChildFormName.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblChildFormName.Location = new System.Drawing.Point(13, 4);
            this.lblChildFormName.Name = "lblChildFormName";
            this.lblChildFormName.Size = new System.Drawing.Size(311, 21);
            this.lblChildFormName.TabIndex = 0;
            this.lblChildFormName.Text = "Nice! We have a lot of orders here!";
            // 
            // tlpExit
            // 
            this.tlpExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpExit.ColumnCount = 2;
            this.tlpExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExit.Controls.Add(this.BtnExit, 1, 0);
            this.tlpExit.Controls.Add(this.BtnMinimize, 0, 0);
            this.tlpExit.Location = new System.Drawing.Point(1382, 0);
            this.tlpExit.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExit.Name = "tlpExit";
            this.tlpExit.RowCount = 1;
            this.tlpExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExit.Size = new System.Drawing.Size(73, 23);
            this.tlpExit.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(36, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(37, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.White;
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnMinimize.Location = new System.Drawing.Point(0, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(36, 23);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.BackColor = System.Drawing.Color.DarkBlue;
            this.tlpNavigation.ColumnCount = 1;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Controls.Add(this.BtnNavigation, 0, 0);
            this.tlpNavigation.Controls.Add(this.BtnDashboard, 0, 1);
            this.tlpNavigation.Controls.Add(this.BtnMenu, 0, 2);
            this.tlpNavigation.Controls.Add(this.BtnOrders, 0, 3);
            this.tlpNavigation.Controls.Add(this.BtnTables, 0, 4);
            this.tlpNavigation.Controls.Add(this.BtnLogOut, 0, 8);
            this.tlpNavigation.Controls.Add(this.BtnUsername, 0, 7);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavigation.Location = new System.Drawing.Point(0, 0);
            this.tlpNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 10;
            this.tlpForm.SetRowSpan(this.tlpNavigation, 2);
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpNavigation.Size = new System.Drawing.Size(218, 587);
            this.tlpNavigation.TabIndex = 2;
            // 
            // BtnNavigation
            // 
            this.BtnNavigation.BackColor = System.Drawing.Color.Transparent;
            this.BtnNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNavigation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNavigation.FlatAppearance.BorderSize = 0;
            this.BtnNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNavigation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.BtnNavigation.ForeColor = System.Drawing.Color.White;
            this.BtnNavigation.Image = ((System.Drawing.Image)(resources.GetObject("BtnNavigation.Image")));
            this.BtnNavigation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNavigation.Location = new System.Drawing.Point(0, 0);
            this.BtnNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNavigation.Name = "BtnNavigation";
            this.BtnNavigation.Size = new System.Drawing.Size(218, 55);
            this.BtnNavigation.TabIndex = 1;
            this.BtnNavigation.Text = "Restuarant";
            this.BtnNavigation.UseVisualStyleBackColor = false;
            this.BtnNavigation.Click += new System.EventHandler(this.BtnNavigation_Click);
            this.BtnNavigation.MouseEnter += new System.EventHandler(this.BtnNavigation_MouseEnter);
            this.BtnNavigation.MouseLeave += new System.EventHandler(this.BtnNavigation_MouseLeave);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 55);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(218, 55);
            this.BtnDashboard.TabIndex = 2;
            this.BtnDashboard.Text = "DashBoard";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.MouseEnter += new System.EventHandler(this.BtnDashboard_MouseEnter);
            this.BtnDashboard.MouseLeave += new System.EventHandler(this.BtnDashboard_MouseLeave);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 110);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(218, 55);
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.BtnMenu.MouseEnter += new System.EventHandler(this.BtnMenu_MouseEnter);
            this.BtnMenu.MouseLeave += new System.EventHandler(this.BtnMenu_MouseLeave);
            // 
            // BtnOrders
            // 
            this.BtnOrders.BackColor = System.Drawing.Color.Transparent;
            this.BtnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnOrders.FlatAppearance.BorderSize = 0;
            this.BtnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrders.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnOrders.ForeColor = System.Drawing.Color.White;
            this.BtnOrders.Image = ((System.Drawing.Image)(resources.GetObject("BtnOrders.Image")));
            this.BtnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrders.Location = new System.Drawing.Point(0, 165);
            this.BtnOrders.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(218, 55);
            this.BtnOrders.TabIndex = 4;
            this.BtnOrders.Text = "Orders";
            this.BtnOrders.UseVisualStyleBackColor = false;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            this.BtnOrders.MouseEnter += new System.EventHandler(this.BtnOrders_MouseEnter);
            this.BtnOrders.MouseLeave += new System.EventHandler(this.BtnOrders_MouseLeave);
            // 
            // BtnTables
            // 
            this.BtnTables.BackColor = System.Drawing.Color.Transparent;
            this.BtnTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTables.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnTables.FlatAppearance.BorderSize = 0;
            this.BtnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTables.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnTables.ForeColor = System.Drawing.Color.White;
            this.BtnTables.Image = ((System.Drawing.Image)(resources.GetObject("BtnTables.Image")));
            this.BtnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTables.Location = new System.Drawing.Point(0, 220);
            this.BtnTables.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTables.Name = "BtnTables";
            this.BtnTables.Size = new System.Drawing.Size(218, 55);
            this.BtnTables.TabIndex = 4;
            this.BtnTables.Text = "Tables";
            this.BtnTables.UseVisualStyleBackColor = false;
            this.BtnTables.Click += new System.EventHandler(this.BtnTables_Click);
            this.BtnTables.MouseEnter += new System.EventHandler(this.BtnTables_MouseEnter);
            this.BtnTables.MouseLeave += new System.EventHandler(this.BtnTables_MouseLeave);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogOut.Image")));
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 468);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(218, 55);
            this.BtnLogOut.TabIndex = 4;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.MouseEnter += new System.EventHandler(this.BtnLogOut_MouseEnter);
            this.BtnLogOut.MouseLeave += new System.EventHandler(this.BtnLogOut_MouseLeave);
            // 
            // BtnUsername
            // 
            this.BtnUsername.BackColor = System.Drawing.Color.Transparent;
            this.BtnUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUsername.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUsername.FlatAppearance.BorderSize = 0;
            this.BtnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsername.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnUsername.ForeColor = System.Drawing.Color.White;
            this.BtnUsername.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsername.Image")));
            this.BtnUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsername.Location = new System.Drawing.Point(0, 413);
            this.BtnUsername.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUsername.Name = "BtnUsername";
            this.BtnUsername.Size = new System.Drawing.Size(218, 55);
            this.BtnUsername.TabIndex = 4;
            this.BtnUsername.Text = "Username";
            this.BtnUsername.UseVisualStyleBackColor = false;
            this.BtnUsername.MouseEnter += new System.EventHandler(this.BtnUsername_MouseEnter);
            this.BtnUsername.MouseLeave += new System.EventHandler(this.BtnUsername_MouseLeave);
            // 
            // tlpFormContainer
            // 
            this.tlpFormContainer.ColumnCount = 1;
            this.tlpForm.SetColumnSpan(this.tlpFormContainer, 2);
            this.tlpFormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormContainer.Location = new System.Drawing.Point(218, 23);
            this.tlpFormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFormContainer.Name = "tlpFormContainer";
            this.tlpFormContainer.RowCount = 1;
            this.tlpFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormContainer.Size = new System.Drawing.Size(1237, 564);
            this.tlpFormContainer.TabIndex = 4;
            // 
            // navigationBar
            // 
            this.navigationBar.Interval = 10;
            this.navigationBar.Tick += new System.EventHandler(this.navigationBar_Tick);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1455, 587);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMDashBoard_FormClosing);
            this.Load += new System.EventHandler(this.FRMDashBoard_Load);
            this.tlpForm.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.tlpExit.ResumeLayout(false);
            this.tlpNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Button BtnNavigation;
        private System.Windows.Forms.Timer navigationBar;
        private System.Windows.Forms.TableLayoutPanel tlpExit;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.Button BtnTables;
        private System.Windows.Forms.Button BtnUsername;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.TableLayoutPanel tlpFormContainer;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Label lblChildFormName;
    }
}
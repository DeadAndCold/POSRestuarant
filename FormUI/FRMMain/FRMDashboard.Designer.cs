namespace POSRestuarant.FormUI.FRMMain
{
    partial class FRMDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customePanelOrder1 = new POSRestuarant.FormUI.Custome_Controls.Custome_Panel.CustomePanelOrder();
            this.customePanelOrder2 = new POSRestuarant.FormUI.Custome_Controls.Custome_Panel.CustomePanelOrder();
            this.customePanelOrder3 = new POSRestuarant.FormUI.Custome_Controls.Custome_Panel.CustomePanelOrder();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnPending = new System.Windows.Forms.Button();
            this.BtnComplete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1455, 693);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.Controls.Add(this.customePanelOrder1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.customePanelOrder2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.customePanelOrder3, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1014, 169);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // customePanelOrder1
            // 
            this.customePanelOrder1.BackColor = System.Drawing.Color.DarkBlue;
            this.customePanelOrder1.Desc = "Description";
            this.customePanelOrder1.DescAutoSize = false;
            this.customePanelOrder1.DescFont = new System.Drawing.Font("Arial", 10F);
            this.customePanelOrder1.DescForeColor = System.Drawing.Color.Black;
            this.customePanelOrder1.DescLocation = new System.Drawing.Point(22, 148);
            this.customePanelOrder1.DescSize = new System.Drawing.Size(273, 59);
            this.customePanelOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customePanelOrder1.Image = null;
            this.customePanelOrder1.Location = new System.Drawing.Point(22, 2);
            this.customePanelOrder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customePanelOrder1.Name = "customePanelOrder1";
            this.customePanelOrder1.Qty = "0";
            this.customePanelOrder1.QtyAutoSize = false;
            this.customePanelOrder1.QtyFont = new System.Drawing.Font("Arial", 12F);
            this.customePanelOrder1.QtyForeColor = System.Drawing.Color.Black;
            this.customePanelOrder1.QtyLocation = new System.Drawing.Point(22, 84);
            this.customePanelOrder1.QtySize = new System.Drawing.Size(87, 78);
            this.customePanelOrder1.Size = new System.Drawing.Size(249, 165);
            this.customePanelOrder1.TabIndex = 0;
            this.customePanelOrder1.Title = "Title";
            this.customePanelOrder1.TitleAutoSize = false;
            this.customePanelOrder1.TitleFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customePanelOrder1.TitleForeColor = System.Drawing.Color.Black;
            this.customePanelOrder1.TitleLocation = new System.Drawing.Point(22, 21);
            this.customePanelOrder1.TitleSize = new System.Drawing.Size(193, 29);
            // 
            // customePanelOrder2
            // 
            this.customePanelOrder2.BackColor = System.Drawing.Color.DarkBlue;
            this.customePanelOrder2.Desc = "Description";
            this.customePanelOrder2.DescAutoSize = false;
            this.customePanelOrder2.DescFont = new System.Drawing.Font("Arial", 10F);
            this.customePanelOrder2.DescForeColor = System.Drawing.Color.Black;
            this.customePanelOrder2.DescLocation = new System.Drawing.Point(22, 148);
            this.customePanelOrder2.DescSize = new System.Drawing.Size(273, 59);
            this.customePanelOrder2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customePanelOrder2.Image = null;
            this.customePanelOrder2.Location = new System.Drawing.Point(295, 2);
            this.customePanelOrder2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customePanelOrder2.Name = "customePanelOrder2";
            this.customePanelOrder2.Qty = "0";
            this.customePanelOrder2.QtyAutoSize = false;
            this.customePanelOrder2.QtyFont = new System.Drawing.Font("Arial", 12F);
            this.customePanelOrder2.QtyForeColor = System.Drawing.Color.Black;
            this.customePanelOrder2.QtyLocation = new System.Drawing.Point(22, 84);
            this.customePanelOrder2.QtySize = new System.Drawing.Size(87, 78);
            this.customePanelOrder2.Size = new System.Drawing.Size(249, 165);
            this.customePanelOrder2.TabIndex = 1;
            this.customePanelOrder2.Title = "Title";
            this.customePanelOrder2.TitleAutoSize = false;
            this.customePanelOrder2.TitleFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customePanelOrder2.TitleForeColor = System.Drawing.Color.Black;
            this.customePanelOrder2.TitleLocation = new System.Drawing.Point(22, 21);
            this.customePanelOrder2.TitleSize = new System.Drawing.Size(193, 29);
            // 
            // customePanelOrder3
            // 
            this.customePanelOrder3.BackColor = System.Drawing.Color.DarkBlue;
            this.customePanelOrder3.Desc = "Description";
            this.customePanelOrder3.DescAutoSize = false;
            this.customePanelOrder3.DescFont = new System.Drawing.Font("Arial", 10F);
            this.customePanelOrder3.DescForeColor = System.Drawing.Color.Black;
            this.customePanelOrder3.DescLocation = new System.Drawing.Point(22, 148);
            this.customePanelOrder3.DescSize = new System.Drawing.Size(273, 59);
            this.customePanelOrder3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customePanelOrder3.Image = null;
            this.customePanelOrder3.Location = new System.Drawing.Point(568, 2);
            this.customePanelOrder3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customePanelOrder3.Name = "customePanelOrder3";
            this.customePanelOrder3.Qty = "0";
            this.customePanelOrder3.QtyAutoSize = false;
            this.customePanelOrder3.QtyFont = new System.Drawing.Font("Arial", 12F);
            this.customePanelOrder3.QtyForeColor = System.Drawing.Color.Black;
            this.customePanelOrder3.QtyLocation = new System.Drawing.Point(22, 84);
            this.customePanelOrder3.QtySize = new System.Drawing.Size(87, 78);
            this.customePanelOrder3.Size = new System.Drawing.Size(249, 165);
            this.customePanelOrder3.TabIndex = 1;
            this.customePanelOrder3.Title = "Title";
            this.customePanelOrder3.TitleAutoSize = false;
            this.customePanelOrder3.TitleFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.customePanelOrder3.TitleForeColor = System.Drawing.Color.Black;
            this.customePanelOrder3.TitleLocation = new System.Drawing.Point(22, 21);
            this.customePanelOrder3.TitleSize = new System.Drawing.Size(193, 29);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.Controls.Add(this.BtnAll, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnPending, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnComplete, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 173);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1018, 69);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAll.FlatAppearance.BorderSize = 0;
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.Location = new System.Drawing.Point(27, 2);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(250, 65);
            this.BtnAll.TabIndex = 0;
            this.BtnAll.Text = "All";
            this.BtnAll.UseVisualStyleBackColor = false;
            // 
            // BtnPending
            // 
            this.BtnPending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPending.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPending.FlatAppearance.BorderSize = 0;
            this.BtnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPending.Location = new System.Drawing.Point(661, 2);
            this.BtnPending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPending.Name = "BtnPending";
            this.BtnPending.Size = new System.Drawing.Size(225, 65);
            this.BtnPending.TabIndex = 0;
            this.BtnPending.Text = "Pending";
            this.BtnPending.UseVisualStyleBackColor = false;
            // 
            // BtnComplete
            // 
            this.BtnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnComplete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnComplete.FlatAppearance.BorderSize = 0;
            this.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComplete.Location = new System.Drawing.Point(407, 2);
            this.BtnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(250, 65);
            this.BtnComplete.TabIndex = 0;
            this.BtnComplete.Text = "Complete";
            this.BtnComplete.UseVisualStyleBackColor = false;
            // 
            // FRMDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1455, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRMDashboard";
            this.Text = "FRMDashboard";
            this.Load += new System.EventHandler(this.FRMDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Custome_Controls.Custome_Panel.CustomePanelOrder customePanelOrder1;
        private Custome_Controls.Custome_Panel.CustomePanelOrder customePanelOrder2;
        private Custome_Controls.Custome_Panel.CustomePanelOrder customePanelOrder3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnComplete;
        private System.Windows.Forms.Button BtnPending;
    }
}
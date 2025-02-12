using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarant.FormUI.Custome_Controls.RoundCornerControls;
using POSRestuarantBackEnd.SQLServer;
using static Syncfusion.Windows.Forms.Tools.MenuDropDown;
using Panel = System.Windows.Forms.Panel;

namespace POSRestuarant.FormUI.FRMMain
{
    public partial class FRMMenu : Form
    {
        Panel PnMenu = new Panel();
        PictureBox PicItem = new PictureBox();  
        Label lblItemName = new Label();
        Label lblDesc = new Label();
        Label lblPrice = new Label();
        RoundBorder objRound = new RoundBorder();
        InitializeFormMenu objMenu = new InitializeFormMenu();
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void FRMMenu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objMenu.InitializeMenu();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    byte[] imageData = (byte[])dt.Rows[i]["MenuImage"];
                    string MenuID = dt.Rows[i]["MenuID"].ToString();
                    string MenuName = dt.Rows[i]["MenuName"].ToString();
                    float Price = float.Parse(dt.Rows[i]["Price"].ToString());
                    // Create a new Panel for each item
                    PnMenu = new Panel
                    {
                        Name = "Panel" + MenuID,
                        Size = new Size(237, 280), // Adjusted size for each item
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White
                    };

                    // Add Panel to FlowLayoutPanel
                    FlpItems.Controls.Add(PnMenu);

                    // Create the PictureBox for the item image
                    PicItem = new PictureBox();
                    PicItem.Name = "PicItem" + MenuID;
                    PicItem.Size = new Size(215, 130); // Adjust picture size
                    PicItem.BackColor = Color.Red; // Placeholder color (set actual image later)
                    PicItem.Location = new Point((PnMenu.Width - 215) / 2, 15); // Center horizontally
                    PicItem.SizeMode = PictureBoxSizeMode.StretchImage; // Stretch image to fit PictureBox
                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            PicItem.Image = Image.FromStream(ms);
                        }
                    }

                    // Optional: Use objRound.RoundPictureBox(PicItem) to round the corners if needed
                    objRound.RoundPictureBox(PicItem);  // Assuming objRound is an object that rounds the PictureBox
                    PnMenu.Controls.Add(PicItem);

                    // Create Label for Item Name
                    lblItemName = new Label
                    {
                        Name = "lblItem" + MenuName,
                        Size = new Size(215, 30), // Adjust label size
                        Text = MenuName,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        Location = new Point((PnMenu.Width - 215) / 2, PicItem.Bottom + 5) // Below PictureBox with some space
                    };
                    PnMenu.Controls.Add(lblItemName);

                    // Create Label for Item Description
                    lblDesc = new Label
                    {
                        Name = "lblDesc" + i,
                        AutoSize = false,
                        Size = new Size(215, 60),
                        Text = "Description " + i + " with a longer string to test how it wraps text automatically in the label, There is not just that there are more to come",
                        TextAlign = ContentAlignment.TopLeft,
                        Font = new Font("Tahoma", 9),
                        ForeColor = Color.DimGray,
                        BackColor = Color.White,
                        Location = new Point((PnMenu.Width - 215) / 2, lblItemName.Bottom + 2)
                    };
                    PnMenu.Controls.Add(lblDesc);

                    // Create Label for Item Price
                    lblPrice = new Label
                    {
                        Name = "lblPrice" + MenuName,
                        Size = new Size(215, 30),
                        Text = Price.ToString() + " $",
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new Font("Arial", 14, FontStyle.Regular),
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        Location = new Point((PnMenu.Width - 215) / 2, lblItemName.Bottom + 65) // Below Description with space
                    };
                    PnMenu.Controls.Add(lblPrice);
                    foreach (Control ctrl in FlpItems.Controls)
                    {
                        if (ctrl is Panel)
                        {
                            ctrl.Margin = new Padding(25, 5, 5, 20);
                        }
                    }
                }
            }
        }
    }
}

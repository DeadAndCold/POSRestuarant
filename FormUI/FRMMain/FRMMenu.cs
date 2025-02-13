using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestuarant.FormUI.Custome_Controls.RoundCornerControls;
using POSRestuarantBackEnd.SQLServer;
using static Syncfusion.Windows.Forms.Tools.MenuDropDown;
using Label = System.Windows.Forms.Label;
using Panel = System.Windows.Forms.Panel;

namespace POSRestuarant.FormUI.FRMMain
{
    public partial class FRMMenu : Form
    {
        Panel PnMenu = new Panel();
        PictureBox PicItem = new PictureBox();
        Label lblItemName = new Label();
        Label lblItemDesc = new Label();
        Label lblItemPrice = new Label();

        Panel PnOrderItem = new Panel();
        Label lblOrderItemName = new Label();
        Label lblOrderItemPrice = new Label();
        Label lblOrderItemQty = new Label();
        private int OrderPanelLocationX = 0;
        private int OrderPanelLocationY = 0;

        private int OldPanelWidth = 0;
        private int NewPanelWidth = 0;

        RoundBorder objRound = new RoundBorder();
        InitializeFormMenu objMenu = new InitializeFormMenu();
        public FRMMenu()
        {
            InitializeComponent();
            OrderPanelLocationX = lblOrderDetail.Location.X - 14;
        }

        private void FRMMenu_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");

            // ==================================== Load Menu Items ====================================

            DataTable dt = new DataTable();
            dt = objMenu.InitializeMenu();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    byte[] imageData = (byte[])dt.Rows[i]["MenuImage"];
                    string MenuID = dt.Rows[i]["MenuID"].ToString();
                    string MenuName = dt.Rows[i]["MenuName"].ToString();
                    string MenuDesc = dt.Rows[i]["MenuDesc"].ToString();
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
                    PicItem.Tag = Price;
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
                        Name = "lblItemName",
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
                    if (string.IsNullOrEmpty(MenuDesc))
                    {
                        MenuDesc = "No Description Available.";
                    }
                    lblItemDesc = new Label
                    {
                        Name = "lblItemDesc",
                        AutoSize = false,
                        Size = new Size(215, 60),
                        Text = MenuDesc,
                        TextAlign = ContentAlignment.TopLeft,
                        Font = new Font("Tahoma", 9),
                        ForeColor = Color.DimGray,
                        BackColor = Color.White,
                        Location = new Point((PnMenu.Width - 215) / 2, lblItemName.Bottom + 2)
                    };
                    PnMenu.Controls.Add(lblItemDesc);

                    // Create Label for Item Price
                    lblItemPrice = new Label
                    {
                        Name = "lblItemPrice",
                        Size = new Size(215, 30),
                        Text = Price.ToString() + " $",
                        Tag = Price,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Font = new Font("Arial", 14, FontStyle.Regular),
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        Location = new Point((PnMenu.Width - 215) / 2, lblItemName.Bottom + 65) // Below Description with space
                    };
                    PnMenu.Controls.Add(lblItemPrice);
                    foreach (Control ctrl in FlpItems.Controls)
                    {
                        if (ctrl is Panel)
                        {
                            ctrl.Margin = new Padding(25, 5, 5, 20);
                        }
                    }
                    PnMenu.Click += new EventHandler(Menu_Clicked);
                    lblItemPrice.Click += new EventHandler(Menu_Clicked);
                    lblItemDesc.Click += new EventHandler(Menu_Clicked);
                    PicItem.Click += new EventHandler(Menu_Clicked);
                }
            }
        }

        private void Menu_Clicked(object sender, EventArgs e)
        {
            Control ItemClicked = (Control)sender;
            Panel parentPanel = ItemClicked as Panel ?? ItemClicked.Parent as Panel;
            Label lblName = parentPanel.Controls.Find("lblItemName", true).FirstOrDefault() as Label;
            Label lblPrice = parentPanel.Controls.Find("lblItemPrice", true).FirstOrDefault() as Label;
            Label lblDesc = parentPanel.Controls.Find("lblItemDesc", true).FirstOrDefault() as Label;

            if (lblName != null && lblPrice != null)
            {
                //OldPanelWidth = PanelOrderDetail.Width;
                //NewPanelWidth = PanelOrderDetail.Width;
                bool isFirstPanel = PanelOrderDetail.Controls.OfType<Panel>().Count() == 0;
                if (isFirstPanel)
                {
                    OrderPanelLocationY = lblOrderDetail.Bottom + 15;
                }
                else
                {
                    OrderPanelLocationY = PnOrderItem.Bottom + 10;
                }

                PnOrderItem = new Panel
                {
                    Name = "PnOrdered" + lblName.Text,
                    Size = new Size(lblBorderline.Width + 30, 128), // Adjusted size for each item
                    BorderStyle = BorderStyle.None,
                    //Location = new Point(OrderPanelLocationX, OrderPanelLocationY),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.White
                };
                FlpOrderDetial.Controls.Add(PnOrderItem);

                lblOrderItemName = new Label
                {
                    Name = "lblOrderItemName" + lblName,
                    AutoSize = true,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Size = new Size(215, 60),
                    Text = lblName.Text,
                    TextAlign = ContentAlignment.TopLeft,
                    Font = new Font("Tahoma", 11),
                    ForeColor = Color.Black,
                    BackColor = Color.White,
                    Location = new Point(25, 10)
                };
                PnOrderItem.Controls.Add(lblOrderItemName);

                int OrderDetailPanelWidth = 0;
                bool vScrollVisible = PanelOrderDetail.DisplayRectangle.Height > PanelOrderDetail.ClientRectangle.Height;

                if (FRMMain.isNavigationExpand)
                {
                    OldPanelWidth = PanelOrderDetail.Width;
                    OrderDetailPanelWidth = OldPanelWidth;
                }
                else
                {
                    NewPanelWidth = PanelOrderDetail.Width;
                    OrderDetailPanelWidth = NewPanelWidth;
                }

                lblOrderItemQty = new Label
                {
                    Name = "lblOrderItemQty" + lblName,
                    AutoSize = true,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Size = new Size(56, 25),
                    Text = " x1",
                    TextAlign = ContentAlignment.TopRight,
                    Font = new Font("Tahoma", 12),
                    ForeColor = Color.Black,
                    BackColor = Color.White,
                    Location = new Point(OrderDetailPanelWidth - 75, 10)
                };
                PnOrderItem.Controls.Add(lblOrderItemQty);

                lblOrderItemPrice = new Label
                {
                    Name = "lblOrderItemPrice" + lblPrice,
                    AutoSize = true,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Size = new Size(56, 25),
                    Text = lblPrice.Text,
                    Tag = lblPrice.Tag,
                    TextAlign = ContentAlignment.TopRight,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    BackColor = Color.White,
                    Location = new Point(OrderDetailPanelWidth - 75, 60)
                };
                PnOrderItem.Controls.Add(lblOrderItemPrice);

                Label lblLine = new Label
                {
                    Name = "lblLine",
                    AutoSize = false,
                    Size = new Size(344, 2),
                    BackColor = Color.LightGray,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    Location = new Point(30, lblOrderItemPrice.Bottom + 20)
                };
                PnOrderItem.Controls.Add(lblLine);

                int newLocationY = (OrderPanelLocationY + PnOrderItem.Height);
                OrderPanelLocationY = newLocationY + 10;
            }
        }
        private void PanelOrderDetail_SizeChanged(object sender, EventArgs e)
        {
            if (FRMMain.isNavigationExpand)
            {
                OldPanelWidth = PanelOrderDetail.Width;
            }
            else
            {
                NewPanelWidth = PanelOrderDetail.Width;
            }
        }
    }
}

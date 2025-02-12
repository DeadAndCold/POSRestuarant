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
using Syncfusion.CompoundFile.XlsIO.Native;

namespace POSRestuarant.FormUI.FRMMain
{
    public partial class FRMTables : Form
    {
        private bool isDragging = false;
        private int offsetX;
        private int offsetY;
        PictureBox picTable = new PictureBox();
        RoundBorder objRoundControls = new RoundBorder();
        InitializeFormTable objTable = new InitializeFormTable();
        public FRMTables()
        {
            InitializeComponent();
        }

        private void FRMTables_Load(object sender, EventArgs e)
        {
            LoadTableToForm();
        }
        private void LoadTableToForm()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = objTable.InitializeTable();
                int x = 0;
                int y = 0;
                int width = 0;
                int height = 0;
                string TableID = string.Empty;
                string TableType = string.Empty;
                string TableStatus = string.Empty;
                string TableIMage = string.Empty;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TableID = dt.Rows[i]["TableID"].ToString();
                    TableType = dt.Rows[i]["TableType"].ToString();
                    TableStatus = dt.Rows[i]["Status"].ToString();
                    x = int.Parse(dt.Rows[i]["X"].ToString());
                    y = int.Parse(dt.Rows[i]["Y"].ToString());
                    width = int.Parse(dt.Rows[i]["Width"].ToString()); ;
                    height = int.Parse(dt.Rows[i]["Height"].ToString());

                    picTable = new PictureBox();
                    picTable.Name = TableID;
                    picTable.Size = new Size(100, 100);
                    picTable.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (TableStatus.Trim() == "A" && TableType.Trim() == "Normal")
                    {
                        TableIMage = Path.Combine(Application.StartupPath, "Images", "Table Image", "Avaiable Table 4 Seats.png");
                        picTable.Image = Image.FromFile(TableIMage);
                    }
                    if (TableStatus.Trim() == "B" && TableType.Trim() == "Normal")
                    {
                        TableIMage = Path.Combine(Application.StartupPath, "Images", "Table Image", "Booked Table 4 Seats.png");
                        picTable.Image = Image.FromFile(TableIMage);
                    }
                    if (TableStatus.Trim() == "D" && TableType.Trim() == "Normal")
                    {
                        TableIMage = Path.Combine(Application.StartupPath, "Images", "Table Image", "Dining Table 4 Seats.png");
                        picTable.Image = Image.FromFile(TableIMage);
                    }

                    if (TableStatus.Trim() == "A" && TableType.Trim() == "Family")
                    {
                        TableIMage = Path.Combine(Application.StartupPath, "Images", "Table Image", "Avaiable Table 6 Seats.png");
                        picTable.Image = Image.FromFile(TableIMage);
                    }
                    if (TableStatus.Trim() == "B" && TableType.Trim() == "Family")
                    {
                        TableIMage = Path.Combine(Application.StartupPath, "Images", "Table Image", "Booked Table 6 Seats.png");
                        picTable.Image = Image.FromFile(TableIMage);
                    }
                    if (TableStatus.Trim() == "D" && TableType.Trim() == "Family")
                    {
                        TableIMage = Path.Combine(Application.StartupPath, "Images", "Table Image", "Dining Table 6 Seats.png");
                        picTable.Image = Image.FromFile(TableIMage);
                    }
                    picTable.Size = new Size(width, height);
                    picTable.Location = new Point(x, y);
                    picTable.DoubleClick += new EventHandler(picTable_DoubleClick);
                    picTable.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
                    picTable.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
                    picTable.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
                    objRoundControls.RoundPictureBox(picTable);
                    PanelTables.Controls.Add(picTable);
                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTable_DoubleClick(object sender, EventArgs e)
        {
            PictureBox picClicked = (PictureBox)sender;
            string TableID = picClicked.Name;
            MessageBox.Show(TableID);
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // If the mouse is pressed inside the PictureBox, begin dragging
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // If we are dragging, move the PictureBox based on mouse position
            if (isDragging)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.Left = e.X + pictureBox.Left - offsetX;
                pictureBox.Top = e.Y + pictureBox.Top - offsetY;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when mouse is released
            isDragging = false;
        }

    }
}

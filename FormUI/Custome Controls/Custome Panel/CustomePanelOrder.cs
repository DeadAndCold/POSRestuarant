using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRestuarant.FormUI.Custome_Controls.Custome_Panel
{
    public partial class CustomePanelOrder : UserControl
    {
        public CustomePanelOrder()
        {
            InitializeComponent();
        }

        private void CustomePanelOrder_Load(object sender, EventArgs e)
        {

        }
        #region Properties

        private string _title = "Title";
        private Color _titleForeColor = Color.Black;
        private Font _titleFont = new Font("Arial", 15f, FontStyle.Bold);
        private bool _titleAutoSize = false;
        private Size _titleSize = new Size(193, 29);
        private Point _titleLocation = new Point(22, 21);
        private string _qty = "0";
        private Color _qtyForeColor = Color.Black;
        private Font _qtyFont = new Font("Arial", 12f, FontStyle.Regular);
        private bool _qtyAutoSize = false;
        private Size _qtySize = new Size(87, 78);
        private Point _qtyLocation = new Point(22, 84);
        private string _desc = "Description";
        private Color _descForeColor = Color.Black;
        private Font _descFont = new Font("Arial", 10f, FontStyle.Regular);
        private bool _descAutoSize = false;
        private Size _descSize = new Size(273, 59);
        private Point _descLocation = new Point(22, 148);
        private Image _image;

        [Category("Custome Properties")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custome Properties")]
        public Color TitleForeColor
        {
            get { return _titleForeColor; }
            set { _titleForeColor = value; lblTitle.ForeColor = value; }
        }

        [Category("Custome Properties")]
        public bool TitleAutoSize
        {
            get { return _titleAutoSize; }
            set { _titleAutoSize = value; lblTitle.AutoSize = value; }
        }

        [Category("Custome Properties")]
        public Size TitleSize
        {
            get { return _titleSize; }
            set { _titleSize = value; lblTitle.Size = value; }
        }

        [Category("Custome Properties")]
        public Font TitleFont
        {
            get { return _titleFont; }
            set { _titleFont = value; lblTitle.Font = value; }
        }

        [Category("Custome Properties")]
        public Point TitleLocation
        {
            get { return _titleLocation; }
            set { _titleLocation = value; lblTitle.Location = value; }
        }

        [Category("Custome Properties")]
        public string Qty
        {
            get { return _qty; }
            set { _qty = value; lblQty.Text = value; }
        }

        [Category("Custome Properties")]
        public Color QtyForeColor
        {
            get { return _qtyForeColor; }
            set { _qtyForeColor = value; lblQty.ForeColor = value; }
        }

        [Category("Custome Properties")]
        public Font QtyFont
        {
            get { return _qtyFont; }
            set { _qtyFont = value; lblQty.Font = value; }
        }

        [Category("Custome Properties")]
        public bool QtyAutoSize
        {
            get { return _qtyAutoSize; }
            set { _qtyAutoSize = value; lblQty.AutoSize = value; }
        }

        [Category("Custome Properties")]
        public Size QtySize
        {
            get { return _qtySize; }
            set { _qtySize = value; lblQty.Size = value; }
        }

        [Category("Custome Properties")]
        public Point QtyLocation
        {
            get { return _qtyLocation; }
            set { _qtyLocation = value; lblQty.Location = value; }
        }

        [Category("Custome Properties")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }

        [Category("Custome Properties")]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; lblDesc.Text = value; }
        }

        [Category("Custome Properties")]
        public Color DescForeColor
        {
            get { return _descForeColor; }
            set { _descForeColor = value; lblDesc.ForeColor = value; }
        }

        [Category("Custome Properties")]
        public Font DescFont
        {
            get { return _descFont; }
            set { _descFont = value; lblDesc.Font = value; }
        }

        [Category("Custome Properties")]
        public bool DescAutoSize
        {
            get { return _descAutoSize; }
            set { _descAutoSize = value; lblDesc.AutoSize = value; }
        }

        [Category("Custome Properties")]
        public Size DescSize
        {
            get { return _descSize; }
            set { _descSize = value; lblDesc.Size = value; }
        }

        [Category("Custome Properties")]
        public Point DescLocation
        {
            get { return _descLocation; }
            set { _descLocation = value; lblDesc.Location = value; }
        }

        #endregion
    }
}

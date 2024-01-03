using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM.Model
{
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;
        public ucProduct()
        {
            InitializeComponent();
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }

        private void pictProduct_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        public int ID {  get; set; }

        public int STOCK { get; set; }

        public string NAME { get { return lblName.Text; } set { lblName.Text = value; } }

        public string PRICE { get { return lblPrice.Text; } set { lblPrice.Text = value; } }

        public Image IMAGE { get { return pictProduct.Image; } set { pictProduct.Image = value; } }

    }
}

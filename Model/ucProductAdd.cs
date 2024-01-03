using Aspose.Words.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.ValidationMethod;

namespace POS_SYSTEM.Model
{
    public partial class ucProductAdd : UserControl
    {
        int qty = 0;
        public event EventHandler onSelect = null;

        public ucProductAdd()
        {
            InitializeComponent();
        }

        private void controlExit_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }


        public void txtQTY_TextChanged(object sender, EventArgs e)
        {
            ValidateNegativeInput(txtQTY);

        }

        public int ID { get; set; }

        public string  PRICE { get; set; }

        public string NAME { get { return lblNameAdd.Text; } set { lblNameAdd.Text = value; } }

        public string STOCK { get { return lblStockAdd.Text; } set { lblStockAdd.Text = value; } }

        public string QTY { get { return txtQTY.Text; } set { txtQTY.Text = value; } }

        public string TPRICE { get { return lblPriceAdd.Text; } set { lblPriceAdd.Text = value; } }

        public Image IMAGE { get { return pictProductAdd.Image; } set { pictProductAdd.Image = value; } }

    }
}

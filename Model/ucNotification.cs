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
    public partial class ucNotification : UserControl
    {
        public event EventHandler onSelect = null;
        public ucNotification()
        {
            InitializeComponent();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        public int ID { get; set; }

        public string NAME { get { return lblName.Text; } set { lblName.Text = value; } }

        public string INFO { get { return lblInfo.Text; } set { lblInfo.Text = value; } }

        public Image IMAGE { get { return pictNotif.Image; } set { pictNotif.Image = value; } }

    }
}

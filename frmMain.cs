using Microsoft.SqlServer.Management.Smo;
using POS_SYSTEM.Class;
using POS_SYSTEM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;

namespace POS_SYSTEM
{
    public partial class frmMain : Sample
    {
        static frmMain _obj;
        bool staffExpand = false;
        bool inventoryExpand = false;
        bool customerExpand = false;
        public static frmMain Instance { get { if (_obj == null) { _obj = new frmMain(); } return _obj; } }
        Dictionary<int, Control> featureToControlMap = new Dictionary<int, Control>();

        public frmMain()
        {
            InitializeComponent();
            featureToControlMap.Add(1, panelDashboard);
            featureToControlMap.Add(2, panelStaff);
            featureToControlMap.Add(3, btnRole);
            featureToControlMap.Add(4, btnStaffList);
            featureToControlMap.Add(5, btnAccount);
            featureToControlMap.Add(6, btnCourier);
            featureToControlMap.Add(7, panelInventory);
            featureToControlMap.Add(8, btnUnit);
            featureToControlMap.Add(9, btnCategory);
            featureToControlMap.Add(10, btnProduct);
            featureToControlMap.Add(11, btnStockIn);
            featureToControlMap.Add(12, btnStockOut);
            featureToControlMap.Add(13, panelCustomer);
            featureToControlMap.Add(14, btnCustomerList);
            featureToControlMap.Add(15, btnLoan);
            featureToControlMap.Add(16, btnDeposit);
            featureToControlMap.Add(17, panelSupplier);
            featureToControlMap.Add(18, panelSale);
            featureToControlMap.Add(19, panelDelivery);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            panelStaff.Size = panelStaff.MinimumSize;
            panelInventory.Size = panelInventory.MinimumSize;
            panelCustomer.Size = panelCustomer.MinimumSize;
            timerClock.Start();
            lblName.Text = DataMethod.USER;
            lblPosition.Text = DataMethod.ROLE;
            pictProfile.Image = DataMethod.PROFILE;
            Privilege();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            CommonMethod.timer = DateTime.Now;
            //MainClass.timer = DateTime.Now;
        }

        private void timerStaff_Tick(object sender, EventArgs e)
        {
            if (staffExpand == false)
            {
                btnStaff.Image = Properties.Resources.down_arrow_color;
                panelStaff.Height += 10;
                if (panelStaff.Size == panelStaff.MaximumSize)
                {
                    timerStaff.Stop();
                    staffExpand = true;
                }
            }
            else
            {
                btnStaff.Image = Properties.Resources.right_arrow_color;
                panelStaff.Height -= 10;
                if (panelStaff.Size == panelStaff.MinimumSize)
                {
                    timerStaff.Stop();
                    staffExpand = false;
                }
            }
        }


       /* private int PanelStaff()
        {
            int totalHeight = btnCustomer.Height;

            if (btnRole.Visible == true)
            {
                totalHeight += btnRole.Height + 5;
            }

            if (btnStaffList.Visible == true)
            {
                totalHeight += btnStaffList.Height + 5;
            }

            if (btnAccount.Visible == true)
            {
                totalHeight += btnAccount.Height + 5;
            }

            if (btnCourier.Visible == true)
            {
                totalHeight += btnCourier.Height + 5;
            }

            return totalHeight;
        }*/

        private void timerCustomer_Tick(object sender, EventArgs e)
        {
            if (customerExpand == false)
            {
                btnCustomer.Image = Properties.Resources.down_arrow_color;
                panelCustomer.Height += 10;
                if (panelCustomer.Size == panelCustomer.MaximumSize)
                {
                    timerCustomer.Stop();
                    customerExpand = true;
                }
            }
            else
            {
                btnCustomer.Image = Properties.Resources.right_arrow_color;
                panelCustomer.Height -= 10;
                if (panelCustomer.Size == panelCustomer.MinimumSize)
                {
                    timerCustomer.Stop();
                    customerExpand = false;
                }
            }
        }

        private void timerInventory_Tick(object sender, EventArgs e)
        {
            if (inventoryExpand == false)
            {
                btnInventory.Image = Properties.Resources.down_arrow_color;
                panelInventory.Height += 10;
                if (panelInventory.Size == panelInventory.MaximumSize)
                {
                    timerInventory.Stop();
                    inventoryExpand = true;
                }
            }
            else
            {
                btnInventory.Image = Properties.Resources.right_arrow_color;
                panelInventory.Height -= 10;
                if (panelInventory.Size == panelInventory.MinimumSize)
                {
                    timerInventory.Stop();
                    inventoryExpand = false;
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControl(new frmDashboardView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            inventoryExpand = true;
            customerExpand = true;

            timerStaff.Start();
            timerInventory.Start();
            timerCustomer.Start();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            AddControl(new frmRoleView());
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            AddControl(new frmFinanceView());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AddControl(new frmUserView());
        }

        private void btnCourier_Click(object sender, EventArgs e)
        {
            AddControl(new frmCourierView());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            staffExpand = true;
            customerExpand = true;

            timerStaff.Start();
            timerInventory.Start();
            timerCustomer.Start();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            AddControl(new frmUnitView());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControl(new frmCategoryView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControl(new frmProductView());
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            AddControl(new frmStockInView());
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            AddControl(new frmStockOutView());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            staffExpand = true;
            inventoryExpand = true;

            timerStaff.Start();
            timerInventory.Start();
            timerCustomer.Start();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            AddControl(new frmCustomerView());
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            AddControl(new frmLoanView());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            AddControl(new frmDepositView());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            AddControl(new frmSupplierView());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            AddControl(new frmSaleview());
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            AddControl(new frmDeliveryView());
        }

        private void btnStaffList_Click(object sender, EventArgs e)
        {
            AddControl(new frmStaffview());
        }

        public void AddControl(Form form)
        {
            this.panelMain.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void controlExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void pictProfile_Click(object sender, EventArgs e)
        {
            AddControl(new frmProfileView());
        }



        private void Privilege()
        {
            string qry = @"SELECT * FROM Privilege WHERE id_role = '" + ROLEID + "'";

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                int idFeature = Convert.ToInt32(row["id_feature"]);
                int viewPrivilege = Convert.ToInt32(row["view"]);

                if (featureToControlMap.ContainsKey(idFeature) && viewPrivilege == 1)
                {
                    Control control = featureToControlMap[idFeature];
                    control.Visible = true;
                }
            }
        }

    }
}

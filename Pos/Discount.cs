using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;

namespace Pharmacy.Pos
{
    public partial class Discount : DevExpress.XtraEditors.XtraForm
    {
        private int CustomerID = 0;
        public Discount()
        {
            InitializeComponent();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            barServer.Caption = "Серверийн нэр: " + DBRes.mServer.ToString();
            barDB.Caption = "Мэдээлэлийн бааз: " + DBRes.mDatabase.ToString();
            barUser.Caption = "Хэрэглэгч: " + DBRes.mUser.ToString();
            barDate.Caption = "Систем огноо: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

            dateJorOgnoo.Text = DateTime.Now.ToString("yyyy-MM-dd");

            timer1.Start();

            DBRes._FillTable("SELECT B.BarCode,B.Name,A.*,B.NDDiscountTotal FROM tDiscountSaleDetail A "
                + " INNER JOIN tDiscountDrug B ON(B.DiscountDrugID=A.DiscountDrugID) "
                + " WHERE A.DSDetailID=-1", "DiscountSaleDetail");
            gridDiscountSaleDetail.DataSource = DBRes.DS.Tables["DiscountSaleDetail"];

            DBRes._FillTable("SELECT A.SaleDetailID,A.Count,A.Price,A.SumPrice, "
                + " A.DrugID,(B.Name + ' - '+B.Size)NameSize,'' AS Status FROM tSaleDetail A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) WHERE A.DrugID=-1", "SaleDetail");
            gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetail"];

            DBRes._FillTable("SELECT DiscountDrugID,BarCode,(Name+' '+Comment)Name,Package,Price,Price PriceND,NDDiscountTotal "
                + " FROM tDiscountDrug WHERE IsDiscount=1", "DisDrug");
            lookDrug.Properties.DataSource = DBRes.DS.Tables["DisDrug"];
            lookDrug.Properties.ValueMember = "DiscountDrugID";
            lookDrug.Properties.DisplayMember = "Name";

            //Jor num
            DBRes._FillTable("SELECT ISNULL(MAX(JorNum),0)JorNum FROM tDiscountSale WHERE ActionDate>='" + DateTime.Now.ToString("yyyy-MM") + "-01 00:00:00'", "DiscountSaleJorNum");
            txtJorNum.Text = (Convert.ToInt32(DBRes.DS.Tables["DiscountSaleJorNum"].Rows[0]["JorNum"]) + 1).ToString();
        }

        #region F1 btn
        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnF1_Click(sender, e);
            else if (e.KeyCode == Keys.F2)
                btnF2_Click(sender, e);
            else if (e.KeyCode == Keys.F3)
                btnF3_Click(sender, e);
            else if (e.KeyCode == Keys.F4)
                btnF4_Click(sender, e);
            else if (e.KeyCode == Keys.F5)
                btnF5_Click(sender, e);
            else if (e.KeyCode == Keys.F6)
                btnF6_Click(sender, e);
            else if (e.KeyCode == Keys.F7)
                btnF7_Click(sender, e);
            else if (e.KeyCode == Keys.F8)
                btnF8_Click(sender, e);
            else if (e.KeyCode == Keys.F9)
                btnF9_Click(sender, e);
            else if (e.KeyCode == Keys.F10)
                btnF10_Click(sender, e);
        }
        private void btnF1_Click(object sender, EventArgs e)
        {
            lookDrug.Focus();
            lookDrug.SelectAll();
        }
        private void btnF2_Click(object sender, EventArgs e)
        {
            txtBarCode.Focus();
            txtBarCode.SelectAll();
        }
        private void btnF3_Click(object sender, EventArgs e)
        {
            dateJorOgnoo.Enabled = true;
            dateJorOgnoo.Focus();
            dateJorOgnoo.SelectAll();
        }
        private void btnF4_Click(object sender, EventArgs e)
        {
            Forms.DrugList druglist = new Forms.DrugList();
            druglist.ShowInTaskbar = false;
            druglist.IsDiscount = true;
            if (druglist.ShowDialog() == DialogResult.OK)
            {
                DataRow[] rows;
                if (druglist.gridViewDrug == null && druglist.gridViewDrug.SelectedRowsCount == 0) return;
                rows = new DataRow[druglist.gridViewDrug.SelectedRowsCount];
                for (int i = 0; i < druglist.gridViewDrug.SelectedRowsCount; i++)
                {
                    rows[i] = druglist.gridViewDrug.GetDataRow(druglist.gridViewDrug.GetSelectedRows()[i]);
                }
                foreach (DataRow row in rows)
                {
                    if (row == null) return;
                    lookDrug.EditValue = Convert.ToInt32(row["DrugID"]);
                    lookDrug.Focus();
                }
            }
        }
        private void btnF5_Click(object sender, EventArgs e)
        {
            txtDoctorNum.Enabled = true;
            txtDoctorNum.Focus();
            txtDoctorNum.SelectAll();
        }
        private void btnF6_Click(object sender, EventArgs e)
        {
            txtBarCode.Focus();
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDiscountSaleDetail.DataSource as DataTable).Copy());
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count != ds.Tables[1].Rows.Count)
            {
                XtraMessageBox.Show("НД-ийн хөнгөлттэй эмийн жагсаалт, борлуулалтын үндсэн тооцоонд хамаарах эмийн жагсаалт хоёрын ижил тооны эм орсон байх шаардлагатай.",
                    "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ds.Tables["DiscountSaleDetail"].Rows.Count > 0)
            {
                decimal sumtotal = 0;
                decimal distotal = 0;
                decimal dToloh = 0;
                decimal total = 0;
                for (int i = 0; i < ds.Tables["DiscountSaleDetail"].Rows.Count; i++)
                {
                    sumtotal = sumtotal + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["PriceND"]);
                    distotal = distotal + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["NDDiscountTotal"]);
                    dToloh = dToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["DisCusPrice"]);
                }
                for (int i = 0; i < ds.Tables["SaleDetail"].Rows.Count; i++)
                {
                    total = total + Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["SumPrice"]);
                }
                Pos.Payment normalpayment = new Payment();
                normalpayment.txtDiscountCardNum.Enabled = false;
                normalpayment.btnF2.Enabled = false;
                normalpayment.txtTotal.Text = sumtotal.ToString("###,###,###,###,###.##");
                normalpayment.txtDiscountTotal.Text = distotal.ToString("###,###,###,###,###.##");
                normalpayment.txtCashAmount.Text = dToloh.ToString("###,###,###,###,###.##");
                //zavgar oorchiloh
                normalpayment.panelControl1.Visible = false;
                normalpayment.panelControl2.Location = new System.Drawing.Point(5, 5);
                normalpayment.btnF2.Visible = false;
                normalpayment.btnF4.Location = new System.Drawing.Point(5, 277);
                normalpayment.btnF4.Size = new System.Drawing.Size(163, 40);
                normalpayment.btnF6.Location = new System.Drawing.Point(173, 277);
                normalpayment.btnF6.Size = new System.Drawing.Size(165, 40);
                normalpayment.ClientSize = new System.Drawing.Size(344, 322);
                //
                if (normalpayment.ShowDialog() == DialogResult.OK)
                {
                    decimal paidTotal = Convert.ToDecimal(normalpayment.txtCashAmount.Text);
                    int cardID = normalpayment.CardID;
                    decimal discountTotal = Convert.ToDecimal(normalpayment.txtDiscountTotal.Text);
                    if (payment_Sale(total, cardID, paidTotal, discountTotal))
                        formClear(sender, e);
                }
            }
        }
        private void btnF7_Click(object sender, EventArgs e)
        {
            if (!gridDiscountSaleDetail.Focused)
            {
                gridColumnCountDS.OptionsColumn.AllowEdit = true;
                gridColumnCountDS.OptionsColumn.AllowFocus = true;
                gridDiscountSaleDetail.Focus();
            }
            else
            {
                gridColumnCountSale.OptionsColumn.AllowEdit = true;
                gridColumnCountSale.OptionsColumn.AllowFocus = true;
                gridSaleDetail.Focus();
            }
        }
        private void btnF8_Click(object sender, EventArgs e)
        {
            this.gridDiscountSaleDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridRowDelete_KeyDown);
            gridDiscountSaleDetail.Focus();
        }
        private void btnF9_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Борлуулалтын хэсгийн мэдээлэлийг цэвэрлэх гэж байна. Цэвэрлэх үү?", "Цэвэрлэх", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    formClear(sender, e);
            }
            else
                formClear(sender, e);
        }
        private void btnF10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void formClear(object sender, EventArgs e)
        {
            btneditDiscountCustmorRegNum.Enabled = true;
            //
            btnF1.Enabled = false;
            btnF2.Enabled = false;
            btnF4.Enabled = false;
            btnF7.Enabled = false;
            btnF8.Enabled = false;
            lookDrug.Enabled = false;
            txtBarCode.Enabled = false;
            //
            txtDoctorNum.Text = String.Empty;
            txtDoctorNum.Enabled = true;
            txtDoctorNum.Focus();
            //
            dateJorOgnoo.Enabled = true;
            //
            btneditDiscountCustmorRegNum.Text = String.Empty;
            btneditDiscountCustmorRegNum.Enabled = true;
            txtLastName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtEMDNum.Text = String.Empty;
            txtNDDNum.Text = String.Empty;
            txtAddress.Text = String.Empty;
            //
            txtSumPrice.Text = String.Empty;
            txtNDToloh.Text = String.Empty;
            txtDToloh.Text = String.Empty;
            //
            DBRes._FillTable("SELECT C.Name,A.[Count],B.ActionDate FROM tDiscountSaleDetail A "
                + " INNER JOIN tDiscountSale B ON(B.DiscountSaleID=A.DiscountSaleID) "
                + " INNER JOIN tDiscountDrug C ON(C.DiscountDrugID=A.DiscountDrugID) "
                + " WHERE A.DSDetailID=-1", "DiscountSaleDetailOldView");
            gridDisCustomerOldDrug.DataSource = DBRes.DS.Tables["DiscountSaleDetailOldView"];
            //
            Discount_Load(sender, e);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            barDate.Caption = "Систем огноо: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        private void gridRowDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataRow[] rows;
                if (gridViewDiscountSaleDetail != null && gridViewDiscountSaleDetail.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Мөр устгах гэж байна. Устгах уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewDiscountSaleDetail.SelectedRowsCount];
                        int drugID = 0;
                        for (int i = 0; i < gridViewDiscountSaleDetail.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewDiscountSaleDetail.GetDataRow(gridViewDiscountSaleDetail.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            drugID = Convert.ToInt32(row["DrugID"]);
                            row.Delete();
                        }
                        DataSet ds = new DataSet();
                        ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
                        for (int i = 0; i < ds.Tables["SaleDetail"].Rows.Count; i++)
                        {
                            if (Convert.ToInt32(ds.Tables["SaleDetail"].Rows[i]["DrugID"]) == drugID)
                                ds.Tables["SaleDetail"].Rows[i].Delete();
                        }
                        gridSaleDetail.DataSource = ds.Tables["SaleDetail"];
                    }
                }
                drugDelete();
                txtBarCode.Focus();
            }
        }

        private void drugDelete()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDiscountSaleDetail.DataSource as DataTable).Copy());
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            decimal sumPrice = 0;
            decimal NDToloh = 0;
            decimal DToloh = 0;
            for (int i = 0; i < ds.Tables["DiscountSaleDetail"].Rows.Count; i++)
            {
                sumPrice = sumPrice + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["PriceND"]);
                NDToloh = NDToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["NDDiscountTotal"]);
                DToloh = DToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["DisCusPrice"]);
            }
            txtSumPrice.Text = sumPrice.ToString("###,###,###,###,###.##");
            txtNDToloh.Text = NDToloh.ToString("###,###,###,###,###.##");
            txtDToloh.Text = DToloh.ToString("###,###,###,###,###.##");
        }

        private void Discount_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Борлуулалтын цонх хаах гэж байна. Хаах уу?", "Борлуулалтын цонх хаах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    this.DialogResult = DialogResult.OK;
                }
                else { e.Cancel = true; }
            }
            else
            {
                e.Cancel = false;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btneditDiscountCustmorRegNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btneditDiscountCustmorRegNum.Text.Trim() == String.Empty) return;
                try
                {
                    DBRes._FillTable("SELECT * FROM tDiscountCustomer WHERE RegNum=N'" + btneditDiscountCustmorRegNum.Text.Trim() + "'", "DiscountCustomer");
                    if (DBRes.DS.Tables["DiscountCustomer"].Rows.Count > 0)
                    {
                        CustomerID = Convert.ToInt32(DBRes.DS.Tables["DiscountCustomer"].Rows[0]["CustomerID"]);
                        txtLastName.Text = DBRes.DS.Tables["DiscountCustomer"].Rows[0]["LastName"].ToString();
                        txtFirstName.Text = DBRes.DS.Tables["DiscountCustomer"].Rows[0]["FirstName"].ToString();
                        txtEMDNum.Text = DBRes.DS.Tables["DiscountCustomer"].Rows[0]["EMDNum"].ToString();
                        txtNDDNum.Text = DBRes.DS.Tables["DiscountCustomer"].Rows[0]["NDNum"].ToString();
                        txtAddress.Text = DBRes.DS.Tables["DiscountCustomer"].Rows[0]["Address"].ToString();

                        btneditDiscountCustmorRegNum.Enabled = false;
                        //
                        lookDrug.Enabled = true;
                        txtBarCode.Enabled = true;
                        btnF1.Enabled = true;
                        btnF2.Enabled = true;
                        btnF4.Enabled = true;
                        btnF7.Enabled = true;
                        btnF8.Enabled = true;
                        //
                        lookDrug.Focus();
                        //
                        DBRes._FillTable("SELECT C.Name,A.[Count],B.ActionDate FROM tDiscountSaleDetail A "
                            + " INNER JOIN tDiscountSale B ON(B.DiscountSaleID=A.DiscountSaleID) "
                            + " INNER JOIN tDiscountDrug C ON(C.DiscountDrugID=A.DiscountDrugID) "
                            + " WHERE B.ActionDate>='" + DateTime.Now.ToString("yyyy-MM") + "-01' AND B.CustomerID=" + CustomerID
                            + " ORDER BY B.ActionDate DESC", "DiscountSaleDetailOldView");
                        gridDisCustomerOldDrug.DataSource = DBRes.DS.Tables["DiscountSaleDetailOldView"];
                    }
                    else XtraMessageBox.Show(btneditDiscountCustmorRegNum.Text.Trim() + "- регистртэй даатгуулалгчын мэдээлэл олдсонгүй.", "Даатгуулагч", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception) { XtraMessageBox.Show(btneditDiscountCustmorRegNum.Text.Trim() + "- регистртэй даатгуулалгчын мэдээлэл олдсонгүй.", "Даатгуулагч", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (e.KeyCode == Keys.F12)
            {
                Forms.DiscountCustomer discountcustomer = new Forms.DiscountCustomer();
                discountcustomer.IsSel = true;
                discountcustomer.txtRegNum.Text = btneditDiscountCustmorRegNum.Text;
                if (discountcustomer.ShowDialog() == DialogResult.OK)
                {
                    btneditDiscountCustmorRegNum.Text = discountcustomer.RegNum;
                }
            }
        }

        private void txtDoctorNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDoctorNum.Text.Trim() == String.Empty) return;
                dateJorOgnoo.Focus();
            }
        }

        private void dateJorOgnoo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btneditDiscountCustmorRegNum.Focus();
        }

        private void btneditDiscountCustmorRegNum_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Forms.DiscountCustomer discountcustomer = new Forms.DiscountCustomer();
            discountcustomer.IsSel = true;
            discountcustomer.txtRegNum.Text = btneditDiscountCustmorRegNum.Text;
            if (discountcustomer.ShowDialog() == DialogResult.OK)
            {
                btneditDiscountCustmorRegNum.Text = discountcustomer.RegNum;
            }
        }

        private void chbJorNumChange_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJorNumChange.Checked)
                txtJorNum.Enabled = true;
            else
                txtJorNum.Enabled = false;
        }

        private void txtDoctorNum_Leave(object sender, EventArgs e)
        {
            txtDoctorNum.Enabled = false;
        }

        private void dateJorOgnoo_Leave(object sender, EventArgs e)
        {
            dateJorOgnoo.Enabled = false;
        }

        private void gridViewDiscountSaleDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SumPrice") return;
            if (e.Column.FieldName == "PriceND") return;
            if (e.Column.FieldName == "NDDiscountTotal") return;
            if (e.Column.FieldName == "DisCusPrice") return;
            if (e.Column.FieldName == "Zoroo") return;
            decimal a = PharmacyFun.balanceCheck(Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("DrugID")), Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")));
            if (a != -1 && a != -2 && a != -3)
            {
                XtraMessageBox.Show(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Name") + " - үлдэгдэл хүрэхгүй байна. Үлдэгдэл - " + a + " байна.", "Эмийн үлдэгдэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridViewDiscountSaleDetail.SetFocusedRowCellValue("Count", a);
            }
            int discountDrugID = Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("DiscountDrugID"));

            //-----Tur arilgav----- niigemiin daatgaliin deed hemjeeg shalgah heseg--------
            //int mCount = checkMaxCount(discountDrugID);
            //if (mCount != Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")))
            //{
            //    gridViewDiscountSaleDetail.SetFocusedRowCellValue("Count", mCount);
            //}

            gridViewDiscountSaleDetail.SetFocusedRowCellValue("SumPrice", Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Price")));
            gridViewDiscountSaleDetail.SetFocusedRowCellValue("PriceND", Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * UnitDisPrice(discountDrugID));
            gridViewDiscountSaleDetail.SetFocusedRowCellValue("NDDiscountTotal", Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * UnitDisCusPrice(discountDrugID));
            gridViewDiscountSaleDetail.SetFocusedRowCellValue("DisCusPrice", (Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * UnitDisPrice(discountDrugID)) - (Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * UnitDisCusPrice(discountDrugID)));
            gridViewDiscountSaleDetail.SetFocusedRowCellValue("Zoroo", Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("SumPrice")) - (Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * UnitDisPrice(discountDrugID)));
            gridViewDiscountSaleDetail.RefreshData();
            //
            int drugID = Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("DrugID"));
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[i]["DrugID"]) == drugID)
                {
                    ds.Tables[0].Rows[i]["Count"] = Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count"));
                    ds.Tables[0].Rows[i]["SumPrice"] = Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * Convert.ToInt32(ds.Tables[0].Rows[i]["Price"]);
                }
            }
            gridSaleDetail.DataSource = ds.Tables[0];
            //
            decimal ab1 = Convert.ToDecimal(gridViewDiscountSaleDetail.Columns["PriceND"].SummaryItem.SummaryValue);
            txtSumPrice.EditValue = ab1.ToString("###,###,###,###,###.##");
            decimal ab2 = Convert.ToDecimal(gridViewDiscountSaleDetail.Columns["NDDiscountTotal"].SummaryItem.SummaryValue);
            txtNDToloh.EditValue = ab2.ToString("###,###,###,###,###.##");
            decimal ab3 = Convert.ToDecimal(gridViewDiscountSaleDetail.Columns["DisCusPrice"].SummaryItem.SummaryValue);
            txtDToloh.EditValue = ab3.ToString("###,###,###,###,###.##");
        }

        private void gridViewSaleDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SumPrice") return;
            decimal a = PharmacyFun.balanceCheck(Convert.ToInt32(gridViewSaleDetail.GetFocusedRowCellValue("DrugID")), Convert.ToInt32(gridViewSaleDetail.GetFocusedRowCellValue("Count")));
            if (a != -1 && a != -2 && a != -3)
            {
                XtraMessageBox.Show(gridViewSaleDetail.GetFocusedRowCellValue("NameSize") + " - үлдэгдэл хүрэхгүй байна. Үлдэгдэл - " + a + " байна.", "Эмийн үлдэгдэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridViewSaleDetail.SetFocusedRowCellValue("Count", a);
            }
            gridViewSaleDetail.SetFocusedRowCellValue("SumPrice", Convert.ToDecimal(gridViewSaleDetail.GetFocusedRowCellValue("Count")) * Convert.ToDecimal(gridViewSaleDetail.GetFocusedRowCellValue("Price")));
        }

        private void gridViewDiscountSaleDetail_LostFocus(object sender, EventArgs e)
        {
            gridColumnCountDS.OptionsColumn.AllowEdit = false;
            gridColumnCountDS.OptionsColumn.AllowFocus = false;
            this.gridDiscountSaleDetail.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.gridRowDelete_KeyDown);
        }

        private void gridViewSaleDetail_LostFocus(object sender, EventArgs e)
        {
            gridColumnCountSale.OptionsColumn.AllowEdit = false;
            gridColumnCountSale.OptionsColumn.AllowFocus = false;
        }

        private bool payment_Sale(decimal total, int cardID, decimal paidTotal, decimal discountTotal)
        {
            string saleInvoiceNum = DateTime.Now.ToString("yyyyMMddhhmmss");
            String[] spPName = new String[] { "JorNum", "JorDate", "DoctorCipher", "CustomerID", 
                "SaleInvoiceNum", "SumPrice", "ActionDate", "SumDiscount", "UserID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.DateTime, SqlDbType.NVarChar, SqlDbType.Int, 
                SqlDbType.NVarChar, SqlDbType.Decimal, SqlDbType.DateTime, SqlDbType.Decimal, SqlDbType.Int };
            Object[] spPValue = new Object[] { txtJorNum.Text.Trim(), dateJorOgnoo.Text, txtDoctorNum.Text.Trim(), CustomerID, 
                saleInvoiceNum, total, DateTime.Now, txtNDToloh.Text.Trim(), DBRes.mUserID };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return false; }
            DBRes.DS.Dispose();
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDiscountSaleDetail.DataSource as DataTable).Copy());
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mDiscountSale_Pro", CommandType.StoredProcedure))
            {
                DBRes._FillTable("SELECT A.*,(B.Name)PrinterName,B.PaddingNum  FROM tSystemInfo A INNER JOIN tPrinter B ON(B.PrintID=A.PrinterID)", "SystemInfo");

                int printCount = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["Printcount"]);
                string printerName = DBRes.DS.Tables["SystemInfo"].Rows[0]["PrinterName"].ToString();
                Static.Margins = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaddingNum"]);

                Reports.rDiscountPosTalon talonReport = new Reports.rDiscountPosTalon();
                talonReport.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                talonReport.xrLastName.Text = talonReport.xrLastName.Text + " " + txtLastName.Text;
                talonReport.xrFirstName.Text = talonReport.xrFirstName.Text + " " + txtFirstName.Text;
                talonReport.xrRegNum.Text = talonReport.xrRegNum.Text + " " + btneditDiscountCustmorRegNum.Text;
                talonReport.xrJorNum.Text = talonReport.xrJorNum.Text + " " + txtJorNum.Text;
                talonReport.xrDoctorNum.Text = talonReport.xrDoctorNum.Text + " " + txtDoctorNum.Text;
                talonReport.DataSource = ds.Tables["DiscountSaleDetail"];
                talonReport.xrActionDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                talonReport.ShowPrintMarginsWarning = false;

                using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                {
                    if (talonReport == null) talonReport = new Reports.rDiscountPosTalon();
                    form2.PrintingSystem = talonReport.PrintingSystem;
                    talonReport.CreateDocument();
                    if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Нийгмийн даатгалруу явуулах)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            for (int i = 0; i < printCount; i++)
                            {
                                talonReport.Print(printerName);
                            }
                        }
                        catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудалаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                //my talon
                printCount = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["Printcount"]);
                printerName = DBRes.DS.Tables["SystemInfo"].Rows[0]["PrinterName"].ToString();
                Static.Margins = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaddingNum"]);

                Reports.rNormalPosTalon talonReportMy = new Reports.rNormalPosTalon();
                talonReportMy.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                talonReportMy.xrPhonenum.Text = "Утас: " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
                talonReportMy.xrTalonnum.Text = "№: " + saleInvoiceNum;
                talonReportMy.xrDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                talonReportMy.DataSource = ds.Tables[1];
                talonReportMy.xrSumTotal.Text = total.ToString("###,###,###,###,###.## ₮");
                talonReportMy.xrDiscountTotal.Text = discountTotal.ToString("###,###,###,###,###.## ₮");
                talonReportMy.xrPayTotal.Text = (Convert.ToDecimal(total) - Convert.ToDecimal(discountTotal)).ToString("###,###,###,###,###.## ₮");
                talonReportMy.xrPaidTotal.Text = paidTotal.ToString("###,###,###,###,###.## ₮");
                talonReportMy.xrOddMoney.Text = ((Convert.ToDecimal(total) - Convert.ToDecimal(discountTotal) - Convert.ToDecimal(paidTotal)) * -1).ToString("###,###,###,###,###.## ₮");
                talonReportMy.ShowPrintMarginsWarning = false;

                using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                {
                    if (talonReportMy == null) talonReportMy = new Reports.rNormalPosTalon();
                    form2.PrintingSystem = talonReportMy.PrintingSystem;
                    talonReportMy.CreateDocument();
                    if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            for (int i = 0; i < printCount; i++)
                            {
                                talonReportMy.Print(printerName);
                            }
                        }
                        catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудалаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                return true;
            }
            else return false;
        }

        private int checkMaxCount(int disDrugID)
        {
            DBRes._FillTable("SELECT * FROM tDiscountDrug WHERE DiscountDrugID=" + disDrugID, "DisDrugCheck");
            int maxPrice = Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count")) * Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("PriceND")) / Convert.ToInt32(DBRes.DS.Tables["DisDrugCheck"].Rows[0]["Package"]);
            if (Convert.ToInt32(DBRes.DS.Tables["DisDrugCheck"].Rows[0]["MaxSize"]) >= maxPrice)
                return Convert.ToInt32(gridViewDiscountSaleDetail.GetFocusedRowCellValue("Count"));
            else
            {
                XtraMessageBox.Show("Уг эмийн нэг удаадаа олгох тоо хэтэрсэн байна.", "Олгох тоо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Convert.ToInt32(DBRes.DS.Tables["DisDrugCheck"].Rows[0]["Package"]);
            }
        }

        private decimal UnitDisPrice(int disDrugID)
        {
            DBRes._FillTable("SELECT ROUND((Price/Package),0)UnitDisPrice FROM tDiscountDrug WHERE DiscountDrugID=" + disDrugID, "DisDrugUnitPrice");
            return Convert.ToDecimal(DBRes.DS.Tables["DisDrugUnitPrice"].Rows[0]["UnitDisPrice"]);
        }

        private decimal UnitDisCusPrice(int disDrugID)
        {
            DBRes._FillTable("SELECT ROUND((NDDiscountTotal/Package),0)UnitDisCusPrice FROM tDiscountDrug WHERE DiscountDrugID=" + disDrugID, "DisDrugUnitCusPrice");
            return Convert.ToDecimal(DBRes.DS.Tables["DisDrugUnitCusPrice"].Rows[0]["UnitDisCusPrice"]);
        }

        //private int DrugID(int DisDrugID)
        //{
        //    DBRes._FillTable("SELECT * FROM tDiscountDrugList WHERE DisDrugID=" + DisDrugID, "selectDrugID");
        //    return Convert.ToInt32(DBRes.DS.Tables["selectDrugID"].Rows[0]["DrugID"]);
        //}

        #region Add drug to list
        private void lookDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(lookDrug.EditValue) == 0) return;
                addSaleRow(2);
            }
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarCode.Text == String.Empty) return;
                addSaleRow(1);
            }
        }

        private void addSaleRow(int status)
        {
            //string selText = "";
            //string errorText = "";
            //string errorCapText = "";
            //string infoText;
            //string infoCapText = "Эмийн үлдэгдэл";
            //if (status == 1)
            //{
            //    selText = "BarCode1='" + txtBarCode.Text.Trim() + "'";
            //    errorText = txtBarCode.Text.Trim() + " - бар кодтой эм олдсонгүй.";
            //    errorCapText = "Бар кодоор эм хайх";
            //}
            //else if (status == 2)
            //{
            //    selText = "DrugID=" + lookDrug.EditValue;
            //    errorText = lookDrug.Text + " - эм олдсонгүй.";
            //    errorCapText = "Эмийн нэрээр хайх";
            //}
            //DataRow[] dr = DBRes.DS.Tables["DisDrug"].Select(selText);
            //if (dr.Length > 0)
            //{
            //    lookDrug.EditValue = dr[0]["DrugID"];
            //    infoText = lookDrug.Text + " - үлдэгдэл хүрэхгүй байна.";
            //    DataSet ds = new DataSet();
            //    ds.Tables.Add((gridDiscountSaleDetail.DataSource as DataTable).Copy());
            //    ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            //    DataRow[] drBal = ds.Tables["DiscountSaleDetail"].Select("DiscountDrugID=" + lookDrug.EditValue);
            //    int count = 0;
            //    bool addCount = false;
            //    if (drBal.Length > 0) { count = Convert.ToInt32(drBal[0]["Count"]); addCount = true; }
            //    int balance = PharmacyFun.balanceCheck(Convert.ToInt32(lookDrug.EditValue), Convert.ToInt32(1) + count);
            //    if (balance == -1)
            //    {
            //        if (ds.Tables["DiscountSaleDetail"].Rows.Count < 3)
            //        {
            //            if (addCount) { XtraMessageBox.Show("Уг эмнээс олгож болох дээд хэмжээнд хүрсэн тул нэмэх боломжгүй.", "Олголт", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //            else
            //            {
            //                ds.Tables["DiscountSaleDetail"].Rows.Add(
            //                    dr[0]["BarCode"].ToString(),
            //                    dr[0]["Name"].ToString(), 0, 0,
            //                    dr[0]["Package"],
            //                    dr[0]["DrugID"].ToString(),
            //                    Convert.ToDecimal(dr[0]["Price"]),
            //                    Convert.ToDecimal(1) * Convert.ToDecimal(dr[0]["Price"]),
            //                    dr[0]["DiscountDrugID"].ToString(),
            //                    dr[0]["PriceND"].ToString(),
            //                    Convert.ToDecimal(dr[0]["PriceND"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"]),
            //                    (Convert.ToDecimal(dr[0]["Price"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"])) -
            //                    (Convert.ToDecimal(dr[0]["PriceND"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"])),
            //                    dr[0]["NDDiscountTotal"].ToString()
            //                    );
            //                ds.Tables["SaleDetail"].Rows.Add(
            //                    0,
            //                    dr[0]["Package"],
            //                    Convert.ToDecimal(dr[0]["Price"]),
            //                    Convert.ToDecimal(dr[0]["Package"]) * Convert.ToDecimal(dr[0]["Price"]),
            //                    dr[0]["DrugID"].ToString(),
            //                    dr[0]["Name1"].ToString() + " - " + dr[0]["Size"].ToString()
            //                    );
            //            }
            //        }
            //        else XtraMessageBox.Show("Нэг жороор дээд тал нь 3н эм олгох боломжтой. Олголтонд 3н эм орсон байна.", "Олголт", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        gridDiscountSaleDetail.DataSource = ds.Tables["DiscountSaleDetail"];
            //        gridSaleDetail.DataSource = ds.Tables["SaleDetail"];
            //        txtBarCode.Text = String.Empty;
            //        lookDrug.EditValue = 0;
            //        //
            //        decimal sumPrice = 0;
            //        decimal NDToloh = 0;
            //        decimal DToloh = 0;
            //        for (int i = 0; i < ds.Tables["DiscountSaleDetail"].Rows.Count; i++)
            //        {
            //            sumPrice = sumPrice + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["PriceND"]);
            //            NDToloh = NDToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["NDDiscountTotal"]);
            //            DToloh = DToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["DisCusPrice"]);
            //        }
            //        txtSumPrice.Text = sumPrice.ToString("###,###,###,###,###.##");
            //        txtNDToloh.Text = NDToloh.ToString("###,###,###,###,###.##");
            //        txtDToloh.Text = DToloh.ToString("###,###,###,###,###.##");
            //    }
            //    else if (balance == -2) XtraMessageBox.Show(lookDrug.Text + " - гэсэн эмийн мэдээлэл олдсонгүй.", "Эмийн мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else XtraMessageBox.Show(infoText + " Үлдэгдэл - " + balance + " байна.", infoCapText, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else XtraMessageBox.Show(errorText, errorCapText, MessageBoxButtons.OK, MessageBoxIcon.Error);

            string selText = "";
            if (status == 1)
            {
                selText = "BarCode='" + txtBarCode.Text.Trim() + "'";
            }
            else if (status == 2)
            {
                selText = "DiscountDrugID=" + lookDrug.EditValue;
            }

            DataRow[] dr = DBRes.DS.Tables["DisDrug"].Select(selText);
            if (dr.Length > 0)
            {
                lookDrug.EditValue = dr[0]["DiscountDrugID"];
                DataSet ds = new DataSet();
                ds.Tables.Add((gridDiscountSaleDetail.DataSource as DataTable).Copy());
                DataRow[] drBal = ds.Tables["DiscountSaleDetail"].Select("DiscountDrugID=" + lookDrug.EditValue);
                bool addCount = false;
                if (drBal.Length > 0) { addCount = true; }
                if (ds.Tables["DiscountSaleDetail"].Rows.Count < 3)
                {
                    if (addCount) { XtraMessageBox.Show("Уг эмнээс олгож болох дээд хэмжээнд хүрсэн тул нэмэх боломжгүй.", "Олголт", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    else
                    {
                        ds.Tables["DiscountSaleDetail"].Rows.Add(
                            dr[0]["BarCode"].ToString(),
                            dr[0]["Name"].ToString(), 0, 0,
                            dr[0]["Package"],
                            0/*dr[0]["DrugID"].ToString()*/,
                            Convert.ToDecimal(dr[0]["Price"]),
                            Convert.ToDecimal(1) * Convert.ToDecimal(dr[0]["Price"]),
                            dr[0]["DiscountDrugID"].ToString(),
                            dr[0]["PriceND"].ToString(),
                            Convert.ToDecimal(dr[0]["PriceND"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"]),
                            (Convert.ToDecimal(dr[0]["Price"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"])) -
                            (Convert.ToDecimal(dr[0]["PriceND"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"])),
                            dr[0]["NDDiscountTotal"].ToString()
                            );
                    }
                }
                else { XtraMessageBox.Show("Нэг жороор дээд тал нь 3н эм олгох боломжтой. Олголтонд 3н эм орсон байна.", "Олголт", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                gridDiscountSaleDetail.DataSource = ds.Tables["DiscountSaleDetail"];
                //false
                lookDrug.Enabled = false;
                txtBarCode.Enabled = false;
                //true
                lookDrugMy.Enabled = true;
                txtBarCodeMy.Enabled = true;
                chbIsAll.Enabled = true;
                //fill
                DBRes._FillTable("SELECT B.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage "
                    + " FROM tDiscountDrugList A INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                    + " WHERE A.DisDrugID=" + dr[0]["DiscountDrugID"], "DrugLook");
                lookDrugMy.Properties.DataSource = DBRes.DS.Tables["DrugLook"];
                lookDrugMy.Properties.ValueMember = "DrugID";
                lookDrugMy.Properties.DisplayMember = "Name";
                //focus
                txtBarCodeMy.Focus();
            }
        }
        #endregion

        #region Add drug to list my
        private void lookDrugMy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(lookDrugMy.EditValue) == 0) return;
                addSaleRowMy(2);
            }
        }

        private void txtBarCodeMy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarCodeMy.Text == String.Empty) return;
                addSaleRowMy(1);
            }
        }

        private void addSaleRowMy(int status)
        {
            string selText = "";
            string errorText = "";
            string errorCapText = "";
            string infoText;
            string infoCapText = "Эмийн үлдэгдэл";
            if (status == 1)
            {
                selText = "BaarCode='" + txtBarCodeMy.Text.Trim() + "'";
                errorText = txtBarCodeMy.Text.Trim() + " - бар кодтой эм олдсонгүй.";
                errorCapText = "Бар кодоор эм хайх";
            }
            else if (status == 2)
            {
                selText = "DrugID=" + lookDrugMy.EditValue;
                errorText = lookDrugMy.Text + " - эм олдсонгүй.";
                errorCapText = "Эмийн нэрээр хайх";
            }
            DataRow[] dr = DBRes.DS.Tables["DrugLook"].Select(selText);
            if (dr.Length > 0)
            {
                lookDrugMy.EditValue = dr[0]["DrugID"];
                infoText = lookDrugMy.Text + " - үлдэгдэл хүрэхгүй байна.";
                DataSet ds = new DataSet();
                ds.Tables.Add((gridDiscountSaleDetail.DataSource as DataTable).Copy());
                ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
                DataRow[] drBal = ds.Tables["DiscountSaleDetail"].Select("DiscountDrugID=" + lookDrug.EditValue);
                int count = 0;
                if (drBal.Length > 0) { count = Convert.ToInt32(drBal[0]["Count"]); }
                decimal balance = PharmacyFun.balanceCheck(Convert.ToInt32(lookDrugMy.EditValue), count);
                if (balance == -1)
                {
                    //if (ds.Tables["DiscountSaleDetail"].Rows.Count < 3)
                    //{
                    //ds.Tables["DiscountSaleDetail"].Rows.Add(
                    //    dr[0]["BarCode"].ToString(),
                    //    dr[0]["Name"].ToString(), 0, 0,
                    //    dr[0]["Package"],
                    //    dr[0]["DrugID"].ToString(),
                    //    Convert.ToDecimal(dr[0]["Price"]),
                    //    Convert.ToDecimal(1) * Convert.ToDecimal(dr[0]["Price"]),
                    //    dr[0]["DiscountDrugID"].ToString(),
                    //    dr[0]["PriceND"].ToString(),
                    //    Convert.ToDecimal(dr[0]["PriceND"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"]),
                    //    (Convert.ToDecimal(dr[0]["Price"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"])) -
                    //    (Convert.ToDecimal(dr[0]["PriceND"]) - Convert.ToDecimal(dr[0]["NDDiscountTotal"])),
                    //    dr[0]["NDDiscountTotal"].ToString()
                    //    );
                    ds.Tables["SaleDetail"].Rows.Add(
                        0,
                        count,
                        Convert.ToDecimal(dr[0]["Price"]),
                        Convert.ToDecimal(count) * Convert.ToDecimal(dr[0]["Price"]),
                        dr[0]["DrugID"].ToString(),
                        dr[0]["NameSizePackage"].ToString(),
                        "Added"
                        );
                    //}
                    //else XtraMessageBox.Show("Нэг жороор дээд тал нь 3н эм олгох боломжтой. Олголтонд 3н эм орсон байна.", "Олголт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridSaleDetail.DataSource = ds.Tables["SaleDetail"];
                    //
                    for (int i = 0; i < ds.Tables["DiscountSaleDetail"].Rows.Count; i++)
                    {
                        if (ds.Tables["DiscountSaleDetail"].Rows[i]["DiscountDrugID"].ToString() == lookDrug.EditValue.ToString())
                        {
                            ds.Tables["DiscountSaleDetail"].Rows[i]["DrugID"] = lookDrugMy.EditValue;
                        }
                    }
                    gridDiscountSaleDetail.DataSource = ds.Tables["DiscountSaleDetail"];
                    //
                    txtBarCode.Text = String.Empty;
                    lookDrug.EditValue = 0;
                    //
                    decimal sumPrice = 0;
                    decimal NDToloh = 0;
                    decimal DToloh = 0;
                    for (int i = 0; i < ds.Tables["DiscountSaleDetail"].Rows.Count; i++)
                    {
                        sumPrice = sumPrice + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["PriceND"]);
                        NDToloh = NDToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["NDDiscountTotal"]);
                        DToloh = DToloh + Convert.ToDecimal(ds.Tables["DiscountSaleDetail"].Rows[i]["DisCusPrice"]);
                    }
                    txtSumPrice.Text = sumPrice.ToString("###,###,###,###,###.##");
                    txtNDToloh.Text = NDToloh.ToString("###,###,###,###,###.##");
                    txtDToloh.Text = DToloh.ToString("###,###,###,###,###.##");
                    //true
                    lookDrug.Enabled = true;
                    txtBarCode.Enabled = true;
                    //false
                    lookDrugMy.Enabled = false;
                    txtBarCodeMy.Enabled = false;
                    chbIsAll.Enabled = false;
                    //clear
                    lookDrug.EditValue = 0;
                    lookDrugMy.EditValue = 0;
                    txtBarCode.Text = "";
                    txtBarCodeMy.Text = "";
                    //focus
                    lookDrug.Focus();
                }
                else if (balance == -2) XtraMessageBox.Show(lookDrugMy.Text + " - гэсэн эмийн мэдээлэл олдсонгүй.", "Эмийн мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else XtraMessageBox.Show(infoText + " Үлдэгдэл - " + balance + " байна.", infoCapText, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else XtraMessageBox.Show(errorText, errorCapText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        private void chbIsAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsAll.Checked)
            {
                DBRes._FillTable("SELECT B.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage FROM tDrug B", "DrugLook");
                lookDrugMy.Properties.DataSource = DBRes.DS.Tables["DrugLook"];
                lookDrugMy.Properties.ValueMember = "DrugID";
                lookDrugMy.Properties.DisplayMember = "Name";
            }
            else
            {
                DBRes._FillTable("SELECT B.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage "
                    + " FROM tDiscountDrugList A INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                    + " WHERE A.DisDrugID=" + lookDrug.EditValue, "DrugLook");
                lookDrugMy.Properties.DataSource = DBRes.DS.Tables["DrugLook"];
                lookDrugMy.Properties.ValueMember = "DrugID";
                lookDrugMy.Properties.DisplayMember = "Name";
            }
        }

    }
}
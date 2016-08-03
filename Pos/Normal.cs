using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Pharmacy.Codes;

namespace Pharmacy.Pos
{
    public partial class Normal : DevExpress.XtraEditors.XtraForm
    {
        int activeBox = 0;

        private PosApi.Result resultData;

        bool nuatTulugch;
        bool nuatOrson;
        decimal totalAmount;
        double stockVat;
        int billType = 1;
        string buyerTTD = "";
        string buyerName = "";

        public Normal()
        {
            InitializeComponent();
        }

        private void Normal_Load(object sender, EventArgs e)
        {
            barServer.Caption = "Серверийн нэр: " + DBRes.mServer.ToString();
            barDB.Caption = "Мэдээлэлийн бааз: " + DBRes.mDatabase.ToString();
            barUser.Caption = "Хэрэглэгч: " + DBRes.mUser.ToString();
            barDate.Caption = "Систем огноо: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

            timer1.Start();

            DBRes._FillTable("SELECT A.SaleDetailID,A.Count,A.Price,A.SumPrice, "
                + " A.DrugID,(B.Name + ' - '+B.Size)NameSize,'' AS Status FROM tSaleDetail A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) WHERE A.DrugID=-1", "SaleDetail");
            gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetail"];

            DBRes._FillTable("SELECT *,(Name+' '+ISNULL(Size,'')+' '+ISNULL(Package,''))NameSizePackage FROM tDrug", "Drug");
            lookDrug.Properties.DataSource = DBRes.DS.Tables["Drug"];
            lookDrug.Properties.ValueMember = "DrugID";
            lookDrug.Properties.DisplayMember = "NameSizePackage";

            nuatTulugch = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["NuatTulugch"]);
            nuatOrson = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["NuatOrson"]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barDate.Caption = "Систем огноо: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        #region F1 function's
        private void Normal_KeyDown(object sender, KeyEventArgs e)
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
            lookDrug.SelectAll();
            lookDrug.Focus();
        }
        private void btnF2_Click(object sender, EventArgs e)
        {
            txtBarCode.SelectAll();
            txtBarCode.Focus();
        }
        private void btnF3_Click(object sender, EventArgs e)
        {
            txtCount.SelectAll();
            txtCount.Focus();
        }
        private void btnF4_Click(object sender, EventArgs e)
        {
            Forms.DrugList druglist = new Forms.DrugList();
            druglist.ShowInTaskbar = false;
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
            Forms.SaleDetail saledetail = new Forms.SaleDetail();
            saledetail.dateStart.Enabled = false;
            saledetail.dateEnd.Enabled = false;
            saledetail.lookPosUser.Enabled = false;
            saledetail.btnSearch.Enabled = false;
            DBRes._FillTable("SELECT A.*,B.UserID,(C.Name + ' - ' + ISNULL(C.Size,''))NameSize FROM tSaleDetail A "
                + " INNER JOIN tSaleInvoice B WITH(NOLOCK) ON(B.SaleInvoiceID=A.SaleInvoiceID) "
                + " INNER JOIN tDrug C WITH(NOLOCK) ON(C.DrugID=A.DrugID) "
                + " WHERE A.ActionDate>='" + DateTime.Now.ToString("yyyy-MM-dd")
                + " 00:00:00' AND A.ActionDate<='" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' "
                + " AND B.UserID=" + DBRes.mUserID + " ORDER BY SaleDetailID DESC", "SaleDetail");
            saledetail.gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetail"];
            saledetail.ShowDialog();
        }
        private void btnF6_Click(object sender, EventArgs e)
        {
            txtBarCode.Focus();
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count > 0)
            {
                decimal total = 0;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    total = total + Convert.ToDecimal(ds.Tables[0].Rows[i]["SumPrice"]);
                }
                Pos.Payment normalpayment = new Payment();
                normalpayment.txtTotal.Text = total.ToString();
                if (normalpayment.ShowDialog() == DialogResult.OK)
                {
                    decimal paidTotal = Convert.ToDecimal(normalpayment.txtPaidTotal.Text);
                    int cardID = normalpayment.CardID;
                    decimal discountTotal = Convert.ToDecimal(normalpayment.txtDiscountTotal.Text);
                    decimal cashAmount = Convert.ToDecimal(normalpayment.txtCashAmount.Text);
                    decimal nonCashAmount = Convert.ToDecimal(normalpayment.txtNonCashAmount.Text);
                    decimal vat = Convert.ToDecimal(normalpayment.txtNUAT.Text);
                    decimal oddMoney = normalpayment.txtOddMoney.Text == "" ? 0 : Convert.ToDecimal(normalpayment.txtOddMoney.Text);
                    if (Convert.ToInt32(normalpayment.rGrpBillType.EditValue) == 2)
                    {
                        billType = 2;
                        buyerTTD = normalpayment.txtBuyerTTD.Text;
                        buyerName = normalpayment.txtBuyerName.Text;
                    }
                    if (payment_Sale(total, cardID, paidTotal, discountTotal, cashAmount, nonCashAmount, vat, oddMoney))
                        saleClear(sender, e);
                }
            }
        }
        private void btnF7_Click(object sender, EventArgs e)
        {
            gridColumnCount.OptionsColumn.AllowEdit = true;
            gridColumnCount.OptionsColumn.AllowFocus = true;
            gridSaleDetail.Focus();
        }
        private void btnF8_Click(object sender, EventArgs e)
        {
            this.gridSaleDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridRowDelete_KeyDown);
            gridSaleDetail.Focus();
        }
        private void btnF9_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Борлуулалтын хэсгийн мэдээллийг цэвэрлэх гэж байна. Цэвэрлэх үү?", "Цэвэрлэх", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    saleClear(sender, e);
            }
            else
                saleClear(sender, e);
        }
        private void btnF10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void saleClear(object sender, EventArgs e)
        {
            lookDrug.EditValue = 0;
            txtBarCode.Text = String.Empty;
            txtCount.Text = "1";
            txtBalance.Text = String.Empty;
            txtPrice.Text = String.Empty;
            Normal_Load(sender, e);
        }

        private void lookDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(lookDrug.EditValue) != 0)
                {
                    if (lookDrug.Text == String.Empty)
                    {
                        lookDrug.EditValue = 0;
                        txtBarCode.Text = String.Empty;
                        txtCount.Text = "1";
                        txtPrice.Text = String.Empty;
                        txtBalance.Text = String.Empty;
                        return;
                    }
                    DataRow[] dr = DBRes.DS.Tables["Drug"].Select("DrugID=" + lookDrug.EditValue);
                    txtBarCode.Text = dr[0]["BaarCode"].ToString();
                    txtPrice.Text = Convert.ToDecimal(dr[0]["Price"]).ToString("###,###,###,###,###.##");
                    txtBalance.Text = PharmacyFun.balanceCheck(Convert.ToInt32(lookDrug.EditValue), 9999999).ToString();
                    activeBox = 1;
                    txtCount.Focus();
                }
            }
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarCode.Text == String.Empty)
                {
                    lookDrug.EditValue = 0;
                    txtBarCode.Text = String.Empty;
                    txtCount.Text = "1";
                    txtPrice.Text = String.Empty;
                    txtBalance.Text = String.Empty;
                    return;
                }
                if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString("yyyy-MM-dd hh:ss:mm tt"))) return;
                if (txtBarCode.Text.Trim() == String.Empty) { txtBarCode.Focus(); txtBarCode.SelectAll(); return; }
                if (txtCount.Text.Trim() == String.Empty) { txtCount.Focus(); txtCount.SelectAll(); return; }
                DataRow[] dr = DBRes.DS.Tables["Drug"].Select("BaarCode='" + txtBarCode.Text.Trim() + "'");
                if (dr.Length == 0) { XtraMessageBox.Show(txtBarCode.Text.Trim() + " - бар кодтой эм олдсонгүй.", "Бар кодоор эм хайх", MessageBoxButtons.OK, MessageBoxIcon.Error); txtBarCode.SelectAll(); return; }
                lookDrug.EditValue = Convert.ToInt32(dr[0]["DrugID"]);
                txtPrice.Text = Convert.ToDecimal(dr[0]["Price"]).ToString("###,###,###,###,###.##");
                txtBalance.Text = PharmacyFun.balanceCheck(Convert.ToInt32(dr[0]["DrugID"]), 9999999).ToString();
                activeBox = 2;
                txtCount.Focus();
            }
        }

        private void txtCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString("yyyy-MM-dd hh:ss:mm tt"))) return;
                if (Convert.ToInt32(lookDrug.EditValue) == 0) { lookDrug.Focus(); lookDrug.SelectAll(); return; }
                if (txtCount.Text.Trim() == String.Empty) { txtCount.Focus(); txtCount.SelectAll(); return; }
                bool a = addSaleRow();
                if (!a) { txtCount.Focus(); txtCount.SelectAll(); }
                else if (activeBox == 1)
                    lookDrug.Focus();
                else if (activeBox == 2)
                    txtBarCode.Focus();
            }
        }

        private bool addSaleRow()
        {
            string selText = "";
            string errorText = "";
            string errorCapText = "";
            string infoText;
            string infoCapText = "Эмийн үлдэгдэл";
            //
            selText = "DrugID=" + lookDrug.EditValue;
            errorText = lookDrug + " - эм олдсонгүй.";
            errorCapText = "Эмийн нэрээр хайх";
            //
            DataRow[] dr = DBRes.DS.Tables["Drug"].Select(selText);
            if (dr.Length > 0)
            {
                lookDrug.EditValue = dr[0]["DrugID"];
                infoText = lookDrug.Text + " - үлдэгдэл хүрэхгүй байна.";
                DataSet ds = new DataSet();
                ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
                DataRow[] drBal = ds.Tables["SaleDetail"].Select("DrugID=" + lookDrug.EditValue);
                decimal count = 0;
                bool addCount = false;
                if (drBal.Length > 0) { count = Convert.ToDecimal(drBal[0]["Count"]); addCount = true; }
                decimal balance = PharmacyFun.balanceCheck(Convert.ToInt32(lookDrug.EditValue), Convert.ToDecimal(txtCount.Text) + count);
                if (balance == -1)
                {
                    if (addCount)
                    {
                        for (int i = 0; i < ds.Tables["SaleDetail"].Rows.Count; i++)
                        {
                            if (ds.Tables["SaleDetail"].Rows[i]["DrugID"].ToString() == lookDrug.EditValue.ToString())
                            {
                                ds.Tables["SaleDetail"].Rows[i]["Count"] = Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["Count"]) + Convert.ToDecimal(txtCount.Text);
                                ds.Tables["SaleDetail"].Rows[i]["SumPrice"] = Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["Count"]) * Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["Price"]);
                            }
                        }
                    }
                    else
                    {
                        ds.Tables["SaleDetail"].Rows.Add(0,
                            txtCount.Text.Trim(),
                            Convert.ToDecimal(dr[0]["Price"]),
                            Convert.ToDecimal(txtCount.Text) * Convert.ToDecimal(dr[0]["Price"]),
                            dr[0]["DrugID"].ToString(),
                            dr[0]["Name"].ToString() + " " + dr[0]["Size"].ToString() + " " + dr[0]["Package"].ToString(),
                            "Added"
                            );
                    }
                    if (PharmacyFun.LogicControlsPermission())
                    {
                        decimal sprice = 0;
                        for (int i = 0; i < ds.Tables["SaleDetail"].Rows.Count; i++)
                        {
                            sprice = sprice + (Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["Price"]) * Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["Count"]));
                        }
                        LogicControls(sprice.ToString());
                    }
                    gridSaleDetail.DataSource = ds.Tables["SaleDetail"];
                    txtCount.Text = "1";
                    txtBarCode.Text = String.Empty;
                    lookDrug.EditValue = 0;
                    txtBalance.Text = String.Empty;
                    txtPrice.Text = String.Empty;
                    return true;
                }
                else if (balance == -2) { XtraMessageBox.Show(lookDrug.Text + " - гэсэн эмийн мэдээлэл олдсонгүй.", "Эмийн мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
                else { XtraMessageBox.Show(infoText + " Үлдэгдэл - " + balance + " байна.", infoCapText, MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            }
            else { XtraMessageBox.Show(errorText, errorCapText, MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
        }

        private void Normal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void gridViewSaleDetail_LostFocus(object sender, EventArgs e)
        {
            gridColumnCount.OptionsColumn.AllowEdit = false;
            gridColumnCount.OptionsColumn.AllowFocus = false;
            this.gridSaleDetail.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.gridRowDelete_KeyDown);
        }

        private void gridRowDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataRow[] rows;
                if (gridViewSaleDetail != null && gridViewSaleDetail.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Мөр устгах гэж байна. Устгах уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewSaleDetail.SelectedRowsCount];
                        for (int i = 0; i < gridViewSaleDetail.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewSaleDetail.GetDataRow(gridViewSaleDetail.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            row.Delete();
                        }
                    }
                }
                txtBarCode.Focus();
            }
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

        private bool payment_Sale(decimal total, int cardID, decimal paidTotal, decimal discountTotal, decimal cashAmount, 
            decimal nonCashAmount, decimal vat, decimal oddMoney)
        {
            if (!nuatTulugch)
                totalAmount = total;
            if (nuatTulugch && nuatOrson)
                totalAmount = total;
            if (nuatTulugch && !nuatOrson)
                totalAmount = total + vat;            

            var data = new PosApi.BillData();

            data.amount = String.Format("{0:0.00}", totalAmount);
            data.vat = String.Format("{0:0.00}", vat);
            data.cashAmount = String.Format("{0:0.00}", cashAmount - oddMoney);
            data.nonCashAmount = String.Format("{0:0.00}", nonCashAmount);
            data.cityTax = "0.00";
            data.districtCode = DBRes.DS.Tables["SystemInfo"].Rows[0]["districtNo"].ToString();
            data.posNo = DBRes.DS.Tables["SystemInfo"].Rows[0]["posNo"].ToString();

            if (billType == 2)
            {
                data.customerNo = buyerTTD;
                data.customerName = buyerName;
                data.billType = billType.ToString();
            }

            var lstBillStock = new List<PosApi.BillDetail>();

            var table = (gridSaleDetail.DataSource as DataTable).Copy();

            foreach (DataRow row in table.Rows)
            {
                var stock = new PosApi.BillDetail();
                stock.code = "";
                stock.name = row["NameSize"].ToString();
                stock.measureUnit = "Ширхэг";
                stock.qty = row["Count"].ToString();
                stock.unitPrice = String.Format("{0:0.00}", row["Price"]);
                stock.totalAmount = String.Format("{0:0.00}", row["SumPrice"]);
                stock.cityTax = "0.00";

                if (nuatTulugch && nuatOrson)
                    stockVat = (Convert.ToDouble(row["SumPrice"]) / 1.1) * 0.1;
                else if (nuatTulugch && !nuatOrson)
                    stockVat = Convert.ToDouble(row["SumPrice"]) * 0.1;
                else stockVat = 0;

                stock.vat = String.Format("{0:0.00}", stockVat);
                stock.barCode = "";

                lstBillStock.Add(stock);
            }

            if (lstBillStock.Count == 0)
            {
                lstBillStock = null;
            }
            data.stocks = lstBillStock;

            var json = new JavaScriptSerializer().Serialize(data);
            var result = Program.put(json);
            this.resultData = new JavaScriptSerializer().Deserialize<PosApi.Result>(result);

            if ("True".Equals(this.resultData.success))
            {
                string saleInvoiceNum = DateTime.Now.ToString("yyyyMMddhhmmss");
                String[] spPName = new String[] { "SaleInvoiceID", "SaleInvoiceNum", "SumPrice", "ActionDate", "CardID", "SumDiscount", "UserID", "ActionType", "Status", "billNo" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.Decimal, SqlDbType.NVarChar, SqlDbType.Int, SqlDbType.Decimal, SqlDbType.Int, SqlDbType.TinyInt, SqlDbType.TinyInt, SqlDbType.NVarChar };
                Object[] spPValue = new Object[] { 0, saleInvoiceNum, total, this.resultData.date, cardID, discountTotal, DBRes.mUserID, 1, 1, this.resultData.billId };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return false; }
                DBRes.DS.Dispose();
                DataSet ds = new DataSet();
                ds.Tables.Add((gridSaleDetail.DataSource as DataTable).Copy());
                System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
                DBRes.sql_cmd.Parameters.Add(parameter);
                if (DBRes._ParamProcedure("mSale_ProNew", CommandType.StoredProcedure))
                {
                    DBRes._FillTable("SELECT A.*,(B.Name)PrinterName,B.PaddingNum  FROM tSystemInfo A INNER JOIN tPrinter B ON(B.PrintID=A.PrinterID)", "SystemInfo");
                    int printCount = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["Printcount"]);
                    string printerName = DBRes.DS.Tables["SystemInfo"].Rows[0]["PrinterName"].ToString();
                    Static.Margins = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaddingNum"]);

                    if (Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaperType"]) == 1 && billType == 1)
                    {
                        Reports.Bill2Customer talonReport = new Reports.Bill2Customer();
                        talonReport.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                        talonReport.xrPhonenum.Text = "Утас: " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
                        talonReport.xrTalonnum.Text = "№: " + saleInvoiceNum;
                        talonReport.xrDate.Text = this.resultData.date;//DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                        talonReport.lblTTD.Text = this.resultData.merchantId;
                        talonReport.lblDDTD.Text = this.resultData.billId;

                        talonReport.DataSource = ds.Tables[0];

                        talonReport.xrSumTotal.Text = total.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrDiscountTotal.Text = discountTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrNuatDun.Text = String.Format("{0:0.00} ₮", this.resultData.vat);
                        talonReport.xrPayTotal.Text = String.Format("{0:0.00} ₮", this.resultData.amount);//(Convert.ToDecimal(total) - Convert.ToDecimal(discountTotal)).ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrCashAmount.Text = String.Format("{0:0.00} ₮", cashAmount);
                        talonReport.xrNonCashAmount.Text = String.Format("{0:0.00} ₮", this.resultData.nonCashAmount);
                        talonReport.xrPaidTotal.Text = paidTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrOddMoney.Text = (oddMoney).ToString("###,###,###,###,###.00 ₮");

                        talonReport.lblLotteryNum.Text = this.resultData.lottery;
                        talonReport.picBoxQrCode.Image = qrCode();
                        talonReport.ShowPrintMarginsWarning = false;

                        using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                        {
                            if (talonReport == null) talonReport = new Reports.Bill2Customer();//Reports.rNormalPosTalon();
                            form2.PrintingSystem = talonReport.PrintingSystem;
                            talonReport.CreateDocument();
                            if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return true;

                            try
                            {
                                for (int i = 0; i < printCount; i++)
                                {
                                    talonReport.Print(printerName);
                                }
                            }
                            catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудлаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
                        }
                    }

                    else if (Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaperType"]) == 1 && billType == 2)
                    {
                        Reports.bill2Company talonReport = new Reports.bill2Company();
                        talonReport.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                        talonReport.xrPhonenum.Text = "Утас: " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
                        talonReport.xrTalonnum.Text = "№: " + saleInvoiceNum;
                        talonReport.xrDate.Text = this.resultData.date;

                        talonReport.lblTTD.Text = this.resultData.merchantId;
                        talonReport.lblDDTD.Text = this.resultData.billId;
                        talonReport.xrBuyerTTD.Text = this.resultData.customerNo;
                        talonReport.xrBuyerName.Text = this.resultData.customerName;

                        talonReport.DataSource = ds.Tables[0];

                        talonReport.xrSumTotal.Text = total.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrDiscountTotal.Text = discountTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrNuatDun.Text = String.Format("{0:0.00} ₮", this.resultData.vat);
                        talonReport.xrPayTotal.Text = String.Format("{0:0.00} ₮", this.resultData.amount);//(Convert.ToDecimal(total) - Convert.ToDecimal(discountTotal)).ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrCashAmount.Text = String.Format("{0:0.00} ₮", cashAmount);
                        talonReport.xrNonCashAmount.Text = String.Format("{0:0.00} ₮", this.resultData.nonCashAmount);
                        talonReport.xrPaidTotal.Text = paidTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrOddMoney.Text = (oddMoney).ToString("###,###,###,###,###.00 ₮");

                        talonReport.picBoxQrCode.Image = qrCode();
                        talonReport.ShowPrintMarginsWarning = false;

                        using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                        {
                            if (talonReport == null) talonReport = new Reports.bill2Company();
                            form2.PrintingSystem = talonReport.PrintingSystem;
                            talonReport.CreateDocument();
                            if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return true;

                            try
                            {
                                for (int i = 0; i < printCount; i++)
                                {
                                    talonReport.Print(printerName);
                                }
                            }
                            catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудлаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
                        }
                    }

                    else if (Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaperType"]) == 2 && billType == 1)
                    {
                        Reports.bill2Customer80 talonReport = new Reports.bill2Customer80();

                        talonReport.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                        talonReport.xrPhonenum.Text = "Утас: " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
                        talonReport.xrTalonnum.Text = "№: " + saleInvoiceNum;
                        talonReport.xrDate.Text = this.resultData.date;//DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                        talonReport.lblTTD.Text = this.resultData.merchantId;
                        talonReport.lblDDTD.Text = this.resultData.billId;

                        talonReport.DataSource = ds.Tables[0];
                        talonReport.xrSumTotal.Text = total.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrDiscountTotal.Text = discountTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrNuatDun.Text = String.Format("{0:0.00} ₮", this.resultData.vat);
                        talonReport.xrPayTotal.Text = String.Format("{0:0.00} ₮", this.resultData.amount);//(Convert.ToDecimal(total) - Convert.ToDecimal(discountTotal)).ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrCashAmount.Text = String.Format("{0:0.00} ₮", cashAmount);
                        talonReport.xrNonCashAmount.Text = String.Format("{0:0.00} ₮", this.resultData.nonCashAmount);
                        talonReport.xrPaidTotal.Text = paidTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrOddMoney.Text = (oddMoney).ToString("###,###,###,###,###.00 ₮");

                        talonReport.lblLotteryNum.Text = this.resultData.lottery;

                        talonReport.picBoxQrCode.Image = qrCode();

                        talonReport.ShowPrintMarginsWarning = false;

                        using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                        {
                            if (talonReport == null) talonReport = new Reports.bill2Customer80();//Reports.rNormalPosTalon();
                            form2.PrintingSystem = talonReport.PrintingSystem;
                            talonReport.CreateDocument();
                            if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return true;

                            try
                            {
                                for (int i = 0; i < printCount; i++)
                                {
                                    talonReport.Print(printerName);
                                }
                            }
                            catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудлаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
                        }
                    }
                    else
                    {
                        Reports.bill2Company80 talonReport = new Reports.bill2Company80();
                        talonReport.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                        talonReport.xrPhonenum.Text = "Утас: " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
                        talonReport.xrTalonnum.Text = "№: " + saleInvoiceNum;
                        talonReport.xrDate.Text = this.resultData.date;

                        talonReport.lblTTD.Text = this.resultData.merchantId;
                        talonReport.lblDDTD.Text = this.resultData.billId;
                        talonReport.xrBuyerTTD.Text = this.resultData.customerNo;
                        talonReport.xrBuyerName.Text = this.resultData.customerName;

                        talonReport.DataSource = ds.Tables[0];

                        talonReport.xrSumTotal.Text = total.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrDiscountTotal.Text = discountTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrNuatDun.Text = String.Format("{0:0.00} ₮", this.resultData.vat);
                        talonReport.xrPayTotal.Text = String.Format("{0:0.00} ₮", this.resultData.amount);//(Convert.ToDecimal(total) - Convert.ToDecimal(discountTotal)).ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrCashAmount.Text = String.Format("{0:0.00} ₮", cashAmount);
                        talonReport.xrNonCashAmount.Text = String.Format("{0:0.00} ₮", this.resultData.nonCashAmount);
                        talonReport.xrPaidTotal.Text = paidTotal.ToString("###,###,###,###,###.00 ₮");
                        talonReport.xrOddMoney.Text = (oddMoney).ToString("###,###,###,###,###.00 ₮");

                        talonReport.picBoxQrCode.Image = qrCode();
                        talonReport.ShowPrintMarginsWarning = false;

                        using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                        {
                            if (talonReport == null) talonReport = new Reports.bill2Company80();
                            form2.PrintingSystem = talonReport.PrintingSystem;
                            talonReport.CreateDocument();
                            if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return true;

                            try
                            {
                                for (int i = 0; i < printCount; i++)
                                {
                                    talonReport.Print(printerName);
                                }
                            }
                            catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудлаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
                        }
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show(resultData.message);
                return false;
            }
        }

        private void LogicControls(string line)
        {
            System.IO.Ports.SerialPort serialPort = new System.IO.Ports.SerialPort();
            if (serialPort is System.IO.Ports.SerialPort)
            {
                serialPort.PortName = "COM1";
                serialPort.DataBits = 8;
                serialPort.Parity = System.IO.Ports.Parity.None;
                serialPort.StopBits = System.IO.Ports.StopBits.One;
                serialPort.BaudRate = 9600;
                try
                {
                    if (!serialPort.IsOpen)
                        serialPort.Open();
                    serialPort.Write("\r\n");
                    serialPort.Write(SelLCText() + "\r\n");
                    serialPort.Write("Sum price: " + line);
                }
                catch (Exception exc) { XtraMessageBox.Show(exc.Message); }
                finally { if (serialPort.IsOpen)serialPort.Close(); }
            }
        }

        private string SelLCText()
        {
            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");
            return DBRes.DS.Tables["SystemInfo"].Rows[0]["LCText"].ToString();
        }

        private Bitmap qrCode()
        {
            ZXing.IBarcodeWriter writer = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    Width = 150,
                    Height = 150
                }
            };
            var dataQr = writer.Write(resultData.qrData);
            var barcodeBitmap = new Bitmap(dataQr, new Size(150, 150));

            return barcodeBitmap;
        }
    }
}
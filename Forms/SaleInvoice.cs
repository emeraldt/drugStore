using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Pharmacy.Forms
{
    public partial class SaleInvoice : DevExpress.XtraEditors.XtraForm
    {
        private int selectType = 0;

        public SaleInvoice()
        {
            InitializeComponent();
        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(cbSelect, "Сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");

            DBRes._FillTable("SELECT * FROM tUsers WHERE GroupID=3", "Users");
            lookPosUser.Properties.DataSource = DBRes.DS.Tables["Users"];
            lookPosUser.Properties.ValueMember = "UserID";
            lookPosUser.Properties.DisplayMember = "Firstname";
        }

        private void SaleInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void SaleInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._saleinvoice = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;

            string wText = "";
            if (cbSelect.SelectedIndex == 2) { wText = "AND A.Status=2"; selectType = 2; }
            else if (cbSelect.SelectedIndex == 1) { wText = " AND A.Status=1 "; selectType = 1; }
            else if (cbSelect.SelectedIndex == 3) { wText = " AND A.Status=3 "; selectType = 3; }
            else { wText = ""; selectType = 0; }
            if (Convert.ToDateTime(dateStart.Text) > Convert.ToDateTime(dateEnd.Text))
            {
                XtraMessageBox.Show("Хүртэлх огноо эхлэх огнооноос бага байж болохгүй.", "Огноо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PharmacyFun._checkAccountingPeriod(dateStart.Text.Trim() + " 00:00:00")) return;
            string cmdText = "SELECT ROW_NUMBER() OVER(ORDER BY A.SaleInvoiceID ASC) AS RowNum,A.*,B.Firstname FROM tSaleInvoice A "
                + " INNER JOIN tUsers B ON(B.UserID=A.UserID) "
                + " WHERE A.ActionDate>='" + dateStart.Text.Trim() + " 00:00:00' AND "
                + " A.ActionDate<='" + dateEnd.Text.Trim() + " 23:59:59' " + wText;
            if (Convert.ToInt32(lookPosUser.EditValue) != 0)
                cmdText = cmdText + " AND B.UserID=" + lookPosUser.EditValue;
            DBRes._FillTable(cmdText, "SaleInvoiceView");
            gridSaleInvoice.DataSource = DBRes.DS.Tables["SaleInvoiceView"];
        }

        private int RowID()
        {
            int SaleInvoiceID = 0;
            if (gridViewSaleInvoice == null && gridViewSaleInvoice.SelectedRowsCount == 0) return 0;
            DataRow[] rows = new DataRow[gridViewSaleInvoice.SelectedRowsCount];
            for (int i = 0; i < gridViewSaleInvoice.SelectedRowsCount; i++)
            {
                rows[i] = gridViewSaleInvoice.GetDataRow(gridViewSaleInvoice.GetSelectedRows()[i]);
            }
            foreach (DataRow row in rows)
            {
                if (row == null) return 0;
                SaleInvoiceID = Convert.ToInt32(row["SaleInvoiceID"].ToString());
            }
            return SaleInvoiceID;
        }

        private void gridSaleInvoice_DoubleClick(object sender, EventArgs e)
        {
            int rowID = RowID();
            if (rowID == 0) return;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.SaleDetailID ASC) AS RowNum, "
                + " A.*,(B.Name +' - '+ ISNULL(B.Size,''))NameSize FROM tSaleDetail A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " WHERE A.SaleInvoiceID=" + rowID, "SaleDetailView");
            gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetailView"];
        }

        private void barEditSaleInvoice_Click(object sender, EventArgs e)
        {
            if (selectType == 2 || selectType == 3) { XtraMessageBox.Show("Хөнгөлөлттэй эмийн борлуулалттэй холбогдсон талон засварлах боломжгүй.", "Талон засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!Codes.PharmacyFun._checkPermission(83)) return;
            SaleTalonEdit saletalonedit = new SaleTalonEdit();
            saletalonedit.SaleInvoiceID = RowID();
            if (saletalonedit.ShowDialog() == DialogResult.OK)
                btnView_Click(sender, e);
        }

        private void barDeleteSaleInvoice_Click(object sender, EventArgs e)
        {
            if (selectType == 2 || selectType == 3) { XtraMessageBox.Show("Хөнгөлөлттэй эмийн борлуулалттэй холбогдсон талон устгах боломжгүй.", "Талон устгах", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!Codes.PharmacyFun._checkPermission(75)) return;
            if (XtraMessageBox.Show("Ут талоныг устгах гэж байгаадаа итгэлтэй байна уу?", "Талон устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowID = RowID();
                if (rowID == 0) return;
                String[] spPName = new String[] { "SaleInvoiceID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                Object[] spPValue = new Object[] { RowID() };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("DELETE FROM tSaleDetail WHERE SaleInvoiceID=@SaleInvoiceID"
                    + " DELETE FROM tSaleInvoice WHERE SaleInvoiceID=@SaleInvoiceID", CommandType.Text))
                {
                    btnView_Click(sender, e);
                    gridSaleInvoice_DoubleClick(sender, e);
                }
            }
        }

        private void barTalonRePrint_Click(object sender, EventArgs e)
        {
            if (selectType == 3) { XtraMessageBox.Show("Уг талоныг нөхөж хэвлэх боломжгүй.", "Талон нөхөж хэвлэх", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string SaleInvoiceNum = "";
            if (gridViewSaleInvoice == null && gridViewSaleInvoice.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewSaleInvoice.SelectedRowsCount];
            for (int i = 0; i < gridViewSaleInvoice.SelectedRowsCount; i++)
            {
                rows[i] = gridViewSaleInvoice.GetDataRow(gridViewSaleInvoice.GetSelectedRows()[i]);
            }
            int SaleInvoiceID = 0;
            DBRes._FillTable("SELECT A.*,(B.Name)PrinterName,B.PaddingNum  FROM tSystemInfo A INNER JOIN tPrinter B ON(B.PrintID=A.PrinterID)", "SystemInfo");

            int printCount = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["Printcount"]);
            string printerName = DBRes.DS.Tables["SystemInfo"].Rows[0]["PrinterName"].ToString();
            Static.Margins = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaddingNum"]);

            Reports.rNormalPosTalon talonReport = new Reports.rNormalPosTalon();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                SaleInvoiceID = Convert.ToInt32(row["SaleInvoiceID"]);
                talonReport.xrTalonnum.Text = "№: " + row["SaleInvoiceNum"];
                talonReport.xrSumTotal.Text = Convert.ToDecimal(row["SumPrice"]).ToString("###,###,###,###,###.## ₮");
                talonReport.xrDiscountTotal.Text = Convert.ToDecimal(row["SumDiscount"]).ToString("###,###,###,###,###.## ₮");
                talonReport.xrPayTotal.Text = (Convert.ToDecimal(row["SumPrice"]) - Convert.ToDecimal(row["SumDiscount"])).ToString("###,###,###,###,###.## ₮");
                talonReport.xrPaidTotal.Text = (Convert.ToDecimal(row["SumPrice"]) - Convert.ToDecimal(row["SumDiscount"])).ToString("###,###,###,###,###.## ₮");
                talonReport.xrOddMoney.Text = (0).ToString("###,###,###,###,###.## ₮");
                //
                SaleInvoiceNum = row["SaleInvoiceNum"].ToString();
            }

            talonReport.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
            talonReport.xrPhonenum.Text = "Утас: " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
            talonReport.xrDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            DBRes._FillTable("SELECT A.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSize "
                + " FROM tSaleDetail A INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " WHERE A.SaleInvoiceID=" + SaleInvoiceID, "talonNohojHevleh");
            talonReport.DataSource = DBRes.DS.Tables["talonNohojHevleh"];
            talonReport.ShowPrintMarginsWarning = false;

            using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
            {
                if (talonReport == null) talonReport = new Reports.rNormalPosTalon();
                form2.PrintingSystem = talonReport.PrintingSystem;
                talonReport.CreateDocument();
                if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Үйлчлүүлэгчид өгөх)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (selectType == 2)
            {
                //SaleInvoiceNum
                DBRes._FillTable("SELECT A.*,B.LastName,B.FirstName,B.RegNum FROM tDiscountSale A "
                    + " INNER JOIN tDiscountCustomer B ON(B.CustomerID=A.CustomerID) "
                    + " WHERE A.DiscountSaleID=" + SaleInvoiceNum, "selSaleInvoiceNum");
                //Detail
                DBRes._FillTable("SELECT A.*,(A.PriceND-A.DisCusPrice)NDDiscountTotal,(B.Name+' '+B.Comment)Name "
                    + " FROM tDiscountSaleDetail A "
                    + " INNER JOIN tDiscountDrug B ON(B.DiscountDrugID=A.DiscountDrugID) "
                    + " WHERE A.DiscountSaleID=" + SaleInvoiceNum, "selDetail");

                printCount = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["Printcount"]);
                printerName = DBRes.DS.Tables["SystemInfo"].Rows[0]["PrinterName"].ToString();
                Static.Margins = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaddingNum"]);

                Reports.rDiscountPosTalon talonReportDis = new Reports.rDiscountPosTalon();
                talonReportDis.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                talonReportDis.xrLastName.Text = talonReportDis.xrLastName.Text + " " + DBRes.DS.Tables["selSaleInvoiceNum"].Rows[0]["LastName"].ToString();
                talonReportDis.xrFirstName.Text = talonReportDis.xrFirstName.Text + " " + DBRes.DS.Tables["selSaleInvoiceNum"].Rows[0]["FirstName"].ToString();
                talonReportDis.xrRegNum.Text = talonReportDis.xrRegNum.Text + " " + DBRes.DS.Tables["selSaleInvoiceNum"].Rows[0]["RegNum"].ToString();
                talonReportDis.xrJorNum.Text = talonReportDis.xrJorNum.Text + " " + DBRes.DS.Tables["selSaleInvoiceNum"].Rows[0]["JorNum"].ToString();
                talonReportDis.xrDoctorNum.Text = talonReportDis.xrDoctorNum.Text + " " + DBRes.DS.Tables["selSaleInvoiceNum"].Rows[0]["DoctorCipher"].ToString();
                talonReportDis.DataSource = DBRes.DS.Tables["selDetail"];
                talonReportDis.xrActionDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                talonReportDis.ShowPrintMarginsWarning = false;

                using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                {
                    if (talonReportDis == null) talonReportDis = new Reports.rDiscountPosTalon();
                    form2.PrintingSystem = talonReportDis.PrintingSystem;
                    talonReportDis.CreateDocument();
                    if (XtraMessageBox.Show("Талон хэвлэх үү? Хэвлэх бол Yes хэвлэхгүй бол No дарна уу.", "Талон хэвлэх (Нийгмийн даатгалруу явуулах)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            for (int i = 0; i < printCount; i++)
                            {
                                talonReportDis.Print(printerName);
                            }
                        }
                        catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмжийн холболтын асуудалаас болж талон хэвлэгдсэнгүй.", "Талон хэвлэх (Нийгмийн даатгалруу явуулах)", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }

        private void btnPrintPrewiew_Click(object sender, EventArgs e)
        {
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridSaleInvoice.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridSaleInvoice.ShowPrintPreview();
        }

    }
}
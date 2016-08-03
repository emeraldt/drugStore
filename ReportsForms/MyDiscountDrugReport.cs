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
using DevExpress.XtraPrinting.Preview;

namespace Pharmacy.ReportsForms
{
    public partial class MyDiscountDrugReport : DevExpress.XtraEditors.XtraForm
    {
        public MyDiscountDrugReport()
        {
            InitializeComponent();
        }

        private void DiscountDrugReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
        }

        private void DiscountDrugReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DiscountDrugReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._discountdrugreport = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.JorNum ASC) AS RowNum, "
                + " A.DiscountSaleID,(B.LastName+' '+B.FirstName)LFName,B.RegNum,B.EMDNum,B.NDNum, "
                + " (B.Address+' '+B.Phone)Address,A.JorNum,A.JorDate,A.DoctorCipher,A.ActionDate FROM tDiscountSale A "
                + " INNER JOIN tDiscountCustomer B ON(B.CustomerID=A.CustomerID) "
                + " WHERE A.ActionDate>='" + dateStart.Text.Trim() + " 00:00:00' AND "
                + " A.ActionDate<='" + dateEnd.Text.Trim() + " 23:59:59'", "DiscountSaleReport");
            gridDiscountDrugReport.DataSource = DBRes.DS.Tables["DiscountSaleReport"];
            btnPrint.Enabled = true;
        }

        private void gridDiscountDrugReport_Click(object sender, EventArgs e)
        {
            int DiscountSaleID = 0;
            if (gridViewDiscountDrugReport == null || gridViewDiscountDrugReport.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDiscountDrugReport.SelectedRowsCount];
            for (int i = 0; i < gridViewDiscountDrugReport.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDiscountDrugReport.GetDataRow(gridViewDiscountDrugReport.GetSelectedRows()[i]);
            }
            gridViewDiscountDrugReport.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                DiscountSaleID = Convert.ToInt32(row["DiscountSaleID"]);
            }
            gridViewDiscountDrugReport.EndSort();
            DBRes._FillTable("SELECT A.DSDetailID,A.DiscountDrugID,(B.FileNum+': '+B.Name)Name,A.Count, "
                + " (A.PriceND/A.Count)UnitPrice, "
                + " A.PriceND,(A.PriceND-A.DisCusPrice)NDTotal,A.DisCusPrice FROM tDiscountSaleDetail A "
                + " INNER JOIN tDiscountDrug B ON(B.DiscountDrugID=A.DiscountDrugID) WHERE DiscountSaleID="
                + DiscountSaleID, "DiscountSaleDetailReport");
            gridJorDrug.DataSource = DBRes.DS.Tables["DiscountSaleDetailReport"];
            DBRes._FillTable("SELECT A.*,(C.Name+' '+ISNULL(C.Size,'')+' '+ISNULL(C.Package,''))Name FROM tSaleDetail A "
                + " INNER JOIN (SELECT SaleInvoiceID FROM tSaleInvoice WHERE SaleInvoiceNum='" + DiscountSaleID + "')B "
                + " ON(B.SaleInvoiceID=A.SaleInvoiceID) "
                + " INNER JOIN tDrug C ON(C.DrugID=A.DrugID)", "MyDiscountSaleDetailReport");
            gridJorMyDrug.DataSource = DBRes.DS.Tables["MyDiscountSaleDetailReport"];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDiscountDrugReport.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count <= 0)
            {
                XtraMessageBox.Show("Тухайн өгөгдсөн хугацаанд хамаарах НД эмийн тайлан байхгүй.", "Тайлан", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Reports.rMyDiscountDrugReport RB = new Reports.rMyDiscountDrugReport();

            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

            RB.xrCompanyname.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString() + " " + RB.xrCompanyname.Text;
            RB.xrOgnoo.Text = dateStart.Text + " -ээс " + dateEnd.Text + " хүртэл";

            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.JorNum ASC) AS RowNum, "
                + " (B.LastName+' '+B.FirstName)LFName,B.RegNum,B.EMDNum,B.NDNum, "
                + " B.Address,A.JorNum,A.JorDate,A.DoctorCipher "
                + " ,''name1,''too1,''uprice1,''price1,''nddun1,''tolson1 "
                + " ,''name2,''too2,''uprice2,''price2,''nddun2,''tolson2 "
                + " ,''name3,''too3,''uprice3,''price3,''nddun3,''tolson3 "
                + " ,''n1,''to1,''pr1,''dun1 "
                + " ,''n2,''to2,''pr2,''dun2 "
                + " ,''n3,''to3,''pr3,''dun3 "
                + " ,'' ActionDate FROM tDiscountSale A "
                + " INNER JOIN tDiscountCustomer B ON(B.CustomerID=A.CustomerID) "
                + " INNER JOIN tDiscountSaleDetail C ON(C.DiscountSaleID=A.DiscountSaleID) "
                + " WHERE A.DiscountSaleID=-1", "MyDiscountDrugReportMaster");

            decimal sumTotal = 0;
            decimal sumMyTotal = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sumTotal = sumTotal + Convert.ToDecimal(selDisSaleDetail("NDTotal", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ? Convert.ToDecimal(selDisSaleDetail("NDTotal", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"]))) : 0);
                sumTotal = sumTotal + Convert.ToDecimal(selDisSaleDetail("NDTotal", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ? Convert.ToDecimal(selDisSaleDetail("NDTotal", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"]))) : 0);
                sumTotal = sumTotal + Convert.ToDecimal(selDisSaleDetail("NDTotal", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ? Convert.ToDecimal(selDisSaleDetail("NDTotal", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"]))) : 0);

                sumMyTotal = sumMyTotal + Convert.ToDecimal(selSaleDetail("SumPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ? Convert.ToDecimal(selSaleDetail("SumPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"]))) : 0);
                sumMyTotal = sumMyTotal + Convert.ToDecimal(selSaleDetail("SumPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ? Convert.ToDecimal(selSaleDetail("SumPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"]))) : 0);
                sumMyTotal = sumMyTotal + Convert.ToDecimal(selSaleDetail("SumPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ? Convert.ToDecimal(selSaleDetail("SumPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"]))) : 0);

                DBRes.DS.Tables["MyDiscountDrugReportMaster"].Rows.Add(
                    ds.Tables[0].Rows[i]["RowNum"],
                    ds.Tables[0].Rows[i]["LFName"],
                    ds.Tables[0].Rows[i]["RegNum"],
                    ds.Tables[0].Rows[i]["EMDNum"],
                    ds.Tables[0].Rows[i]["NDNum"],
                    ds.Tables[0].Rows[i]["Address"],
                    ds.Tables[0].Rows[i]["JorNum"],
                    Convert.ToDateTime(ds.Tables[0].Rows[i]["JorDate"]).ToString("yyyy-MM-dd"),
                    ds.Tables[0].Rows[i]["DoctorCipher"],
                    selDisSaleDetail("Name", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selDisSaleDetail("Count", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selDisSaleDetail("UnitPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("UnitPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("UnitPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("PriceND", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("PriceND", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("PriceND", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("NDTotal", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("NDTotal", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("NDTotal", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("DisCusPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("DisCusPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("DisCusPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",

                    selDisSaleDetail("Name", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selDisSaleDetail("Count", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selDisSaleDetail("UnitPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("UnitPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("UnitPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("PriceND", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("PriceND", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("PriceND", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("NDTotal", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("NDTotal", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("NDTotal", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("DisCusPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("DisCusPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("DisCusPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",

                    selDisSaleDetail("Name", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selDisSaleDetail("Count", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selDisSaleDetail("UnitPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("UnitPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("UnitPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("PriceND", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("PriceND", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("PriceND", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("NDTotal", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("NDTotal", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("NDTotal", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",
                    selDisSaleDetail("DisCusPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])) != String.Empty ?
                    selDisSaleDetail("DisCusPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).Substring(0, selDisSaleDetail("DisCusPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])).IndexOf(".")) : "",

                    selSaleDetail("Name", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("Count", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("Price", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("SumPrice", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),

                    selSaleDetail("Name", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("Count", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("Price", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("SumPrice", 2, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),

                    selSaleDetail("Name", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("Count", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("Price", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),
                    selSaleDetail("SumPrice", 3, Convert.ToInt32(ds.Tables[0].Rows[i]["DiscountSaleID"])),

                    ds.Tables[0].Rows[i]["ActionDate"]
                    );
            }

            RB.DataSource = DBRes.DS.Tables["MyDiscountDrugReportMaster"];

            RB.xrNDAvahDun.Text = sumTotal.ToString("###,###,###,###,###.##");
            RB.xrMySumDun.Text = sumMyTotal.ToString("###,###,###,###,###.##");

            using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
            {
                form1.PrintingSystem = RB.PrintingSystem;
                RB.CreateDocument();
                form1.ShowDialog();
            }
        }

        private string selDisSaleDetail(string fieldName, int rowNum, int discountSaleID)
        {
            DBRes._FillTable("SELECT A.DSDetailID,A.DiscountDrugID,(B.FileNum+': '+B.Name)Name,A.Count, "
                + " (A.PriceND/A.Count)UnitPrice, "
                + " A.PriceND,(A.PriceND-A.DisCusPrice)NDTotal,A.DisCusPrice FROM tDiscountSaleDetail A "
                + " INNER JOIN tDiscountDrug B ON(B.DiscountDrugID=A.DiscountDrugID) WHERE DiscountSaleID="
                + discountSaleID, "selDisSaleView");
            if (DBRes.DS.Tables["selDisSaleView"].Rows.Count == 1)
            {
                if (rowNum == 2 || rowNum == 3)
                    return "";
                else return DBRes.DS.Tables["selDisSaleView"].Rows[0][fieldName].ToString();
            }
            else if (DBRes.DS.Tables["selDisSaleView"].Rows.Count == 2)
            {
                if (rowNum == 1)
                    return DBRes.DS.Tables["selDisSaleView"].Rows[0][fieldName].ToString();
                else if (rowNum == 2)
                    return DBRes.DS.Tables["selDisSaleView"].Rows[1][fieldName].ToString();
                else return "";
            }
            else
            {
                if (rowNum == 1)
                    return DBRes.DS.Tables["selDisSaleView"].Rows[0][fieldName].ToString();
                else if (rowNum == 2)
                    return DBRes.DS.Tables["selDisSaleView"].Rows[1][fieldName].ToString();
                else return DBRes.DS.Tables["selDisSaleView"].Rows[2][fieldName].ToString();
            }
        }

        private string selSaleDetail(string fieldName, int rowNum, int discountSaleID)
        {
            DBRes._FillTable("SELECT A.*,(C.Name+' '+ISNULL(C.Size,'')+' '+ISNULL(C.Package,''))Name FROM tSaleDetail A "
                + " INNER JOIN (SELECT SaleInvoiceID FROM tSaleInvoice WHERE SaleInvoiceNum='" + discountSaleID + "')B "
                + " ON(B.SaleInvoiceID=A.SaleInvoiceID) "
                + " INNER JOIN tDrug C ON(C.DrugID=A.DrugID)", "selSaleView");
            if (DBRes.DS.Tables["selSaleView"].Rows.Count == 1)
            {
                if (rowNum == 2 || rowNum == 3)
                    return "";
                else return DBRes.DS.Tables["selSaleView"].Rows[0][fieldName].ToString();
            }
            else if (DBRes.DS.Tables["selSaleView"].Rows.Count == 2)
            {
                if (rowNum == 1)
                    return DBRes.DS.Tables["selSaleView"].Rows[0][fieldName].ToString();
                else if (rowNum == 2)
                    return DBRes.DS.Tables["selSaleView"].Rows[1][fieldName].ToString();
                else return "";
            }
            else
            {
                if (rowNum == 1)
                    return DBRes.DS.Tables["selSaleView"].Rows[0][fieldName].ToString();
                else if (rowNum == 2)
                    return DBRes.DS.Tables["selSaleView"].Rows[1][fieldName].ToString();
                else return DBRes.DS.Tables["selSaleView"].Rows[2][fieldName].ToString();
            }
        }
    }
}
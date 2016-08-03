using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;

namespace Pharmacy.Forms
{
    public partial class SaleTalonEdit : DevExpress.XtraEditors.XtraForm
    {
        public int SaleInvoiceID;
        public SaleTalonEdit()
        {
            InitializeComponent();
        }

        private void SaleTalonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleTalonEdit_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT A.*,(B.FirstName+'-'+B.CardNum)Cardname,C.Username FROM tSaleInvoice A "
                + " INNER JOIN tDiscountcard B ON(B.CardID=A.CardID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) "
                + " WHERE A.SaleInvoiceID=" + SaleInvoiceID, "SaleInvoice");
            if (DBRes.DS.Tables["SaleInvoice"].Rows.Count > 0)
            {
                txtSaleInvoiceNum.Text = DBRes.DS.Tables["SaleInvoice"].Rows[0]["SaleInvoiceNum"].ToString();
                txtSumPrice.Text = DBRes.DS.Tables["SaleInvoice"].Rows[0]["SumPrice"].ToString();
                txtActionDate.Text = Convert.ToDateTime(DBRes.DS.Tables["SaleInvoice"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd");
                txtCardname.Text = DBRes.DS.Tables["SaleInvoice"].Rows[0]["Cardname"].ToString();
                txtSumDiscount.Text = DBRes.DS.Tables["SaleInvoice"].Rows[0]["SumDiscount"].ToString();
                txtUsername.Text = DBRes.DS.Tables["SaleInvoice"].Rows[0]["Username"].ToString();
            }

            DBRes._FillTable("SELECT A.*,B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,'')NameSizePackage "
                + " ,'UnChanged'Status FROM tSaleDetail A INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " WHERE A.SaleInvoiceID=" + SaleInvoiceID, "SaleDetail");
            gridTalonEdit.DataSource = DBRes.DS.Tables["SaleDetail"];

            DBRes._FillTable("SELECT DrugID,Name+' '+ISNULL(Size,'')+' '+ISNULL(Package,'')NameSizePackage,Price FROM tDrug", "Drug");
            repositoryItemLookDrug.DataSource = DBRes.DS.Tables["Drug"];
            repositoryItemLookDrug.ValueMember = "DrugID";
            repositoryItemLookDrug.DisplayMember = "NameSizePackage";
        }

        private void gridViewTalonEdit_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SumPrice") return;
            if (e.Column.FieldName == "Status") return;
            if (gridViewTalonEdit.GetFocusedRowCellValue("Count") == DBNull.Value || gridViewTalonEdit.GetFocusedRowCellValue("Price") == DBNull.Value) { }
            else
            {
                decimal a = Convert.ToDecimal(gridViewTalonEdit.GetFocusedRowCellValue("Count"));
                decimal b = Convert.ToDecimal(gridViewTalonEdit.GetFocusedRowCellValue("Price"));
                gridViewTalonEdit.SetFocusedRowCellValue("SumPrice", (a * b));
                if (gridViewTalonEdit.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                    gridViewTalonEdit.SetFocusedRowCellValue("Status", "Modified");
            }
        }

        private void gridViewTalonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DataRow[] rows;
                    if (gridViewTalonEdit != null && gridViewTalonEdit.SelectedRowsCount != 0)
                    {
                        rows = new DataRow[gridViewTalonEdit.SelectedRowsCount];
                        for (int i = 0; i < gridViewTalonEdit.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewTalonEdit.GetDataRow(gridViewTalonEdit.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            if (XtraMessageBox.Show("Борлуулалтын талоноос эм устгах гэж байна. Устгах уу?", "Мөр устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                String[] spPName = new String[] { "SaleDetailID" };
                                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                                Object[] spPValue = new Object[] { Convert.ToInt32(row["SaleDetailID"]) };
                                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                                if (DBRes._ParamProcedure("DELETE FROM tSaleDetail WHERE SaleDetailID=@SaleDetailID", CommandType.Text))
                                {
                                    row.Delete();
                                    DBRes._FillTable("SELECT A.*,B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,'')NameSizePackage "
                                        + " ,'UnChanged'Status FROM tSaleDetail A INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                                        + " WHERE A.SaleInvoiceID=" + SaleInvoiceID, "SaleDetail");
                                    gridTalonEdit.DataSource = DBRes.DS.Tables["SaleDetail"];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Алдаа: " + ex.Message, "Системийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridTalonEdit.DataSource as DataTable).Copy());
            if (ds.Tables["SaleDetail"].Rows.Count <= 0)
            {
                String[] spPName = new String[] { "SaleInvoiceID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                Object[] spPValue = new Object[] { SaleInvoiceID };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("DELETE FROM tSaleInvoice WHERE SaleInvoiceID=@SaleInvoiceID", CommandType.Text))
                {
                    XtraMessageBox.Show("Уг талонд эм үлдээгүй тул уг талоныг устгав.", "Талон устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }
            decimal sumprice = 0;
            try
            {
                for (int i = 0; i < ds.Tables["SaleDetail"].Rows.Count; i++)
                {
                    sumprice = sumprice + Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["SumPrice"]);
                }
            }
            catch (Exception) { XtraMessageBox.Show("Эмийн тоо ширхэг эсвэл авсан үнэ оруулаагүй байна.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            String[] spPName1 = new String[] { "SaleInvoiceID", "SumPrice", "ActionType", "Status" };
            SqlDbType[] spPSDBType1 = new SqlDbType[] { SqlDbType.Int, SqlDbType.Decimal, SqlDbType.TinyInt, SqlDbType.TinyInt };
            Object[] spPValue1 = new Object[] { SaleInvoiceID, sumprice, 2, 1 };
            if (!Static._spParameterAdd(spPName1, spPSDBType1, spPValue1)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mSale_Pro", CommandType.StoredProcedure))
            {
                XtraMessageBox.Show("Талон ажилттай засварлагдлаа.", "Талон засварлах", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
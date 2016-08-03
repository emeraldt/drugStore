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
    public partial class DrugList : DevExpress.XtraEditors.XtraForm
    {
        public bool IsDiscount = false;
        public DrugList()
        {
            InitializeComponent();
        }

        private void DrugList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._druglist = null;
        }

        private void DrugList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DrugList_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrugType", "DrugType");
            gridType.DataSource = DBRes.DS.Tables["DrugType"];
            if (!IsDiscount)
            {
                DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY A.Name ASC)RowNum, "
                    + " A.*,B.Name Type,C.Shot Unit FROM tDrug A "
                    + " INNER JOIN tDrugType B WITH(NOLOCK) ON(B.TypeID=A.TypeID) "
                    + " INNER JOIN tDrugUnit C WITH(NOLOCK) ON(C.UnitID=A.UnitID)", "Drug");
            }
            else
            {
                DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY A.Name ASC)RowNum, "
                    + " A.*,B.Name Type,C.Shot Unit FROM tDrug A "
                    + " INNER JOIN tDrugType B WITH(NOLOCK) ON(B.TypeID=A.TypeID) "
                    + " INNER JOIN tDrugUnit C WITH(NOLOCK) ON(C.UnitID=A.UnitID) "
                    + " INNER JOIN tDiscountDrugList D WITH(NOLOCK) ON(D.DrugID=A.DrugID)", "Drug");
            }
            gridDrug.DataSource = DBRes.DS.Tables["Drug"];
        }

        private void gridType_DoubleClick(object sender, EventArgs e)
        {
            int rowId = 0;
            if (gridViewType == null && gridViewType.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewType.SelectedRowsCount];
            for (int i = 0; i < gridViewType.SelectedRowsCount; i++)
            {
                rows[i] = gridViewType.GetDataRow(gridViewType.GetSelectedRows()[i]);
            }
            //gridViewBaraa.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                rowId = Convert.ToInt32(row["TypeID"].ToString());
            }
            if (rowId != 0)
            {
                DBRes._FillTable("SELECT A.*,B.Name Type,C.Name Unit FROM tDrug A "
                    + " INNER JOIN tDrugType B WITH(NOLOCK) ON(B.TypeID=A.TypeID) "
                    + " INNER JOIN tDrugUnit C WITH(NOLOCK) ON(C.UnitID=A.UnitID) "
                    + " WHERE A.TypeID=" + rowId, "Drug");
                gridDrug.DataSource = DBRes.DS.Tables["Drug"];
            }
        }

        private void gridDrug_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(43)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridDrug.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridDrug.ShowPrintPreview();
        }

        private void gridDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(3)) return;
                DataRow[] rows;
                if (gridViewDrug != null && gridViewDrug.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг эмийн мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewDrug.SelectedRowsCount];
                        for (int i = 0; i < gridViewDrug.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewDrug.GetDataRow(gridViewDrug.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                        loop:
                            String[] spPName = new String[] { "DrugID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["DrugID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tDrug WHERE DrugID=@DrugID", CommandType.Text))
                                row.Delete();
                            else
                            {
                                if (drugDelete(Convert.ToInt32(row["DrugID"])))
                                    goto loop;
                                else return;
                            }
                        }
                    }
                }
            }
        }

        private bool drugDelete(int drugID)
        {
            if (DBRes.mExText.IndexOf("FK_tDiscountDrugList_tDrug") != -1)
            {
                DBRes._FillTable("SELECT (B.Name+' '+ISNULL(B.Comment,''))Name FROM tDiscountDrugList A "
                    + " INNER JOIN tDiscountDrug B ON(B.DiscountDrugID=A.DisDrugID) "
                    + " WHERE A.DrugID=" + drugID, "selDisDListCheck");
                if (DBRes.DS.Tables["selDisDListCheck"].Rows.Count > 0)
                {
                    if (XtraMessageBox.Show(DBRes.DS.Tables["selDisDListCheck"].Rows[0]["Name"].ToString() + "-гэсэн хөнгөлөлттэй эмтэй холбоотой байна."
                        + " \nХолбоог салгах уу?", "Холбоо салгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRes._ParamProcedure("DELETE FROM tDiscountDrugList WHERE DrugID=" + drugID, CommandType.Text);
                        return true;
                    }
                }
            }
            else if (DBRes.mExText.IndexOf("FK_tCountDetail_tDrug") != -1)
            {
                if (XtraMessageBox.Show("Тооллогын бүртгэлээс уг эм давхар устгах болно. \nУстгах үйлдэлийг үргэлжлүүлэх үү?", "Тооллогоос эм устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DBRes._ParamProcedure("DELETE FROM tCountDetail WHERE DrugID=" + drugID, CommandType.Text);
                    return true;
                }
            }
            else if (DBRes.mExText.IndexOf("FK_tBuyDetail_tDrug") != -1)
            {
                string invNum = "";
                DBRes._FillTable("SELECT A.BuyInvoiceID,B.BuyInvoiceNum FROM tBuyDetail A "
                    + " INNER JOIN tBuyInvoice B ON(B.BuyInvoiceID=A.BuyInvoiceID) "
                    + " WHERE A.DrugID=" + drugID, "selBuyInvCheck");
                if (DBRes.DS.Tables["selBuyInvCheck"].Rows.Count > 0)
                {
                    for (int i = 0; i < DBRes.DS.Tables["selBuyInvCheck"].Rows.Count; i++)
                    {
                        invNum = "{ " + DBRes.DS.Tables["selBuyInvCheck"].Rows[i]["BuyInvoiceNum"].ToString() + " },";
                    }
                }
                XtraMessageBox.Show(invNum + "-дугаартай\n орлогын паданд уг эм орсон тул падан засварлахаар орж уг эмийг устгах шаардалгатай. \nҮүний дараа уг эмийг устгаж болно.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Уг эм борлуулалтанд орсон тус устгах боломжгүй.", "Эм устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
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
    public partial class DiscountDrugSetting : DevExpress.XtraEditors.XtraForm
    {
        public DiscountDrugSetting()
        {
            InitializeComponent();
        }

        private void DiscountDrugSetting_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(lookDiscountDrug, "Хөнгөлөлттэй эм сонгоогүй байна.", ConditionOperator.IsNotBlank);

            DBRes._FillTable("SELECT DiscountDrugID,BarCode,(Name+' '+ISNULL(InterName,'')+' ' +ISNULL(Comment,''))Name, "
                + " Package,Price,IsDiscount,FileNum,NDDiscountTotal,MaxSize,Status,TypeID FROM tDiscountDrug "
                + " WHERE IsDiscount=1", "DiscountDrug");
            lookDiscountDrug.Properties.DataSource = DBRes.DS.Tables["DiscountDrug"];
            lookDiscountDrug.Properties.ValueMember = "DiscountDrugID";
            lookDiscountDrug.Properties.DisplayMember = "Name";

            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.DrugID ASC) AS RowNum, "
                + " A.DrugID,A.Price,(A.Name+' '+ISNULL(A.Size,'')+' '+ISNULL(A.Package,''))NameSizePackage FROM tDrug A "
                + " INNER JOIN tDrugType C WITH(NOLOCK) ON(C.TypeID=A.TypeID) "
                + " WHERE  A.DrugID NOT IN (SELECT DrugID FROM tDiscountDrugList)", "NoDiscountDrug");
            gridNoDiscount.DataSource = DBRes.DS.Tables["NoDiscountDrug"];
        }

        private void DiscountDrugSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F1)
                btnDiscountDrugAdd_Click(sender, e);
        }

        private void DiscountDrugSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._discountsetting = null;
        }

        private void lookDiscountDrug_EditValueChanged(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.DrugID ASC) AS RowNum, "
                + " A.DrugID,A.Price,(A.Name+' '+ISNULL(A.Size,'')+' '+ISNULL(A.Package,''))NameSizePackage FROM tDrug A "
                + " INNER JOIN tDrugType C WITH(NOLOCK) ON(C.TypeID=A.TypeID) "
                + " WHERE A.DrugID NOT IN (SELECT DrugID FROM tDiscountDrugList)", "NoDiscountDrug");
            gridNoDiscount.DataSource = DBRes.DS.Tables["NoDiscountDrug"];

            DBRes._FillTable("SELECT * FROM tDiscountDrug WHERE DiscountDrugID=" + lookDiscountDrug.EditValue, "DiscountDrug");
            if (DBRes.DS.Tables["DiscountDrug"].Rows.Count > 0)
            {
                string txt = DBRes.DS.Tables["DiscountDrug"].Rows[0]["Name"].ToString() + ", савлалт-" + DBRes.DS.Tables["DiscountDrug"].Rows[0]["Package"].ToString() + ", үнэ-" + DBRes.DS.Tables["DiscountDrug"].Rows[0]["Price"].ToString() + ", бар код-" + DBRes.DS.Tables["DiscountDrug"].Rows[0]["BarCode"].ToString();
                lblDiscountDrugInfo.Text = lblDiscountDrugInfo.Text = txt;

                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.DisDrugID ASC) AS RowNum, "
                    + " A.*,B.Price,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage FROM tDiscountDrugList A  "
                    + " INNER JOIN tDrug B WITH(NOLOCK) ON(B.DrugID=A.DrugID) "
                    + " INNER JOIN tDrugType C WITH(NOLOCK) ON(C.TypeID=B.TypeID) "
                    + " WHERE A.DisDrugID=" + DBRes.DS.Tables["DiscountDrug"].Rows[0]["DiscountDrugID"].ToString(), "DiscountDrug");
                gridDiscount.DataSource = DBRes.DS.Tables["DiscountDrug"];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            int noDiscountDrugID = 0;
            if (gridViewNoDiscount == null || gridViewNoDiscount.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewNoDiscount.SelectedRowsCount];
            for (int i = 0; i < gridViewNoDiscount.SelectedRowsCount; i++)
            {
                rows[i] = gridViewNoDiscount.GetDataRow(gridViewNoDiscount.GetSelectedRows()[i]);
            }
            gridViewNoDiscount.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                noDiscountDrugID = Convert.ToInt32(row["DrugID"]);
            }
            gridViewNoDiscount.EndSort();
            String[] spPName = new String[] { "DisDrugID", "DrugID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int };
            Object[] spPValue = new Object[] { lookDiscountDrug.EditValue, noDiscountDrugID };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (DBRes._ParamProcedure("INSERT INTO tDiscountDrugList (DisDrugID,DrugID) "
                    + " VALUES(@DisDrugID,@DrugID)", CommandType.Text))
            {
                DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY B.Name ASC)RowNum, "
                    + " A.*,B.Price,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage FROM tDiscountDrugList A  "
                    + " INNER JOIN tDrug B WITH(NOLOCK) ON(B.DrugID=A.DrugID) "
                    + " INNER JOIN tDrugType C WITH(NOLOCK) ON(C.TypeID=B.TypeID) "
                    + " WHERE A.DisDrugID=" + lookDiscountDrug.EditValue, "DiscountDrug");
                gridDiscount.DataSource = DBRes.DS.Tables["DiscountDrug"];
                foreach (DataRow row in rows)
                {
                    row.Delete();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            int discountDrugID = 0;
            if (gridViewDiscount == null || gridViewDiscount.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDiscount.SelectedRowsCount];
            for (int i = 0; i < gridViewDiscount.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDiscount.GetDataRow(gridViewDiscount.GetSelectedRows()[i]);
            }
            gridViewDiscount.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                discountDrugID = Convert.ToInt32(row["DrugID"]);
            }
            gridViewDiscount.EndSort();
            String[] spPName = new String[] { "DisDrugID", "DrugID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int };
            Object[] spPValue = new Object[] { lookDiscountDrug.EditValue, discountDrugID };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (DBRes._ParamProcedure("DELETE FROM tDiscountDrugList WHERE DisDrugID=" + lookDiscountDrug.EditValue + " AND DrugID=" + discountDrugID, CommandType.Text))
            {
                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.DrugID ASC) AS RowNum, "
                    + " A.DrugID,A.Price,(A.Name+' '+ISNULL(A.Size,'')+' '+ISNULL(A.Package,''))NameSizePackage FROM tDrug A "
                    + " INNER JOIN tDrugType C WITH(NOLOCK) ON(C.TypeID=A.TypeID) "
                    + " WHERE  A.DrugID NOT IN (SELECT DrugID FROM tDiscountDrugList)", "NoDiscountDrug");
                gridNoDiscount.DataSource = DBRes.DS.Tables["NoDiscountDrug"];
                foreach (DataRow row in rows)
                {
                    row.Delete();
                }
            }
        }

        private void btnDiscountDrugAdd_Click(object sender, EventArgs e)
        {
            DiscountDrug discountdrug = new DiscountDrug();
            discountdrug.ShowDialog();
            DBRes._FillTable("SELECT * FROM tDiscountDrug WHERE IsDiscount=1", "DiscountDrug");
            lookDiscountDrug.Properties.DataSource = DBRes.DS.Tables["DiscountDrug"];
            lookDiscountDrug.Properties.ValueMember = "DiscountDrugID";
            lookDiscountDrug.Properties.DisplayMember = "Name";

            Static.dxV.Dispose();
            Static.EmptyValidate(lookDiscountDrug, "Хөнгөлөлттэй эм сонгоогүй байна.", ConditionOperator.IsNotBlank);
        }

    }
}
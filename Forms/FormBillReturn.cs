using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Pharmacy.PosApi;
using Pharmacy.Codes;

namespace Pharmacy.Forms
{
    public partial class FormBillReturn : DevExpress.XtraEditors.XtraForm
    {
        public FormBillReturn()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;

            var returnBillData = new ReturnBill()
            {
                returnBillId = txtBillNo.Text,
                date = String.Format("{0:yyyy-MM-dd hh:mm:ss}", date.EditValue)
            };
            var jsonData = new JavaScriptSerializer().Serialize(returnBillData);

            var result = Program.returnBill(jsonData);
            var resultData = new JavaScriptSerializer().Deserialize<Result>(result);

            if ("True".Equals(resultData.success))
            {
                MessageBox.Show("Амжилттай буцаагдлаа.");
                int invoiceID;
                var cmd = new SqlCommand("select SaleInvoiceID from tSaleInvoice where billNo='" + txtBillNo.Text + "'", DBRes.sql_conn);
                
                invoiceID = Convert.ToInt32(cmd.ExecuteScalar());

                var delDetail = new SqlCommand("delete from tSaleDetail where SaleInvoiceID=" + invoiceID + "", DBRes.sql_conn);
                var delCmd = new SqlCommand("delete from tSaleInvoice where SaleInvoiceID=" + invoiceID + "", DBRes.sql_conn);
                try
                {
                    delDetail.ExecuteNonQuery();
                    delCmd.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Борлуулалтын мэдээлэл устгахад алдаа гарлаа!"); }
            }
            else
            {
                if ("310".Equals(resultData.errorCode) || "316".Equals(resultData.errorCode))
                {
                    MessageBox.Show("Уг баримт буцаагдсан байна.");
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBillReturn_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtBillNo, "Баримтын ДДТД оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(date, "Баримт хэвлэгдсэн огноог оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }
    }
}
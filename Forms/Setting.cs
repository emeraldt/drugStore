using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Pharmacy.Codes;
using Pharmacy.Controller;

namespace Pharmacy.Forms
{
    public partial class Setting : DevExpress.XtraEditors.XtraForm
    {
        public Setting()
        {
            InitializeComponent();

            var _configController = new ConfigController();
            lkpDistrictNo.Properties.DataSource = _configController.getData(16);
            lkpDistrictNo.Properties.DisplayMember = "ref_detail";
            lkpDistrictNo.Properties.ValueMember = "ref_short";
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtName, "Эмийн сангийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtRegion, "Эмийн сангийн харъяалал оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPhone, "Эмийн сангийн утас оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(lookPrinter, "Хэвлэгч сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPrintCount, "Талон хэвлэх тоо оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(lkpDistrictNo, "Дүүрэг, орон нутаг сонгоогүй байна!", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPosNo, "Кассын дугаар оруулаагүй байна. 4-6 оронтой тоон утга оруулна уу!", ConditionOperator.IsNotBlank);

            DBRes._FillTable("SELECT * FROM tPrinter", "Printer");
            lookPrinter.Properties.DataSource = DBRes.DS.Tables["Printer"];
            lookPrinter.Properties.ValueMember = "PrintID";
            lookPrinter.Properties.DisplayMember = "Name";

            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");
            txtName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
            txtRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString();
            txtPhone.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Phonenum"].ToString();
            lookPrinter.EditValue = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PrinterID"]);
            txtPrintCount.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Printcount"].ToString();
            txtLCText.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["LCText"].ToString();
            bool chbDis = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["NDDiscount"]);
            bool poswin = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["PosWin"]);
            bool disposwin = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["DisPosWin"]);
            bool logiccontrols = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["LogicControls"]);

            rGrpPaperSize.EditValue = Convert.ToInt32(DBRes.DS.Tables["SystemInfo"].Rows[0]["PaperType"]);
            chkNuatTulugch.Checked = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["NuatTulugch"]);
            lkpDistrictNo.EditValue = DBRes.DS.Tables["SystemInfo"].Rows[0]["districtNo"];
            txtPosNo.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["posNo"].ToString();

            if(chkNuatTulugch.Checked)
                chkNuatOrson.Checked = Convert.ToBoolean(DBRes.DS.Tables["SystemInfo"].Rows[0]["NuatOrson"]);

            chbNDDiscount.Checked = chbDis ? true : false;
            if (chbDis) { chbDisPosWin.Enabled = true; }
            else
            {
                chbDisPosWin.Enabled = false;
                chbDisPosWin.Checked = false;
            }
            chbPosWin.Checked = poswin ? true : false;
            chbDisPosWin.Checked = disposwin ? true : false;
            if (DBRes.mUserID != "1") { chbNDDiscount.Enabled = false; }
            if (logiccontrols) { chbLogicControls.Checked = true; txtLCText.Enabled = true; }
            else { chbLogicControls.Checked = false; txtLCText.Enabled = false; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (chbLogicControls.Checked)
            {
                if (txtLCText.Text.Length != 19)
                {
                    XtraMessageBox.Show("Logic Controls text - нь нийт 19н тэмдэгтэй байх ётой. Таных - " + txtLCText.Text.Length.ToString() + " байна.", "Logic Controls", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            bool IsDiscount = false, poswin = false, disposwin = false, logiccontrols = false;
            if (chbNDDiscount.Checked) IsDiscount = true;
            if (chbPosWin.Checked) poswin = true;
            if (chbDisPosWin.Checked) disposwin = true;
            if (chbLogicControls.Checked) logiccontrols = true;
            String[] spPName = new String[] { "Companyname", "Region", "Phonenum", "PrinterID", "Printcount", "NDDiscount", "DisPosWin", "PosWin", "LogicControls", "LCText", "PaperType", "NuatTulugch", "NuatOrson", "districtNo", "posNo" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Bit, SqlDbType.Bit, SqlDbType.Bit, SqlDbType.Bit, SqlDbType.NVarChar, SqlDbType.Int, SqlDbType.Bit, SqlDbType.Bit, SqlDbType.NVarChar, SqlDbType.NVarChar };
            Object[] spPValue = new Object[] { txtName.Text.Trim(), txtRegion.Text.Trim(), txtPhone.Text.Trim(), lookPrinter.EditValue, txtPrintCount.Text.Trim(), IsDiscount, disposwin, poswin, logiccontrols, txtLCText.Text, rGrpPaperSize.EditValue, chkNuatTulugch.Checked, chkNuatOrson.Checked, lkpDistrictNo.EditValue, txtPosNo.Text.Trim() };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (DBRes._ParamProcedure("UPDATE tSystemInfo SET Companyname=@Companyname,Region=@Region, "
                + " Phonenum=@Phonenum,PrinterID=@PrinterID,Printcount=@Printcount,NDDiscount=@NDDiscount, "
                + " DisPosWin=@DisPosWin,PosWin=@PosWin,LogicControls=@LogicControls,LCText=@LCText, "
                + " PaperType=@PaperType,NuatTulugch=@NuatTulugch,NuatOrson=@NuatOrson,districtNo=@districtNo,posNo=@posNo WHERE SoftID=1", CommandType.Text))
            {
                XtraMessageBox.Show("Програмын тохиргоо амжилттай хийгдлээ.", "Програмын тохиргоо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void chbNDDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNDDiscount.Checked)
            {
                chbDisPosWin.Enabled = true;
            }
            else
            {
                chbDisPosWin.Enabled = false;
                chbDisPosWin.Checked = false;
            }
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnTestPrint_Click(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT Name,PaddingNum FROM tPrinter WHERE PrintID=" + lookPrinter.EditValue, "Printer");
            Reports.rNormalPosTalon talonReport = new Reports.rNormalPosTalon();
            talonReport.xrCompanyname.Text = "Тест";
            talonReport.xrPhonenum.Text = "Утас: Тест";
            talonReport.xrTalonnum.Text = "№: Тест";
            talonReport.xrDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            talonReport.xrSumTotal.Text = "0.00 ₮";
            talonReport.xrDiscountTotal.Text = "0.00 ₮";
            talonReport.xrPayTotal.Text = "0.00 ₮";
            talonReport.xrPaidTotal.Text = "0.00 ₮";
            talonReport.xrOddMoney.Text = "0.00 ₮";
            talonReport.ShowPrintMarginsWarning = false;
            int printCount = 1;
            string printerName = DBRes.DS.Tables["Printer"].Rows[0]["Name"].ToString();
            int margins = Convert.ToInt32(DBRes.DS.Tables["Printer"].Rows[0]["PaddingNum"]);
            try
            {
                using (DevExpress.XtraPrinting.Preview.PrintPreviewFormEx form2 = new DevExpress.XtraPrinting.Preview.PrintPreviewFormEx())
                {
                    if (talonReport == null) talonReport = new Reports.rNormalPosTalon();
                    form2.PrintingSystem = talonReport.PrintingSystem;
                    talonReport.CreateDocument();
                    for (int i = 0; i < printCount; i++)
                    {
                        talonReport.Margins.Left = 0 + margins;
                        talonReport.Margins.Right = 635 - margins;
                        talonReport.Print(printerName);
                    }
                }
                XtraMessageBox.Show("Хэвлэгчийн тест амжилттай хийгдлээ.", "Хэвлэгчийн тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { XtraMessageBox.Show("Хэвлэх төхөөрөмж болон холболт, хэвлэгчийн нэрийг шалгана уу!!!", "Хэвлэгчийн тест", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void chbLogicControls_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLogicControls.Checked)
                txtLCText.Enabled = true;
            else txtLCText.Enabled = false;
        }

        private void btnCheckApi_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Program.checkApi());
        }

        private void btnGetInfoApi_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Program.getInformation());
        }

        private void chkNuatTulugch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuatTulugch.Checked == true)
                chkNuatOrson.Enabled = true;
            else
            {
                chkNuatOrson.Checked = false;
                chkNuatOrson.Enabled = false;
            }
        }

    }
}
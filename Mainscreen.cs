using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using DevExpress.XtraEditors;
using Pharmacy.Codes;

namespace Pharmacy
{
    public partial class Mainscreen : DevExpress.XtraEditors.XtraForm
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {
            barServer.Caption = "Серверийн нэр: " + Pharmacy.Codes.DBRes.mServer.ToString();
            barDB.Caption = "Мэдээлэлийн бааз: " + Pharmacy.Codes.DBRes.mDatabase.ToString();
            barUser.Caption = "Хэрэглэгч: " + Pharmacy.Codes.DBRes.mUser.ToString();
            barDate.Caption = "Систем огноо: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

            timer1.Start();

            //Administrator role
            Codes.DBRes._FillTable("SELECT A.*,B.Role FROM tUsers A INNER JOIN tUserGroup B WITH(NOLOCK) "
                + " ON(B.GroupID=A.GroupID)WHERE A.UserID=" + Codes.DBRes.mUserID, "Users");
            if (Codes.DBRes.DS.Tables["Users"].Rows.Count > 0)
            {
                if (Convert.ToInt32(Codes.DBRes.DS.Tables["Users"].Rows[0]["Role"]) != 1)
                {
                    barPrinter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    barSoftModule.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    barModuleGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    barUserGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    barClearData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }
            //System setting
            Codes.DBRes._FillTable("SELECT A.*,(B.Name)PrinterName  FROM tSystemInfo A INNER JOIN tPrinter B ON(B.PrintID=A.PrinterID)", "SystemInfo");
            if (!Convert.ToBoolean(Codes.DBRes.DS.Tables["SystemInfo"].Rows[0]["NDDiscount"]))
            {
                barDiscountDrug.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barDiscountCustmor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barDiscountDrugSetting.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barDiscountDrugReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barDiscountDrugMyReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barFileCreate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barDiscountCustmorList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            //skin load to menu
            skinfill();
            //close check
            if (Static.MainVal) { this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.Mainscreen_FormClosing); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barDate.Caption = "Систем огноо: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        private void barSkin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barButtonItem1.Checked && e.Item.Caption != "DevExpress Style") barButtonItem1.Checked = false;
            if (barButtonItem2.Checked && e.Item.Caption != "Money Twins") barButtonItem2.Checked = false;
            if (barButtonItem3.Checked && e.Item.Caption != "Lilian") barButtonItem3.Checked = false;
            if (barButtonItem4.Checked && e.Item.Caption != "DevExpress Dark Style") barButtonItem4.Checked = false;
            if (barButtonItem5.Checked && e.Item.Caption != "iMaginary") barButtonItem5.Checked = false;
            if (barButtonItem6.Checked && e.Item.Caption != "Black") barButtonItem6.Checked = false;
            if (barButtonItem7.Checked && e.Item.Caption != "Blue") barButtonItem7.Checked = false;
            if (barButtonItem11.Checked && e.Item.Caption != "Caramel") barButtonItem11.Checked = false;
            if (barButtonItem12.Checked && e.Item.Caption != "Office 2007 Black") barButtonItem12.Checked = false;
            if (barCheckItem1.Checked && e.Item.Caption != "Office 2007 Blue") barCheckItem1.Checked = false;
            if (barCheckItem2.Checked && e.Item.Caption != "Office 2007 Green") barCheckItem2.Checked = false;
            if (barButtonItem13.Checked && e.Item.Caption != "Office 2007 Pink") barButtonItem13.Checked = false;
            if (barCheckItem3.Checked && e.Item.Caption != "Office 2007 Silver") barCheckItem3.Checked = false;
            if (barCheckItem4.Checked && e.Item.Caption != "Office 2010 Black") barCheckItem4.Checked = false;
            if (barCheckItem5.Checked && e.Item.Caption != "Office 2010 Blue") barCheckItem5.Checked = false;
            if (barCheckItem6.Checked && e.Item.Caption != "Office 2010 Silver") barCheckItem6.Checked = false;
            if (barCheckItem7.Checked && e.Item.Caption != "Blurprint") barCheckItem7.Checked = false;
            if (barCheckItem8.Checked && e.Item.Caption != "Coffee") barCheckItem8.Checked = false;
            if (barCheckItem9.Checked && e.Item.Caption != "Dark Side") barCheckItem9.Checked = false;
            if (barCheckItem10.Checked && e.Item.Caption != "Darkroom") barCheckItem10.Checked = false;
            if (barCheckItem11.Checked && e.Item.Caption != "Foggy") barCheckItem11.Checked = false;
            if (barCheckItem12.Checked && e.Item.Caption != "Glass Oceans") barCheckItem12.Checked = false;
            if (barCheckItem13.Checked && e.Item.Caption != "High Contrast") barCheckItem13.Checked = false;
            if (barCheckItem14.Checked && e.Item.Caption != "Liquid Sky") barCheckItem14.Checked = false;
            if (barCheckItem15.Checked && e.Item.Caption != "London Liquid Sky") barCheckItem15.Checked = false;
            if (barCheckItem16.Checked && e.Item.Caption != "McSkin") barCheckItem16.Checked = false;
            if (barCheckItem17.Checked && e.Item.Caption != "Pumpkin") barCheckItem17.Checked = false;
            if (barCheckItem18.Checked && e.Item.Caption != "Seven") barCheckItem18.Checked = false;
            if (barCheckItem19.Checked && e.Item.Caption != "Seven Classic") barCheckItem19.Checked = false;
            if (barCheckItem20.Checked && e.Item.Caption != "Sharp") barCheckItem20.Checked = false;
            if (barCheckItem21.Checked && e.Item.Caption != "Sharp Plus") barCheckItem21.Checked = false;
            if (barCheckItem22.Checked && e.Item.Caption != "Springtime") barCheckItem22.Checked = false;
            if (barCheckItem23.Checked && e.Item.Caption != "Stardust") barCheckItem23.Checked = false;
            if (barCheckItem24.Checked && e.Item.Caption != "Summer") barCheckItem24.Checked = false;
            if (barCheckItem25.Checked && e.Item.Caption != "The Asphalt World") barCheckItem25.Checked = false;
            if (barCheckItem26.Checked && e.Item.Caption != "Valentine") barCheckItem26.Checked = false;
            if (barCheckItem27.Checked && e.Item.Caption != "VS2010") barCheckItem27.Checked = false;
            if (barCheckItem28.Checked && e.Item.Caption != "Whiteprint") barCheckItem28.Checked = false;
            if (barCheckItem29.Checked && e.Item.Caption != "Xmas (Blue)") barCheckItem29.Checked = false;
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = e.Item.Caption;
            //skin name reg-t bichih
            const string userRoot = @"HKEY_CURRENT_USER\Software\Super_Assist_Systems\Pharmacy";
            Microsoft.Win32.Registry.SetValue(userRoot, "SoftwareSkinName", e.Item.Caption);
        }

        private void skinfill()
        {
            string skinName = Codes.PharmacyFun.skinLoad();
            if (skinName == "DevExpress Style") barButtonItem1.Checked = true;
            if (skinName == "Money Twins") barButtonItem2.Checked = true;
            if (skinName == "Lilian") barButtonItem3.Checked = true;
            if (skinName == "DevExpress Dark Style") barButtonItem4.Checked = true;
            if (skinName == "iMaginary") barButtonItem5.Checked = true;
            if (skinName == "Black") barButtonItem6.Checked = true;
            if (skinName == "Blue") barButtonItem7.Checked = true;
            if (skinName == "Caramel") barButtonItem11.Checked = true;
            if (skinName == "Office 2007 Black") barButtonItem12.Checked = true;
            if (skinName == "Office 2007 Blue") barCheckItem1.Checked = true;
            if (skinName == "Office 2007 Green") barCheckItem2.Checked = true;
            if (skinName == "Office 2007 Pink") barButtonItem13.Checked = true;
            if (skinName == "Office 2007 Silver") barCheckItem3.Checked = true;
            if (skinName == "Office 2010 Black") barCheckItem4.Checked = true;
            if (skinName == "Office 2010 Blue") barCheckItem5.Checked = true;
            if (skinName == "Office 2010 Silver") barCheckItem6.Checked = true;
            if (skinName == "Blurprint") barCheckItem7.Checked = true;
            if (skinName == "Coffee") barCheckItem8.Checked = true;
            if (skinName == "Dark Side") barCheckItem9.Checked = true;
            if (skinName == "Darkroom") barCheckItem10.Checked = true;
            if (skinName == "Foggy") barCheckItem11.Checked = true;
            if (skinName == "Glass Oceans") barCheckItem12.Checked = true;
            if (skinName == "High Contrast") barCheckItem13.Checked = true;
            if (skinName == "Liquid Sky") barCheckItem14.Checked = true;
            if (skinName == "London Liquid Sky") barCheckItem15.Checked = true;
            if (skinName == "McSkin") barCheckItem16.Checked = true;
            if (skinName == "Pumpkin") barCheckItem17.Checked = true;
            if (skinName == "Seven") barCheckItem18.Checked = true;
            if (skinName == "Seven Classic") barCheckItem19.Checked = true;
            if (skinName == "Sharp") barCheckItem20.Checked = true;
            if (skinName == "Sharp Plus") barCheckItem21.Checked = true;
            if (skinName == "Springtime") barCheckItem22.Checked = true;
            if (skinName == "Stardust") barCheckItem23.Checked = true;
            if (skinName == "Summer") barCheckItem24.Checked = true;
            if (skinName == "The Asphalt World") barCheckItem25.Checked = true;
            if (skinName == "Valentine") barCheckItem26.Checked = true;
            if (skinName == "VS2010") barCheckItem27.Checked = true;
            if (skinName == "Whiteprint") barCheckItem28.Checked = true;
            if (skinName == "Xmas (Blue)") barCheckItem29.Checked = true;
        }

        private void barDrug_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Drug drug = new Forms.Drug();
            drug.ShowDialog();
        }

        private void barDrugType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DrugType drugtype = new Forms.DrugType();
            drugtype.ShowDialog();
        }

        private void barDrugUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DrugUnit drugunit = new Forms.DrugUnit();
            drugunit.ShowDialog();
        }

        private void barSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Supplier supplier = new Forms.Supplier();
            supplier.ShowDialog();
        }

        private void barDiscountCustmor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DiscountCustomer discountcustomer = new Forms.DiscountCustomer();
            discountcustomer.ShowDialog();
        }

        private void barDiscountCustmorList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(82)) return;
            if (Codes.Static._discountcustomerlist == null)
            {
                Codes.Static._discountcustomerlist = new Forms.DiscountCustomerList();
                Codes.Static._discountcustomerlist.MdiParent = this;
            }
            else
                Codes.Static._discountcustomerlist.BringToFront();
            Codes.Static._discountcustomerlist.Show();
        }

        private void barDiscountCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DiscountCard discountcard = new Forms.DiscountCard();
            discountcard.ShowDialog();
        }

        private void barBuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Buy buy = new Forms.Buy();
            buy.ShowDialog();
        }

        private void barBuyInvoiceList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Codes.Static._buyinvoicelist == null)
            {
                Codes.Static._buyinvoicelist = new Forms.BuyInvoiceList();
                Codes.Static._buyinvoicelist.MdiParent = this;
            }
            else
                Codes.Static._buyinvoicelist.BringToFront();
            Codes.Static._buyinvoicelist.Show();
        }

        private void barSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Sale sale = new Forms.Sale();
            sale.ShowDialog();
        }

        private void barSaleInvoiceList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Codes.Static._saleinvoicelist == null)
            {
                Codes.Static._saleinvoicelist = new Forms.SaleInvoiceList();
                Codes.Static._saleinvoicelist.MdiParent = this;
            }
            else
                Codes.Static._saleinvoicelist.BringToFront();
            Codes.Static._saleinvoicelist.Show();
        }

        private void barChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ChangePassword changepassword = new Forms.ChangePassword();
            changepassword.ShowDialog();
        }

        private void barUserInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Users user = new Forms.Users();
            user.ShowDialog();
        }

        private void barSoftSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(64)) return;
            Forms.Setting setting = new Forms.Setting();
            setting.ShowDialog();
        }

        private void barDrugList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Codes.Static._druglist == null)
            {
                Codes.Static._druglist = new Forms.DrugList();
                Codes.Static._druglist.MdiParent = this;
            }
            else
                Codes.Static._druglist.BringToFront();
            Codes.Static._druglist.Show();
        }

        private void Mainscreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Програмыг хаах гэж байна. Хаах уу?", "Програмаас гарах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                this.DialogResult = DialogResult.OK;
            }
            else { e.Cancel = true; }
        }

        private void barExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barDiscountDrugSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(33)) return;
            if (Codes.Static._discountsetting == null)
            {
                Codes.Static._discountsetting = new Forms.DiscountDrugSetting();
                Codes.Static._discountsetting.MdiParent = this;
            }
            else
                Codes.Static._discountsetting.BringToFront();
            Codes.Static._discountsetting.Show();
        }

        private void barDiscountDrug_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DiscountDrug discountdrug = new Forms.DiscountDrug();
            discountdrug.ShowDialog();
        }

        private void barChangePrice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ChangePrice changeprice = new Forms.ChangePrice();
            changeprice.ShowDialog();
        }

        private void barCreateBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DrugBill drugbill = new Forms.DrugBill();
            drugbill.ShowDialog();
        }

        private void barCounting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Static._countdetail != null) { XtraMessageBox.Show("Тооллогын дэлгэрэнгүй цонх нээлттэй байна. Уг цонхыг хаана уу?","Хэрэглэгчийн алдаа",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
            Forms.Count count = new Forms.Count();
            if (count.ShowDialog() == DialogResult.OK)
            {
                if (Codes.Static._countdetail == null)
                {
                    Codes.Static._countdetail = new Forms.CountDetail();
                    Codes.Static._countdetail.MdiParent = this;
                }
                else
                    Codes.Static._countdetail.BringToFront();
                Codes.Static._countdetail.Show();
            }
        }

        private void barSaleDetailView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(31)) return;
            if (Codes.Static._saledetail == null)
            {
                Codes.Static._saledetail = new Forms.SaleDetail();
                Codes.Static._saledetail.MdiParent = this;
            }
            else
                Codes.Static._saledetail.BringToFront();
            Codes.Static._saledetail.Show();
        }

        private void barBalance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(30)) return;
            if (Codes.Static._durgbalanceview == null)
            {
                Codes.Static._durgbalanceview = new Forms.DrugBalanceView();
                Codes.Static._durgbalanceview.MdiParent = this;
            }
            else
                Codes.Static._durgbalanceview.BringToFront();
            Codes.Static._durgbalanceview.Show();
        }

        #region Administrator setting
        private void barPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Printer printer = new Forms.Printer();
            printer.ShowDialog();
        }

        private void barSoftModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Module module = new Forms.Module();
            module.ShowDialog();
        }

        private void barModuleGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ModuleGroup modulegroup = new Forms.ModuleGroup();
            modulegroup.ShowDialog();
        }

        private void barUserGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.UserGroup usergroup = new Forms.UserGroup();
            usergroup.ShowDialog();
        }

        private void barClearData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Settings.ClearData cleardata = new Settings.ClearData();
            cleardata.ShowDialog();
        }
        #endregion

        private void barSalesReturn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(32)) return;
            if (Codes.Static._salesreturn == null)
            {
                Codes.Static._salesreturn = new Forms.SalesReturn();
                Codes.Static._salesreturn.MdiParent = this;
            }
            else
                Codes.Static._salesreturn.BringToFront();
            Codes.Static._salesreturn.Show();
        }

        private void barUserPermission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(42)) return;
            Forms.UserPermission userpermission = new Forms.UserPermission();
            userpermission.ShowDialog();
        }

        private void barDrugBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(56)) return;
            if (Codes.Static._drugreport == null)
            {
                Codes.Static._drugreport = new ReportsForms.DrugReport();
                Codes.Static._drugreport.MdiParent = this;
            }
            else
                Codes.Static._drugreport.BringToFront();
            Codes.Static._drugreport.Show();
        }

        private void barBuyReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(58)) return;
            if (Codes.Static._buyreport == null)
            {
                Codes.Static._buyreport = new ReportsForms.BuyReport();
                Codes.Static._buyreport.MdiParent = this;
            }
            else
                Codes.Static._buyreport.BringToFront();
            Codes.Static._buyreport.Show();
        }

        private void barBuyShot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(59)) return;
            if (Codes.Static._buyshotreport == null)
            {
                Codes.Static._buyshotreport = new ReportsForms.BuyShotReport();
                Codes.Static._buyshotreport.MdiParent = this;
            }
            else
                Codes.Static._buyshotreport.BringToFront();
            Codes.Static._buyshotreport.Show();
        }

        private void barChangePriceReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(62)) return;
            if (Codes.Static._changepricereport == null)
            {
                Codes.Static._changepricereport = new ReportsForms.ChangePriceReport();
                Codes.Static._changepricereport.MdiParent = this;
            }
            else
                Codes.Static._changepricereport.BringToFront();
            Codes.Static._changepricereport.Show();
        }

        private void barSalesReturnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(63)) return;
            if (Codes.Static._salesreturnreport == null)
            {
                Codes.Static._salesreturnreport = new ReportsForms.SalesReturnReport();
                Codes.Static._salesreturnreport.MdiParent = this;
            }
            else
                Codes.Static._salesreturnreport.BringToFront();
            Codes.Static._salesreturnreport.Show();
        }

        private void barSaleReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(60)) return;
            if (Codes.Static._salereport == null)
            {
                Codes.Static._salereport = new ReportsForms.SaleReport();
                Codes.Static._salereport.MdiParent = this;
            }
            else
                Codes.Static._salereport.BringToFront();
            Codes.Static._salereport.Show();
        }

        private void barSaleShot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(61)) return;
            if (Codes.Static._saleshotreport == null)
            {
                Codes.Static._saleshotreport = new ReportsForms.SaleShotReport();
                Codes.Static._saleshotreport.MdiParent = this;
            }
            else
                Codes.Static._saleshotreport.BringToFront();
            Codes.Static._saleshotreport.Show();
        }

        private void barLoanClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(65)) return;
            if (Codes.Static._loanclose == null)
            {
                Codes.Static._loanclose = new Forms.LoanClose();
                Codes.Static._loanclose.MdiParent = this;
            }
            else
                Codes.Static._loanclose.BringToFront();
            Codes.Static._loanclose.Show();
        }

        private void barDrugOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(67)) return;
            if (Codes.Static._drugorder == null)
            {
                Codes.Static._drugorder = new Forms.DrugOrder();
                Codes.Static._drugorder.MdiParent = this;
            }
            else
                Codes.Static._drugorder.BringToFront();
            Codes.Static._drugorder.Show();
        }

        private void barBonusCardReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(68)) return;
            if (Codes.Static._discountcardreport == null)
            {
                Codes.Static._discountcardreport = new ReportsForms.DiscountCardReport();
                Codes.Static._discountcardreport.MdiParent = this;
            }
            else
                Codes.Static._discountcardreport.BringToFront();
            Codes.Static._discountcardreport.Show();
        }

        private void barDiscountDrugReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(69)) return;
            if (Codes.Static._discountdrugreport == null)
            {
                Codes.Static._discountdrugreport = new ReportsForms.DiscountDrugReport();
                Codes.Static._discountdrugreport.MdiParent = this;
            }
            else
                Codes.Static._discountdrugreport.BringToFront();
            Codes.Static._discountdrugreport.Show();
        }

        private void barDiscountDrugMyReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(70)) return;
            if (Codes.Static._mydiscountdrugreport == null)
            {
                Codes.Static._mydiscountdrugreport = new ReportsForms.MyDiscountDrugReport();
                Codes.Static._mydiscountdrugreport.MdiParent = this;
            }
            else
                Codes.Static._mydiscountdrugreport.BringToFront();
            Codes.Static._mydiscountdrugreport.Show();
        }

        private void barFileCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(71)) return;
            SetVNDFile();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "NDFile Create tools.exe";
            startInfo.Arguments = "";
            System.Diagnostics.Process.Start(startInfo);
        }

        private void barDrugOrderReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(72)) return;
            if (Codes.Static._drugorderreport == null)
            {
                Codes.Static._drugorderreport = new ReportsForms.DrugOrderReport();
                Codes.Static._drugorderreport.MdiParent = this;
            }
            else
                Codes.Static._drugorderreport.BringToFront();
            Codes.Static._drugorderreport.Show();
        }

        private void barSaleInvoiceView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(74)) return;
            if (Codes.Static._saleinvoice == null)
            {
                Codes.Static._saleinvoice = new Forms.SaleInvoice();
                Codes.Static._saleinvoice.MdiParent = this;
            }
            else
                Codes.Static._saleinvoice.BringToFront();
            Codes.Static._saleinvoice.Show();
        }

        private void barExpirationDrug_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(76)) return;
            Forms.ExpirationDrug expirationdrug = new Forms.ExpirationDrug();
            expirationdrug.ShowDialog();
        }

        private void barExpirationDrugReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Codes.PharmacyFun._checkPermission(77)) return;
            if (Codes.Static._expirationdrugreport == null)
            {
                Codes.Static._expirationdrugreport = new ReportsForms.ExpirationDrugReport();
                Codes.Static._expirationdrugreport.MdiParent = this;
            }
            else
                Codes.Static._expirationdrugreport.BringToFront();
            Codes.Static._expirationdrugreport.Show();
        }

        private void barSoftAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Settings.SoftAbout softabout = new Settings.SoftAbout();
            softabout.ShowDialog();
        }

        private bool SetVNDFile()
        {
            DBRes._FillTable("SELECT 10 FILEID,B.JorNum JORNO,B.JorDate JORDATE,B.DoctorCipher EMCHNO, "
                + " (D.LastName+' '+D.FirstName)FULLNAME,D.RegNum REGISTERNO,D.EMDNum EMDID,D.NDNum NDDID, "
                + " (SELECT SUM(PriceND-DisCusPrice)a FROM tDiscountSaleDetail WHERE DiscountSaleID=B.DiscountSaleID)NEHNDDUN, "
                + " 0 NEHTUSDUN,0 EB,0 EBNO,0 DT,B.ActionDate,B.DiscountSaleID FROM tDiscountSale B "
                + " INNER JOIN tDiscountCustomer D ON(D.CustomerID=B.CustomerID)", "vNDFMaster");

            DBRes._FillTable("SELECT 1 FILEID,0 JORNO,'2014-04-04' JORDATE,0 EMCHNO, "
                + " ''FULLNAME,'' REGISTERNO,'' EMDID,'' NDDID,0 NEHNDDUN, "
                + " 0 NEHTUSDUN,0 EB,0 EBNO,0 DT, "
                + " 0 EMID1,0 TOO1,0 PHARMAUNE1,0 NDUNE1,0 TUSUNE1, "
                + " 0 EMID2,0 TOO2,0 PHARMAUNE2,0 NDUNE2,0 TUSUNE2, "
                + " 0 EMID3,0 TOO3,0 PHARMAUNE3,0 NDUNE3,0 TUSUNE3, "
                + " '2014-04-04' ActoinDate "
                + " FROM tDiscountSale WHERE 1=-1", "vNDFile");
            for (int i = 0; i < DBRes.DS.Tables["vNDFMaster"].Rows.Count; i++)
            {
                DBRes.DS.Tables["vNDFile"].Rows.Add(
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["FILEID"],
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["JORNO"],
                    Convert.ToDateTime(DBRes.DS.Tables["vNDFMaster"].Rows[i]["JORDATE"]).ToString("yyyy-MM-dd"),
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["EMCHNO"],
                    PharmacyFun.ConverAscii(DBRes.DS.Tables["vNDFMaster"].Rows[i]["FULLNAME"].ToString()),
                    PharmacyFun.ConverAscii(DBRes.DS.Tables["vNDFMaster"].Rows[i]["REGISTERNO"].ToString()),
                    PharmacyFun.ConverAscii(DBRes.DS.Tables["vNDFMaster"].Rows[i]["EMDID"].ToString()),
                    PharmacyFun.ConverAscii(DBRes.DS.Tables["vNDFMaster"].Rows[i]["NDDID"].ToString()),
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["NEHNDDUN"],
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["NEHTUSDUN"],
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["EB"],
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["EBNO"],
                    DBRes.DS.Tables["vNDFMaster"].Rows[i]["DT"],

                    selDisSaleDetail("FileNum", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("FileNum", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("Count", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("Count", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("PriceND", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("PriceND", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("NDTotal", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("NDTotal", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("DisCusPrice", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("DisCusPrice", 1, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",

                    selDisSaleDetail("FileNum", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("FileNum", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("Count", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("Count", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("PriceND", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("PriceND", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("NDTotal", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("NDTotal", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("DisCusPrice", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("DisCusPrice", 2, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",

                    selDisSaleDetail("FileNum", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("FileNum", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("Count", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("Count", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("PriceND", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("PriceND", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("NDTotal", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("NDTotal", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",
                    selDisSaleDetail("DisCusPrice", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() != String.Empty ?
                    selDisSaleDetail("DisCusPrice", 3, Convert.ToInt32(DBRes.DS.Tables["vNDFMaster"].Rows[i]["DiscountSaleID"])).ToString() : "0",

                    Convert.ToDateTime(DBRes.DS.Tables["vNDFMaster"].Rows[i]["ActionDate"]).ToString("yyyy-MM-dd")
                );
            }
            //
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", DBRes.DS.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mvNDFile", CommandType.StoredProcedure)) return true;
            else return false;
            //
        }

        private string selDisSaleDetail(string fieldName, int rowNum, int discountSaleID)
        {
            DBRes._FillTable("SELECT A.DSDetailID,A.DiscountDrugID,(B.FileNum+': '+B.Name)Name,CONVERT(INT,A.Count)Count, "
                + " CONVERT(INT,A.PriceND/A.Count)UnitPrice,B.FileNum, "
                + " CONVERT(INT,A.PriceND)PriceND,CONVERT(INT,A.PriceND-A.DisCusPrice)NDTotal, "
                + " CONVERT(INT,A.DisCusPrice)DisCusPrice FROM tDiscountSaleDetail A "
                + " INNER JOIN tDiscountDrug B ON(B.DiscountDrugID=A.DiscountDrugID) WHERE DiscountSaleID="
                + discountSaleID, "selDisSaleView");
            if (DBRes.DS.Tables["selDisSaleView"].Rows.Count == 1)
            {
                if (rowNum == 2 || rowNum == 3)
                    return String.Empty;
                else return DBRes.DS.Tables["selDisSaleView"].Rows[0][fieldName].ToString();
            }
            else if (DBRes.DS.Tables["selDisSaleView"].Rows.Count == 2)
            {
                if (rowNum == 1)
                    return DBRes.DS.Tables["selDisSaleView"].Rows[0][fieldName].ToString();
                else if (rowNum == 2)
                    return DBRes.DS.Tables["selDisSaleView"].Rows[1][fieldName].ToString();
                else return String.Empty;
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

        private void barBtnLock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loginscreen loginscreen = new Loginscreen();
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.Mainscreen_FormClosing);
            if (loginscreen.ShowDialog() == DialogResult.OK)
                this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainscreen_FormClosing);
            else this.Close();
        }

        private void barManual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSendData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = Program.sendData();
            var resultSend = new JavaScriptSerializer().Deserialize<PosApi.Result>(result);
            if ("True".Equals(resultSend.success))
            {
                MessageBox.Show("Aмжилттай илгээгдлээ!");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void brBtnBillReturn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new Forms.FormBillReturn();
            form.Show();
        }

    }
}
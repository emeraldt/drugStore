using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Pharmacy.Codes
{
    class Information
    {
        public static void ErrorMessage(string text, string caption)
        {
            XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoMessage(string text, string caption)
        {
            XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class PharmacyFun
    {
        /// <summary>
        /// Check user permission - хэрэглэгчийн эрх шалгах функц
        /// </summary>
        /// <param name="moduleID">module id</param>
        /// <returns>true and false</returns>
        public static bool _checkPermission(int moduleID)
        {
            if (DBRes.mUserID != "1")
            {
                DBRes._FillTable("SELECT A.*,B.Permission FROM tModule A INNER JOIN tUserPermission B WITH(NOLOCK) "
                    + " ON(B.ModuleID=A.ModuleID) WHERE A.ModuleID=" + moduleID + " AND B.UserID=" + DBRes.mUserID, "tModule");
                if (DBRes.DS.Tables["tModule"].Rows.Count > 0)
                {
                    if (Convert.ToBoolean(DBRes.DS.Tables["tModule"].Rows[0]["Permission"]))
                        return true;
                    else
                    {
                        Information.ErrorMessage("Уучлаарай та " + DBRes.DS.Tables["tModule"].Rows[0]["ModuleName"].ToString().ToLower() + " эрхгүй байна.", "Хэрэглэгчийн эрх");
                        return false;
                    }
                }
                else
                {
                    Information.ErrorMessage("Уучлаарай та энэ үйлдэл хийх эрхгүй байна.", "Хэрэглэгчийн эрх");
                    return false;
                }
            }
            else return true;
        }

        /// <summary>
        /// check account period - идэвхтэй тооцоогоор хайж тухайн огноо нь тайлант үед хамаарах эсэхийг шалгах функц
        /// </summary>
        /// <returns>true and false</returns>
        public static bool _checkAccountingPeriod(string dateTime)
        {
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE Status=0", "DrugBill");
            if (DBRes.DS.Tables["DrugBill"].Rows.Count > 0)
            {
                DateTime a = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
                DateTime b = Convert.ToDateTime(dateTime);
                if (a.ToString("dd") == b.ToString("dd"))
                    return true;
                else if (b >= a)
                    return true;
                else
                {
                    Information.ErrorMessage("Эмийн тооцооны тайлант үед хамаарахгүй үйлдэл байна.", "Тооцооны тайлант үе");
                    return false;
                }
            }
            else
            {
                Information.ErrorMessage("Тайлант үед хамаарах эмийн тооцоо байхгүй байна. Эмийн тооцоо үүсгэнэ үү.", "Эмийн тооцоо");
                return false;
            }
        }

        /// <summary>
        /// start date account period - эмийн тооцооны эхлэх огноог авдаг функц
        /// </summary>
        /// <returns></returns>
        public static string _startDateAccountPeriod()
        {
            DBRes._FillTable("SELECT * FROM tDrugBill ORDER BY BillID DESC", "DrugBill");
            string startDate = "";
            for (int i = 0; i < DBRes.DS.Tables["DrugBill"].Rows.Count; i++)
            {
                if (!Convert.ToBoolean(DBRes.DS.Tables["DrugBill"].Rows[i]["Status"]))
                    return startDate = DBRes.DS.Tables["DrugBill"].Rows[i]["ActionDate"].ToString();
                else startDate = DateTime.Now.ToString();
            }
            return startDate;
        }

        /// <summary>
        /// balance check - эмийн үлдэгдэл шалгадаг функц
        /// </summary>
        /// <param name="drugID">drug id</param>
        /// <param name="count">drug count</param>
        /// <returns>-1 : ok, -2 : not drug, -3 : not accounting peroid</returns>
        public static decimal balanceCheck(int drugID, decimal count)
        {
            if (!DrugBillV("balanceCheck")) return -3;
            for (int i = 0; i < DBRes.DS.Tables["balanceCheck"].Rows.Count; i++)
            {
                if (Convert.ToInt32(DBRes.DS.Tables["balanceCheck"].Rows[i]["DrugID"]) == drugID)
                {
                    if (Convert.ToDecimal(DBRes.DS.Tables["balanceCheck"].Rows[i]["Balance"]) >= count)
                        return -1;
                    else return Convert.ToDecimal(DBRes.DS.Tables["balanceCheck"].Rows[i]["Balance"]);
                }
            }
            return -2;
        }

        /// <summary>
        /// drug bill view - эмийн тооцоо буюу үлдэгдэл
        /// </summary>
        /// <param name="tableName">table name</param>
        /// <returns>true and false</returns>
        public static bool DrugBillV(string tableName)
        {
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE Status=0", "DrugBill");
            if (DBRes.DS.Tables["DrugBill"].Rows.Count > 0)
            {
                DateTime StartDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
                DateTime EndDate = DateTime.Now;
                int BegInv = 0;
                //
                StartDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
                BegInv = PharmacyFun.GetCountInvoiceID(Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]));
                //
                string cmdText = "SELECT ROW_NUMBER() OVER(ORDER BY A.Name ASC) AS RowNum,A.DrugID,A.Name,A.Size,A.Package,A.Price,A.BaarCode, "
                    + " ISNULL(BegInv.Count,0)BegInv, "
                    + " ISNULL(B.BuyCount,0)BuyCount, "
                    + " ISNULL(C.SaleCount,0)SaleCount, "
                    + " (ISNULL(BegInv.Count,0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))Balance, "
                    + " A.Price*(ISNULL(BegInv.Count,0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))SumTotal"
                + " FROM tDrug A "
                + " LEFT JOIN (SELECT * FROM tCountDetail WHERE CountInvoiceID=" + BegInv + ")BegInv ON(BegInv.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])BuyCount FROM tBuyDetail "
                    + " WHERE ActionDate>='" + StartDate + "' AND ActionDate<='" + EndDate + "' "
                    + " GROUP BY DrugID)B ON(B.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])SaleCount FROM tSaleDetail  "
                    + " WHERE ActionDate>='" + StartDate + "' AND ActionDate<='" + EndDate + "' "
                    + " GROUP BY DrugID)C ON(C.DrugID=A.DrugID) ";
                DBRes._FillTable(cmdText, tableName);
                return true;
            }
            else { Information.ErrorMessage("Тайлант үед хамаарах эмийн тооцоо байхгүй байна.", "Эмийн тооцоо"); return false; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int DrugBillLastID()
        {
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE Status=0", "DrugBill");
            if (DBRes.DS.Tables["DrugBill"].Rows.Count > 0)
                return Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]);
            else
            {
                DBRes._FillTable("SELECT ISNULL(MAX(BillID),0)BillID FROM tDrugBill", "DrugBill");
                return Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["BillID"]);
            }
        }

        /// <summary>
        /// count invoice id - тооллогын id тооцооны хүснэгтээс авах
        /// </summary>
        /// <param name="lastBillID">lastBillID</param>
        /// <returns>CountInvoiceID</returns>
        public static int GetCountInvoiceID(int lastBillID)
        {
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE BillID=" + lastBillID, "DrugBillGetCountInv");
            if (DBRes.DS.Tables["DrugBillGetCountInv"].Rows.Count <= 0)
                return 0;
            else return Convert.ToInt32(DBRes.DS.Tables["DrugBillGetCountInv"].Rows[0]["CountInvoiceID"]);
        }

        public static DateTime GetCountInvoiceDate(int lastBillID)
        {
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE BillID=" + lastBillID, "DrugBillGetCountInv");
            if (DBRes.DS.Tables["DrugBillGetCountInv"].Rows.Count <= 0)
            {
                DBRes._FillTable("SELECT * FROM tDrugBill WHERE lastBillID=" + lastBillID, "DrugBillGetCountInv");
                return Convert.ToDateTime(DBRes.DS.Tables["DrugBillGetCountInv"].Rows[0]["ActionDate"]);
            }
            else return Convert.ToDateTime(DBRes.DS.Tables["DrugBillGetCountInv"].Rows[0]["ActionDate"]);
        }

        /// <summary>
        /// skin load
        /// </summary>
        /// <returns>skin name</returns>
        public static string skinLoad()
        {
            string retVal = "Caramel";
            const string userRoot = @"HKEY_CURRENT_USER\Software\Super_Assist_Systems\Pharmacy";
            try
            {
                return retVal = (string)Microsoft.Win32.Registry.GetValue(userRoot, "SoftwareSkinName", long.MinValue);
            }
            catch (Exception)
            {
                return retVal;
            }
        }

        public static string ConverAscii(string unicodeString)
        {
            return ASCIIEncoding.GetEncoding(28605).GetString(ASCIIEncoding.GetEncoding(1251).GetBytes(unicodeString));
        }

        public static bool LogicControlsPermission()
        {
            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfoLCP");
            return Convert.ToBoolean(DBRes.DS.Tables["SystemInfoLCP"].Rows[0]["LogicControls"]);
        }

    }
}

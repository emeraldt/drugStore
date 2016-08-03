using System;
using System.Text;
using System.Resources;
using System.IO;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
//using Pharmacy.Forms;

namespace Pharmacy.Codes
{
    class Static
    {
        public static DXValidationProvider dxV = new DXValidationProvider();

        #region Content window static variable
        public static Forms.DrugList _druglist = null;
        public static Forms.BuyInvoiceList _buyinvoicelist = null;
        public static Forms.SaleInvoiceList _saleinvoicelist = null;
        public static Forms.DiscountDrugSetting _discountsetting = null;
        public static Forms.DrugBalanceView _durgbalanceview = null;
        public static Forms.SalesReturn _salesreturn = null;
        public static Forms.LoanClose _loanclose = null;
        public static Forms.DrugOrder _drugorder = null;
        public static Forms.SaleInvoice _saleinvoice = null;
        public static Forms.SaleDetail _saledetail = null;
        public static Forms.DiscountCustomerList _discountcustomerlist = null;
        public static Forms.CountDetail _countdetail = null;
        //Report Froms variable
        public static ReportsForms.DrugReport _drugreport = null;
        public static ReportsForms.BuyReport _buyreport = null;
        public static ReportsForms.BuyShotReport _buyshotreport = null;
        public static ReportsForms.SaleReport _salereport = null;
        public static ReportsForms.SaleShotReport _saleshotreport = null;
        public static ReportsForms.ChangePriceReport _changepricereport = null;
        public static ReportsForms.SalesReturnReport _salesreturnreport = null;
        public static ReportsForms.DrugOrderReport _drugorderreport = null;
        public static ReportsForms.DiscountCardReport _discountcardreport = null;
        public static ReportsForms.ExpirationDrugReport _expirationdrugreport = null;
        public static ReportsForms.DiscountDrugReport _discountdrugreport = null;
        public static ReportsForms.MyDiscountDrugReport _mydiscountdrugreport = null;
        //system val
        public static bool MainVal = false;
        public static int Margins = 0;

        #endregion

        /// <summary>
        /// Toon utga hooson esehiig shalgah
        /// </summary>
        /// <param name="txtEd">TextEdit</param>
        /// <param name="ErrorText">Error text</param>
        /// <param name="condition">Condition Operator</param>
        public static void CountValidate(TextEdit txtEd, string ErrorText, ConditionOperator condition)
        {
            if (!txtEd.Enabled) return;
            txtEd.Properties.Mask.EditMask = "d";
            dxV.SetIconAlignment(txtEd, ErrorIconAlignment.MiddleRight);
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = condition;
            notEmptyValidationRule.ErrorText = ErrorText;
            dxV.SetIconAlignment(txtEd, ErrorIconAlignment.MiddleRight);
            dxV.SetValidationRule(txtEd, notEmptyValidationRule);
        }

        /// <summary>
        /// Utga hooson esehiig shalgah
        /// </summary>
        /// <param name="txtEd">TextEdit</param>
        /// <param name="ErrorText">Error text</param>
        /// <param name="condition">Condition Operator</param>
        public static void EmptyValidate(TextEdit txtEd, string ErrorText, ConditionOperator condition)
        {
            if (!txtEd.Enabled) return;
            dxV.SetIconAlignment(txtEd, ErrorIconAlignment.MiddleRight);
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = condition;
            notEmptyValidationRule.ErrorText = ErrorText;
            dxV.SetIconAlignment(txtEd, ErrorIconAlignment.MiddleRight);
            dxV.SetValidationRule(txtEd, notEmptyValidationRule);
        }

        /// <summary>
        /// Create an md5 sum string of this string
        /// </summary>
        /// <param name="str">Md5 bolgoh string</param>
        /// <returns>Md5 string return</returns>
        static public string GetMd5Sum(string str)
        {
            // First we need to convert the string into bytes, which
            // means using a text encoder.
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();
            // Create a buffer large enough to hold the string
            byte[] unicodeText = new byte[str.Length * 2];
            enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);
            // Now that we have a byte array we can ask the CSP to hash it
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);
            // Build the final string by converting each byte
            // into hex and appending it to a StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }
            // And return it
            return sb.ToString();
        }

        /// <summary>
        /// Code encrypt
        /// </summary>
        /// <param name="messageStr">Encrypt message text</param>
        public static StringBuilder _StrEnc(string messageStr)
        {
            string keyStr = "!@#$%^&*()_+|";
            const int EOS = -1; //end of string condition
            StringReader Msr = new StringReader(messageStr);
            StringBuilder OutStr = new StringBuilder();
            // alternatively BinaryReader and BinaryWriter could be used here
            int keyLength = keyStr.Length - 1;
            int index = 0; char ch; int x;
            do
            {
                x = Msr.Read() ^ keyStr[index];     //XOR
                ch = Convert.ToChar(x);
                OutStr.Append(ch);
                index++;
                if (index > keyLength) index = 0;   //start all over with the key               
            } while (Msr.Peek() != EOS);
            return OutStr;
        }

        /// <summary>
        /// Parameter Add
        /// </summary>
        /// <param name="spPCount">Parameter count</param>
        /// <param name="spPName">Parameter name</param>
        /// <param name="spPSDBType">Parameter sqldbtype</param>
        /// <param name="spPValue">Parameter value</param>
        /// <returns>Boolan value return. If ok = true esle no = false</returns>
        public static bool _spParameterAdd(String[] spPName, SqlDbType[] spPSDBType, object[] spPValue)
        {
            StateProcedure _sp;
            DBRes.ParameterList.Clear();
            try
            {
                for (int i = 0; i < spPName.Length; i++)
                {
                    _sp.parameterName = spPName[i];
                    _sp.type = spPSDBType[i];
                    _sp.value = spPValue[i];
                    DBRes.ParameterList.Add(_sp);
                }
                return true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.ToString()); return false; }
        }

    }
}

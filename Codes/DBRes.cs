using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Pharmacy.Settings;

namespace Pharmacy.Codes
{
    public struct StateProcedure
    {
        public string parameterName;
        public object value;
        public SqlDbType type;
    }

    class DBRes
    {
        public static List<StateProcedure> ParameterList = new List<StateProcedure>();
        public static string mServer;
        public static string mDatabase;
        public static string mUserName;
        public static string mPassword;
        public static string mUser;
        public static string mUserID;
        public static int mRole;
        public static string mExText;

        public static SqlConnection sql_conn;
        public static SqlCommand sql_cmd = new SqlCommand();
        //public static SqlDataAdapter sql_da;
        public static DataSet DS = new DataSet();
        public static SqlCommand cmdFill;

        //local val
        public static int CountInvoiceID;
        public static string CountDetailText;

        /// <summary>
        /// SQL Connection _SetConnection()
        /// </summary>
        public static int _SetConnection()
        {
            const string userRoot = @"HKEY_CURRENT_USER\Software\Super_Assist_Systems\Pharmacy";
            int retValue = 1;
            try
            {
                mServer = (string)Registry.GetValue(userRoot, "RegServerName", long.MinValue);
                mDatabase = (string)Registry.GetValue(userRoot, "RegDatabaseName", long.MinValue);
                mUserName = (string)Registry.GetValue(userRoot, "RegUserName", long.MinValue);
                mPassword = (string)Registry.GetValue(userRoot, "RegPassword", long.MinValue);
                mPassword = Static._StrEnc(mPassword).ToString();
                string strconn = String.Format(@"Data Source={0};Initial Catalog={1};User Id={2};Password={3}", mServer, mDatabase, mUserName, mPassword);
                sql_conn = new SqlConnection(strconn);
                sql_conn.Open();
            }
            catch (Exception)
            {
                if (mServer == null)
                {
                    ConfigSetting cs = new ConfigSetting();
                    if (cs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        retValue = 1;
                    else retValue = 0;
                }
                else { Information.ErrorMessage("Сервер төхөөрөмжийн холболтоо шалгана уу!!!", "Серверийн холболт"); return retValue = 0; }
            }
            return retValue;
        }

        /// <summary>
        /// DataSet fill table
        /// </summary>
        /// <param name="sSQL">String SQL Command</param>
        /// <param name="sTable">String fill table name</param>
        public static string _FillTable(string sSQL, string sTable)
        {
            if (sSQL.Length > 0 && sTable.Length > 0)
            {
                if (DS.Tables.IndexOf(sTable) != -1)
                {
                    DS.Tables.Remove(sTable);
                }

                cmdFill = new SqlCommand(sSQL, sql_conn);
                SqlDataAdapter DA = new SqlDataAdapter();
                DA.SelectCommand = cmdFill;

                try
                {
                    DA.Fill(DS, sTable);
                }
                catch (Exception ex)
                {
                    DA.Dispose();
                    cmdFill.Dispose();
                    return ex.Message;
                }
                DA.Dispose();
                cmdFill.Dispose();
            }
            return "";
        }

        /// <summary>
        /// Parameter Procedure function
        /// </summary>
        /// <param name="ProcedureName">Procedure Name</param>
        public static Boolean _ParamProcedure(string ProcedureName, CommandType CommandType)
        {
            foreach (StateProcedure item in ParameterList)
            {
                AddParameter(item.parameterName, item.type, item.value);
            }
            sql_cmd.CommandType = CommandType;
            sql_cmd.Connection = sql_conn;
            sql_cmd.CommandText = ProcedureName;
            try
            {
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Parameters.Clear();
                return true;
            }
            catch (SqlException ex)
            {
                mExText = ex.Message;
                sql_cmd.Parameters.Clear();
                return false;
            }
        }

        /// <summary>
        /// Add parameter function
        /// </summary>
        /// <param name="dbType">Database data type</param>
        public static void AddParameter(string ParameterName, SqlDbType dbType, object Value)
        {
            switch (dbType)
            {
                case SqlDbType.TinyInt:
                case SqlDbType.SmallInt:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Convert.ToInt16(Value);
                    break;
                case SqlDbType.Int:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Convert.ToInt32(Value);
                    break;
                case SqlDbType.BigInt:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Convert.ToInt64(Value);
                    break;
                case SqlDbType.Bit:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Convert.ToBoolean(Value);
                    break;
                case SqlDbType.Char:
                case SqlDbType.NChar:
                case SqlDbType.Text:
                case SqlDbType.NText:
                case SqlDbType.VarChar:
                case SqlDbType.NVarChar:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Value.ToString();
                    break;
                case SqlDbType.Timestamp:
                case SqlDbType.Time:
                case SqlDbType.Date:
                case SqlDbType.DateTime:
                case SqlDbType.DateTime2:
                case SqlDbType.DateTimeOffset:
                case SqlDbType.SmallDateTime:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Convert.ToDateTime(Value);
                    break;
                case SqlDbType.Decimal:
                case SqlDbType.Float:
                case SqlDbType.Real:
                    if (Value.ToString() == "") sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = DBNull.Value;
                    else sql_cmd.Parameters.Add("@" + ParameterName, dbType).Value = Convert.ToDecimal(Value);
                    break;
                case SqlDbType.Image:
                    break;
                case SqlDbType.Money:
                case SqlDbType.SmallMoney:
                    break;
                case SqlDbType.Binary:
                case SqlDbType.VarBinary:
                    break;
                case SqlDbType.Structured:
                    break;
                case SqlDbType.Udt:
                    break;
                case SqlDbType.UniqueIdentifier:
                    break;
                case SqlDbType.Variant:
                    break;
                case SqlDbType.Xml:
                    break;
                default:
                    break;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Pharmacy.Codes;

namespace Pharmacy
{
    static class Program
    {
        public const string AppName = "Pharmacy";
        private static readonly Mutex mutex = new Mutex(true, Program.AppName);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <summary>
        /// Хэрэглэгчийн системээс бараа, үйлчилгээ борлуусан мэдээллийг JSON string төрөлтэйгээр 
        /// хүлээн авч буцаан баримтын дахин давтагдашгүй дугаар, сугалааны дугаар, гүйлгээ хийсэн огноо, 
        /// баримтын код, QrCode гэсэн утгуудыг нэмж боловсруулах метод
        /// </summary>
        /// <param name="message">JSON string</param>
        /// <returns>
        /// JSON string төрөлтэйгээр баримтын дахин давтагдашгүй
        /// дугаар, сугалааны дугаар, гүйлгээ хийсэн огноо, 
        /// баримтын код, QrCode гэсэн утгуудыг нэмж боловсруулах метод
        /// </returns>
        [DllImport(
            "PosAPI.dll",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.Cdecl
           )]

        [return: MarshalAs(
            UnmanagedType.BStr
            )]
        public static extern string put(String message);

        /// <summary>
        /// Бараа, үйлчилгээ борлуулсан баримтыг хүчингүй болгох метод.
        /// Бараа, үйлчилгээ борлуулсан баримтыг хэсэгчлэн буцааж /10 ширхэг бараанаас зөвхөн 1 ширхэг бараа гэх мэт/ болохгүй. 
        /// Учир нь НӨАТУС-ийн баримтын буцаалт нь тухайн баримтыг шууд хүчингүй баримт болгох бөгөөд тухайн баримтын сугалааг хүчингүй гэж үзнэ. 
        /// Хэрэв хэсэгчлэн буцаасан бол тухайн баримтыг буцаан шинээр баримт хэвлэж өгнө.
        /// </summary>
        /// <param name="message">JSON string Баримтын дугаар</param>
        /// <returns>JSON string</returns>
        [DllImport("PosAPI.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string returnBill(String message);

        /// <summary>
        ///Бүртгэсэн бараа, үйлчилгээ борлуулсан баримтыг НӨАТУС-д илгээх зорилготой. Шидэх үйлдлийг хийхийн тулд тухайн бүртгэлийн машин нь internet сүлжээнд холбогдсон байх ёстой.
        ///Хэрэв тухайн бүртгэлийн машинд PosAPI 2.0 санг шинээр суурьлуулсан бол
        ///sendData method-ийг заавал нэг удаа хоосон дуудна. Ингэснээр НӨАТУС-д тухайн PosAPI-г бүртгүүлж, шаардлагатай тохиргооны мэдээллийг татана.
        /// </summary>
        /// <returns>JSON string</returns>
        [DllImport("PosAPI.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string sendData();
        /// <summary>
        /// Хэрэглэгчийн системийн тогтвортой ажиллагааг хангах шаардлагын улмаас PosAPI сангийн ажиллагааг шалгана. Хэрэглэгчийн системийг ажиллуулж буй үйлдлийн системийн хэрэглэгч нь заавал өөрийн HOME directory-той байх ёстой. Хэрэв уг шаардлагыг хангаагүй бол уг функц нь амжилтгүй гэсэн утгыг буцаана.
        /// </summary>
        /// <returns></returns>
        [DllImport("PosAPI.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string checkApi();
        /// <summary>
        /// Хэрэглэгчийн систем нь нэгээс олон PosAPI ашиглаж буй үед харьцаж буй PosAPI-гийн мэдээллийг харах шаардлага тулгардаг. Уг функц нь уг асуудлыг шийдэж буй бөгөөд уг функцийн тусламжтайгаар хэрэглэгчийн систем нь тухайн ашиглаж буй PosAPI-гийн дотоод мэдээллүүдийг авна.
        /// </summary>
        /// <returns></returns>
        [DllImport("PosAPI.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string getInformation();

        /// <summary>
        /// PosAPI нь цаашид шинээр нэмэлт функцүүд нэмэгдэх бөгөөд нэмэгдсэн функцийг ашиглахын тулд заавал өөрийн PosAPI-г шинээр татах шаардлаггүй юм. Уг нэмэлт функцүүдийг уг функцийн тусламжтайгаар дуудана.
        /// </summary>
        /// <param name="funcName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        [DllImport(
            "PosAPI.dll",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.Cdecl
           )]
        [return: MarshalAs(
            UnmanagedType.BStr
            )]
        public static extern string callFunction(string funcName, string param);


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            Properties.Settings setting = new Properties.Settings();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Codes.PharmacyFun.skinLoad();

            if (!mutex.WaitOne(TimeSpan.Zero, true))
            { DevExpress.XtraEditors.XtraMessageBox.Show("Програм ачаалсан байна.", "Програм", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            DBRes._SetConnection();
            if (SAS.CheckKey.Member(AppName, DBRes.mServer, DBRes.mDatabase, DBRes.mUserName, DBRes.mPassword))
            {
                Loginscreen ls = new Loginscreen();
                if (ls.ShowDialog() == DialogResult.OK)
                {
                    Codes.DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");
                    if (Codes.DBRes.mRole != 3)
                    {
                        Mainscreen ms = new Mainscreen();
                        ms.ShowDialog();
                    }
                    else
                    {
                        Switchscreen swt = new Switchscreen();
                    load:
                        DialogResult drt = swt.ShowDialog();
                        if (drt == DialogResult.Abort)
                        {
                            Mainscreen ms = new Mainscreen();
                            ms.ShowDialog();
                            goto load;
                        }
                        else if (drt == DialogResult.OK)
                        {
                            Pos.Normal nor = new Pos.Normal();
                            if (Convert.ToBoolean(Codes.DBRes.DS.Tables["SystemInfo"].Rows[0]["PosWin"]))
                            {
                                nor.FormBorderStyle = FormBorderStyle.None;
                                nor.WindowState = FormWindowState.Maximized;
                            }
                            nor.ShowDialog();
                            goto load;
                        }
                        else if (drt == DialogResult.Yes)
                        {
                            Pos.Discount dc = new Pos.Discount();
                            if (Convert.ToBoolean(Codes.DBRes.DS.Tables["SystemInfo"].Rows[0]["DisPosWin"]))
                            {
                                dc.FormBorderStyle = FormBorderStyle.None;
                                dc.WindowState = FormWindowState.Maximized;
                            }
                            dc.ShowDialog();
                            goto load;
                        }
                    }
                }
            }
        }
    }
}

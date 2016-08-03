﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.PosApi
{
    /// <summary>
    /// API - с буцаах сугалааны дугаар, баримтын дугаар, алдааны мессеж г.м
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Баримтын дугаар
        /// </summary>
        public string billId;
        /// <summary>
        ///  Баримтын НӨАТ агуулаагүй хөлийн дүн
        /// </summary>
        public string amount;
        /// <summary>
        /// Бэлэн төлбөрийн дүн
        /// </summary>
        public string cashAmount;
        /// <summary>
        /// Бэлэн бус төлбөрийн дүн
        /// </summary>
        public string nonCashAmount;
        /// <summary>
        /// Баримтын НӨАТ дүн   
        /// </summary>
        public string vat;
        /// <summary>
        /// Баримт хэвлэсэн огноо
        /// </summary>
        public string date;
        /// <summary>
        /// TicketId, lottery, merchantId, хөлийн дүн талбаруудыг агуулсан дотоод кодчилол
        /// </summary>
        public string internalCode;
        /// <summary>
        /// Сугалааны дугаар
        /// </summary>
        public string lottery;
        /// <summary>
        /// НӨАТУС-системд үүсгэсэн Merchant-ийн дугаар
        /// </summary>
        public string merchantId;
        /// <summary>
        /// Баримтан дээр хэвлэгдэх QR code
        /// </summary>
        public string qrData;
        /// <summary>
        /// Нийслэл хотын албан татвар
        /// </summary>
        public string cityTax;
        /// <summary>
        /// Бэлэн бус гүйлгээний мэдээлэл
        /// </summary>
        public List<BillBankTransaction> bankTransactions;
        /// <summary>
        /// Авсан бараа үйлчилгээ
        /// </summary>
        public List<BillDetail> stocks;
        /// <summary>
        /// Алдааны код
        /// </summary>
        public string errorCode;
        /// <summary>
        /// Алдааны мессеж
        /// </summary>
        public string message;
        /// <summary>
        /// Амжилттай татсан буюу Амжилттай буцаасан
        /// </summary>
        public string success;
        /// <summary>
        /// Алдаа болон анхрааруулгын мессеж
        /// </summary>
        public string warningMsg;
        /// <summary>
        /// Сугалаа өгөх боломжгүй болсон тухайн тайлбар анхааруулга мессеж
        /// </summary>
        public string lotteryWarningMsg;

        public string customerNo;

        public string customerName;

        public string billType;
    }
}

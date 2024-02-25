using System.Collections.Generic;

namespace FarsiLibrary.Utils
{
    internal class PersianMonthNames
    {
        #region Fields

        public string Vray = "وری";
        public string Ghoyay = "غويئ";
        public string Ghbargolay = "غبرګولی";
        public string Chongash = "چنګاښ";
        public string Zmaray = "زمری";
        public string Wazhay = "وږی";
        public string Tala = "تله";
        public string Laram = "لړم";
        public string Laynday = "لېند";
        public string Marghmay = "مرغومی";
        public string Salwagha = "سلواغه";
        public string Kab = "کب";
        private readonly List<string> months;
        private static PersianMonthNames instance;

        #endregion

        #region Ctor

        private PersianMonthNames()
        {
            months = new List<string>
                         {
                             Vray,
                             Ghoyay,
                             Ghbargolay,
                             Chongash,
                             Zmaray,
                             Wazhay,
                             Tala,
                             Laram,
                             Laynday,
                             Marghmay,
                             Salwagha,
                             Kab,
                             ""
                         };
        }

        #endregion

        #region Singleton

        public static PersianMonthNames Default
        {
            get
            {
                if (instance == null)
                    instance = new PersianMonthNames();

                return instance;
            }
        }

        #endregion

        #region Indexer

        internal List<string> Months
        {
            get { return months; }
        }

        public string this[int month]
        {
            get { return months[month]; }
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SaglikApp.Utility
{
    public class Utility
    {
        /// <summary>
        /// Convert English Month Name In Turkish
        /// </summary>
        /// <param name="MonthNameInEnglish"></param>
        /// <returns></returns>
        public static string ConvertMonthIntoTrukishLanguage(string MonthNameInEnglish)
        {
            string MonthNameInTurkish = string.Empty;
            if (MonthNameInEnglish.Contains("January") || MonthNameInEnglish.Contains("1"))
                MonthNameInTurkish = "Ocak";
            if (MonthNameInEnglish.Contains("February") || MonthNameInEnglish.Contains("2"))
                MonthNameInTurkish = "Şubat";
            if (MonthNameInEnglish.Contains("March") || MonthNameInEnglish.Contains("3"))
                MonthNameInTurkish = "Mart";
            if (MonthNameInEnglish.Contains("April") || MonthNameInEnglish.Contains("4"))
                MonthNameInTurkish = "Nisan";
            if (MonthNameInEnglish.Contains("May") || MonthNameInEnglish.Contains("5"))
                MonthNameInTurkish = "Mayıs";
            if (MonthNameInEnglish.Contains("June") || MonthNameInEnglish.Contains("6"))
                MonthNameInTurkish = "Haziran";
            if (MonthNameInEnglish.Contains("July") || MonthNameInEnglish.Contains("7"))
                MonthNameInTurkish = "Temmuz";
            if (MonthNameInEnglish.Contains("August") || MonthNameInEnglish.Contains("8"))
                MonthNameInTurkish = "Ağustos";
            if (MonthNameInEnglish.Contains("September") || MonthNameInEnglish.Contains("9"))
                MonthNameInTurkish = "Eylül";
            if (MonthNameInEnglish.Contains("October") || MonthNameInEnglish.Contains("10"))
                MonthNameInTurkish = "Ekim";
            if (MonthNameInEnglish.Contains("November") || MonthNameInEnglish.Contains("11"))
                MonthNameInTurkish = "Kasım";
            if (MonthNameInEnglish.Contains("December") || MonthNameInEnglish.Contains("12"))
                MonthNameInTurkish = "Aralık";
            return MonthNameInTurkish;
        }

        /// <summary>
        /// TODO : To Generate Image through Base 64...
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        public static Xamarin.Forms.ImageSource GetImageFromBase64(string base64)
        {
            byte[] Base64Stream = Convert.FromBase64String(base64);
            var image = Xamarin.Forms.ImageSource.FromStream(() => new MemoryStream(Base64Stream));
            return image;
        }
    }
}

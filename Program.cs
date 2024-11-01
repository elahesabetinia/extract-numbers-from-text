using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Extract numbers that have conditions (start with zero, have ten digits and at least two repeated digits)");
        Console.WriteLine("Hello, my phone number is 0123456789, my address is rue Voltaire 145.  \nthe number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question \nthe number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question \nOur customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899 ");
        string input = "Hello, my phone number is 0123456789, my address is rue Voltaire 145. " +
                       "the number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question " +
                       "the number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question " +
                       "Our customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899";

        // الگوی ساده برای یافتن شماره‌های تلفن که با صفر شروع می‌شوند و ده رقم دارند
        string pattern = @"0\d{9}";

        // جستجو و استخراج شماره‌ها از متن
        MatchCollection matches = Regex.Matches(input, pattern);

        // بررسی و چاپ شماره‌هایی که حداقل دو رقم متفاوت دارند
        foreach (Match match in matches)
        {
            string phoneNumber = match.Value;
            if (HasAtLeastTwoDifferentDigits(phoneNumber))
            {
                Console.WriteLine(phoneNumber);
            }
        }
    }

    // بررسی ساده برای داشتن حداقل دو رقم متفاوت
    static bool HasAtLeastTwoDifferentDigits(string phoneNumber)
    {
        char firstDigit = phoneNumber[0];
        foreach (char digit in phoneNumber)
        {
            if (digit != firstDigit) return true; // اگر یک رقم متفاوت یافت شد، نتیجه true برگرداند
        }
        return false;
    }
}

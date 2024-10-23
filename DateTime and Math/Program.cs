using System.Globalization;

string? s = Console.ReadLine();
string result = ProjeDeneme.timeConversion(s); 
Console.WriteLine(result);
class Pratikler{
// DateTime & Math
static void Date(){
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToShortTimeString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(2));
Console.WriteLine(DateTime.Now.AddSeconds(2));
Console.WriteLine(DateTime.Now.AddMonths(3));

//DateTime Formatting
Console.WriteLine(DateTime.Now.ToString("dd"));
Console.WriteLine(DateTime.Now.ToString("ddd"));
Console.WriteLine(DateTime.Now.ToString("dddd"));
Console.WriteLine(DateTime.Now.ToString("hh"));

//Math 

Console.WriteLine(Math.Abs(-25)); //Mutlak Değer
Console.WriteLine(Math.Sin(90));
Console.WriteLine(Math.Cos(90));
Console.WriteLine(Math.Tan(90));

Console.WriteLine(Math.Ceiling(22.3)); //Yukarı Yuvarlama
Console.WriteLine(Math.Round(22.6)); //Yakın olana Yuvarlama
Console.WriteLine(Math.Floor(22.3)); //Aşağı Yuvarlama

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));
Console.WriteLine(Math.Pow(3,4));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(10,10));
Console.WriteLine(Math.Exp(3));


string a = "07:05:45PM";
string b;
b=Convert.ToString(DateTime.Parse(a));
int found =b.IndexOf(" ");
Console.WriteLine("{0}", b.Substring(found+1));
}
}


class ProjeDeneme{
    public static string timeConversion(string? s)
    {
         if (string.IsNullOrEmpty(s))
        {
            throw new ArgumentException("Input string cannot be null or empty");
        }
        DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);

        return dateTime.ToString("HH:mm:ss");
    }
}


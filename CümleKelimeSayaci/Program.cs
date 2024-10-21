Console.WriteLine("Bir cümle giriniz");
string ?cumle = Console.ReadLine();

try
{
    Odev.KelimeSayaci(cumle);

}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}


class Odev{
    public static void KelimeSayaci(string? a)
    {
        if (string.IsNullOrWhiteSpace(a))
        {
            Console.WriteLine("Lütfen bir cümle giriniz.");
            return;
        }

        int harfSayisi = 0;
        int kelimeSayisi= a.Split(' ').Length;

        foreach (char item in a)
        {
            if(char.IsLetter(item)){
                harfSayisi++;
            }
        }
        Console.WriteLine("Kelime Sayısı: " + kelimeSayisi);
        Console.WriteLine("Harf Sayısı: " + harfSayisi);
    }
}
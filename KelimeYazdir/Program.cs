bool isValid = false;
int n = 0;

while(!isValid)
    {
        try
        {   
            Console.WriteLine("Sayı Giriniz: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n<=0)
            {
                throw new Exception("Lütfen pozitif sayı giriniz.");
            }

            isValid = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Lütfen Geçerli bir sayı giriniz");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
Odev.KelimeYazdir(n);

class Odev {
    public static void KelimeYazdir(int a) {
        string[] dizi = new string[a];
        for(int i = 0; i<a;i++){
            Console.Write("{0}. kelimeyi girin: ", i + 1);
            string? input = Console.ReadLine();

            if(input == null){
                throw new Exception("Lütfen kelime giriniz.");
            }
            dizi[i] = input;
        }
        foreach (var item in dizi)
        {
            Console.Write("{0} " ,item);
        }
    }
}

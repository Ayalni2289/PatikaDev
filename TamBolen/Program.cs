Console.WriteLine("İki Adet Sayı Giriniz, İlki kaç adet sayı gireceğinizi belirler, İkincisi ise tam bölenini belirler: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());


try
{
    Odev.Tambolen(x,y);
}
catch (Exception ex)
{
    Console.WriteLine("Hata:" + ex.Message);
}



class Odev {

    public static void Tambolen(int a, int b){
        if(a<=0 || b<=0){
                throw new Exception("Lütfen pozitif sayı giriniz.");
        }
        
        int[] sayilar = new int[a];
        for(int i=0;i<a;i++){
             Console.Write("{0}. sayıyı girin: ", i + 1);
             sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (var item in sayilar)
        {
            if(item % b ==0){
                Console.WriteLine("Tam Bölenler: {0} " ,item);
            }
        }
    }
}


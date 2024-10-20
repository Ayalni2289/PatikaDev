Console.WriteLine("Kaç tane sayi girmek istersiniz ? ");
int a = Convert.ToInt32(Console.ReadLine());
Odev.Twin(a);


public class Odev{
    public static void Twin(int n){
        int[] sayilar = new int[n];
        for(int i=0;i<n;i++){
             Console.Write("{0}. sayıyı girin: ", i + 1);
             sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int sayi in sayilar)
        {
            if(sayi%2==0){
                Console.WriteLine("Çift Sayılar: {0} " ,sayi);
            }
        }
    }
}

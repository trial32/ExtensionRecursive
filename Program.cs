// See https://aka.ms/new-console-template for more information

//3 üzeri 4 işlemini normal yolla yapalım
int result=1;
for (int i = 0; i < 4; i++)
{
    result*=3;
}

Console.WriteLine(result);

Console.WriteLine(new Islemler().Expo(3,4)); //Recursive ile yapıp yazdır

//Extension Methoları kullanma

string s= "Ozen Deniz";

if (s.CheckSpaces())
    Console.WriteLine("WHITE SPACE VAR");
else 
    Console.WriteLine("WHITE SPACE YOK");


int sayi=57;

if (sayi.CheckIfEven())
    Console.WriteLine("ÇİFT SAYI");
else 
    Console.WriteLine("TEK SAYI");

int [] sayilar={6,3,3,9,10,8};
sayilar.DisplayArray();
sayilar.SortArray();
sayilar.DisplayArray();
class Islemler {

    public int Expo (int sayi, int us){
        
        if (us<2)
            return sayi;

        return Expo (sayi, us-1) * sayi;
    } 
}


public static class ExtensionMetodlar {

    public static bool CheckSpaces (this string veri){

        return veri.Contains(" ");
    } 

    public static bool CheckIfEven (this int sayi){

        return sayi%2==0;
    }

    public static int[] SortArray (this int[] veriler){

        Array.Sort(veriler);
        return veriler;
    }

    public static void DisplayArray ( this int[] veriler){

        foreach (var item in veriler)
        {
            Console.WriteLine(item);
        }

    }
}
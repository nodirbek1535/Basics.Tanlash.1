using System;
Console.WriteLine("ushbu dastur mohirdev praktikum kurslari Basics.Tanlash qismining 1-topshiriqlari uchun yaratildi.");
Console.WriteLine("1-masala String ustida amallar.");
Console.WriteLine("2-masala Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.");
Console.WriteLine("3-masala hafta kunlarini tarjima qiluvchi dastur");
Console.WriteLine("qaysi masalani tekshirib kormoqchisiz");
while (true)
{
int a=int.Parse(Console.ReadLine());
switch(a)
{
    case 1:
        Console.WriteLine("siz birinchi dasturdasiz;");
        Console.WriteLine("stringni kiriting");
        string str=Console.ReadLine();
        Console.WriteLine("sonni kiriting");
        int nums=int.Parse(Console.ReadLine());
        if(str.Length<nums)
        {
        Console.WriteLine("output is >>>>>>>>   "+str.ToLower());
        }
        else
        {
        Console.WriteLine("output is >>>>>>>>   "+str.ToUpper());
        }
        Console.WriteLine("1-dastur yakunlandi(boshqa masalalarni ham ishlatib korishingiz mumkin)");
    break;
    case 2:
        Console.WriteLine("siz ikkinchi  dasturdasiz;");
        int x=15;
        int y=10;
        string result;
        if(x>y)
        {
            result="x is greater than y";
        }
        else if(x<y)
        {
            result="x is less than y";
        }
        else if(x==y)
        {
            result="x is equal to y";
        }
        else
        {
            result="x and y are not comprable";
        }
        Console.WriteLine(result);
        Console.WriteLine("2-dastur yakunlandi boshqa masalalarni ham ishlatib korishingiz mumkin)");
    break;
    case 3:
         Console.WriteLine("siz uchinchi  dasturdasiz;");
         Console.WriteLine("hafta kunini kiriting(etiborli boling grammatik xatolarga yol qoymang!!! for ex(Dushanba)):");
         string input=Console.ReadLine();
         input=input.ToLower();
         string output=input switch
         {
            "dushanba"=>"Monday",
            "seshanba"=>"Tuesday",
            "chorshanba"=>"Wednesday",
            "payshanba"=>"Thursday",
            "juma"=>"Friday",
            "shanba"=>"Saturday",
            "yakshanba"=>"Sunday",
            _=>"menimcha siz grammatik xatoga yo'l qoydingiz menimcha"
         };
         Console.WriteLine(output);
         Console.WriteLine("3-dastur yakunlandipk boshqa masalalarni ham ishlatib korishingiz mumkin)");
    break;
    default:
    Console.WriteLine("bunday masala mavjud emas iltimos berilgan masalani tanlang");
    break;
}
}

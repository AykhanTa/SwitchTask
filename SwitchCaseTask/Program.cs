// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task1
//double a = 1.5;
//double b = 2;
//double d = 2;
//double e=2.5;//a-skafin eni; b-skafin uzunu; d-qapinin eni; e-qapinin uzunu
//if (a<=d && b <= e)
//{
//    Console.WriteLine("Kececek");
//}
//else if(a<=e && b<=d) //90 derece firlatdiqdan sonra
//{
//    Console.WriteLine("Kececek");
//}
//else
//{
//    Console.WriteLine("Kecmiyecek");
//}

#endregion

#region Task2
int n = 64;
int quvvet = 1;
while(n > quvvet)
{
    quvvet *= 2;
}
if (quvvet==n)
{
    Console.WriteLine("2 quvvetidir");
}
else
{
    Console.WriteLine("2 quvveti deyil");
}
#endregion

#region Task3
//int n = 23452;
//int count = 0;
//while (n>0)
//{
//    n/= 10;
//    count++;
//}
//Console.WriteLine(count);
#endregion
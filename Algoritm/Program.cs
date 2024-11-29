Console.WriteLine("Algoritmik masalalar yechish.");

//1 dan n gacha solar ko'paytmasini hisoblash.
Console.Write("n=");

int n = int.Parse(Console.ReadLine());
int p = 1;

for (int i = 1; i <= n; i++)
    p = p * i;

Console.WriteLine($"1 dan {n} gacha sonlar ko'paytmasi P={p} ga teng");



////1 dan n gacha solar yig'indisini hisoblash.
//Console.Write("n=");

//int n=int.Parse(Console.ReadLine());

//int s=0; 

//for (int i=1; i<=n; i++)
//  s=s+i; 

//Console.WriteLine($"1 dan {n} gacha sonlar tig'indisi S={s} ga teng");



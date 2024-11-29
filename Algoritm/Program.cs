Console.WriteLine("Algoritmik masalalar yechish.");

//1 dan n gacha solar yig'indisini hisoblash.
Console.Write("n=");

int n=int.Parse(Console.ReadLine());

int s=0; 

for (int i=1; i<=n; i++)
  s=s+i; 

Console.WriteLine($"1 dan {n} gacha sonlar tig'indisi S={s} ga teng");

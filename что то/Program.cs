// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int [] Z = new int [35];
int S = 0;
int P = 0; 
int R = 0;
Random rnd = new Random();
Console.WriteLine("mas");
for (int i=0; i < 35; i++)
{
    Z[i] = rnd.Next(-20,20);
    Console.Write(Z[i] + "");
}
Console.WriteLine();
for (int i = 0; i < 35; i++){
if (((Z[i] % 2) == 0) && (Z[i] < 3));
    S += Z[i];

}
for (int i = 0; i < 35; i++){

if (((Z[i] % 2) != 0) && (Z[i] > 1)){
    P *= Z[i];
    R = P + S;
    }
}
Console.WriteLine("Сумма = " + R);
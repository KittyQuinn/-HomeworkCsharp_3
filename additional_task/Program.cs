// Напишите программу, которая на вход принимает радиус круга и 
// находит его площадь округленную до целого числа, необходимо вывести 
// максимальную цифру в полученном округлённом значении площади круга
// 10 -> 4
// 20 -> 7
// 30 -> 8

// double square = Math.Round(s,0);

Console.Clear();
Console.WriteLine("Type radius ");
int r = int.Parse(Console.ReadLine());
double p = 3.14;
double s = p * Math.Pow(r,2);

int sq = Convert.ToInt32(s);
Console.WriteLine(sq);

string square = sq.ToString();
int i = 0;
int max = int.Parse(square[i].ToString());
int length = square.Length;

while (i<length)
{
    {
    if (int.Parse(square[i].ToString()) > max) 
        {
        max = int.Parse(square[i].ToString());
        }
    }
    i++;
}
Console.WriteLine(max);






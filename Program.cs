// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool Palindrome (int number)
{
    bool result = false;
    int digit1 = number / 10000;
    int digit2 = number % 10;
    if (digit1 == digit2)
    {
        digit1 = number / 1000 % 10;
        digit2 = number / 10 % 10;
        if (digit1 == digit2)
        {
            result = true;
        }
    }
    return result;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrome(num));
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (int[] dot1, int[] dot2)
{
    int diffX = dot1[0] - dot2[0];
    int diffY = dot1[1] - dot2[1];
    int diffZ = dot1[2] - dot2[2];
    double result = Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
    return result;
}
Console.Write("Input coordinates dot A: ");
string numb1 = Console.ReadLine();
int[] dotA = new int[3]{Convert.ToInt32(numb1)};
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinates dot B: ");
int[] dotB = new int[3]{2, 1, -7};
Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distance(dotA, dotB));
*/


void StringToArrayInt (string str, string search, int[] array)
{
    int j = 0;
    int k = 0;
    for(int i = str.IndexOf(search); i < str.Length; i = i + search.Length)
    {
        array[j] = Convert.ToInt32(str.Substring(k, i));
        j++;
        k = k + i;
    }
}
Console.Write("Input coordinates dot A: ");
string str = Console.ReadLine();
string search = ",";
int[] arr = new int[5];
StringToArrayInt(str, search, arr);
Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " ");
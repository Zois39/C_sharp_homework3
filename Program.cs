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
string ReadCoordinate (string str)
{
    Console.Write(str);
    return Console.ReadLine();
}
char chr = ',';
int[] StrToArrInt (string str, char chr)
{
    string temp = "";
    int[] arr = new int[3];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == chr)
        {
            arr[j] = Convert.ToInt32(temp);
            temp = "";
            j++;
        }
        else
            temp = temp + str[i];
    }
    arr[j] = Convert.ToInt32(temp);
    return arr;
}
string dotA = ReadCoordinate ("Input coordinate X,Y,Z dot A: ");
string dotB = ReadCoordinate ("Input coordinate X,Y,Z dot B: ");
int[] coordinatesA = StrToArrInt(dotA, chr);
int[] coordinatesB = StrToArrInt(dotB, chr);
Console.WriteLine(Distance(coordinatesA, coordinatesB));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int ReadCoordinate (string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
void CubeTable (int num)
{
    for (int i = 1; i < num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)},");
    }
    Console.Write($"{Math.Pow(num, 3)}");
}
CubeTable(ReadCoordinate("Input number: "));
*/
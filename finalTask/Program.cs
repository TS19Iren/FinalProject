/*Написать прогрумму, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать  на старте
выполнение алгоритма.*/

string[] GenerateArray(int length)
{   
    char[] alphabetAndSimbols = new char[26];
    int i =0;
    for (char a = 'a'; a <= 'z'; a++)
    {
        alphabetAndSimbols[i] = a;
        i++;
    }
    string[] array = new string[length];


    Random rndPosition = new Random(); //для случайной позиции в массиве char
    Random rndStringLength = new Random(); //для длины генерируемой строки
    
    for (int j = 0; j < length; j++)
    {
        string generatedString = "";
        int stringLength = rndStringLength.Next(1,10);
        for (int k = 0; k < stringLength; k++)
        {
            int charPosition = rndPosition.Next(0,alphabetAndSimbols.Length-1);
            generatedString = generatedString+alphabetAndSimbols[charPosition];
        }
    array[j] = generatedString;
        
    }
    return array;
    
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine(" ]");
}

string[] GetArraySmallerThan3 (string[] bigArray) 

{   
    int count = 0;
    for (int i = 0; i < bigArray.Length; i++)
    {
        if(bigArray[i].Length<=3) count++;
        
    }
string[] arraySmallerThan3 = new string[count];
count = 0;
for (int j = 0; j < bigArray.Length; j++)
{
    if(bigArray[j].Length<=3) {
        arraySmallerThan3[count]=bigArray[j];
        count++;
    }
}
return arraySmallerThan3;
}

Console.WriteLine("Сгенерированный массив строк: ");
string[] bigArray = GenerateArray(5);
PrintArray(bigArray);
Console.WriteLine("Полученный массив строк: ");
string[] arraySmallerThan3 = GetArraySmallerThan3(bigArray);
PrintArray(arraySmallerThan3);


using System.Runtime.Serialization.Formatters;

string[] InputStringArray = GetInpArray();
int[] indexesAndSize = IndexesOfNeedElements(InputStringArray); // получаем массив индексов строковых элементов <=3 символов 
int sizeOfNewArray = indexesAndSize[indexesAndSize.Length - 1]; // извлекаем из массива количество найденных элементов

System.Console.WriteLine();
System.Console.WriteLine($"введено {sizeOfNewArray} элементов, длиной не более 3 символов");
System.Console.WriteLine();

string[] FinalArray = new string[sizeOfNewArray]; // Создаём новый строковый массив из sizeOfNewArray элементов 
for (int i = 0; i < sizeOfNewArray; i++)
{
    FinalArray[i] = InputStringArray[indexesAndSize[i]];
}

if (sizeOfNewArray != 0) { PrintArray(FinalArray); }


void PrintArray(string[] array) //метод печати массива
{
    System.Console.WriteLine("ЭЛЕМЕНТЫ:");
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"'{array[i]}', ");
        }
    }
}
string[] GetInpArray() //метод ввода с клавиатуры
{
    System.Console.Write("Введите количество элементов строчного массива --> ");
    int NumOfInpElements = Convert.ToInt32(Console.ReadLine());
    string[] StringArray = new string[NumOfInpElements];
    for (int i = 0; i < NumOfInpElements; i++)
    {
        System.Console.Write($"Введите {i + 1}-й элемент массива --> ");
        StringArray[i] = Console.ReadLine();
    }
    return StringArray;
}

int[] IndexesOfNeedElements(string[] InputArray)  //метод определения индексов элементов строчного массива длиной <= 3 символов, 
// последний элемент массива - количество определённых индексов
{
    int[] indexesArray = new int[InputArray.Length + 1]; //создаём массив целых индексов искомых элементов 
    int counterElements = 0; // счётчик индексов искомых элементов
    for (int i = 0; i < InputArray.Length; i++)
    {
        string str = InputStringArray[i];
        if (str.Length <= 3)
        {
            indexesArray[counterElements] = i;
            counterElements++;
        }
    }
    indexesArray[InputArray.Length] = counterElements; // последний элемент массива - количество индексов искомых элементов
    return indexesArray;
}
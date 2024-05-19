// Урок 1. Контрольная работа
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System.Runtime.Serialization.Formatters;

string[] InputStringArray = GetInpArray();
int[] indexesAndSize = IndexesOfNeedElements(InputStringArray); // получаем массив индексов строковых элементов <=3 символов 
int sizeOfNewArray = indexesAndSize[indexesAndSize.Length - 1]; // извлекаем из массива количество найденных элементов

System.Console.WriteLine();
System.Console.WriteLine($"введено {sizeOfNewArray} элементов, длиной не более 3 символов");

if (sizeOfNewArray != 0)
{
    string[] finalArray = new string[sizeOfNewArray]; // Создаём новый строковый массив из sizeOfNewArray элементов 
    for (int i = 0; i < sizeOfNewArray; i++)
    {
        finalArray[i] = InputStringArray[indexesAndSize[i]];
    }
    PrintArray(finalArray);
}
else { System.Console.WriteLine("Конец"); }


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
    int[] indexesArray = new int[InputArray.Length + 1]; //создаём массив целых индексов искомых элементов, длиной как у входящего массива +1 
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
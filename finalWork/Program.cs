/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    
    for(int i = 0; i< count; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

int [] CutArray(int [] array)
{
    int length = 0;
    if(array.Length > 10)
    {
        length = array.Length / 10;
    }
    else
    {
        if(array.Length / 3 ==1)
        {
            length = 3;
            return array;
        }
        else
        {
            length--;
        }
    }
    return array;
}


int [] array = new int[10];
FillArray(array);
PrintArray(array);
PrintArray(CutArray(array));*/

void ShortArray(string [] array, string [] newArray)
{
    int count = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
          newArray[count] = array[i];
          count++;  
        }
    }
}

void ShowArray (string [] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    { 
       Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}


string [] array = {"hello","1","world","2022","123", "good", "bye","happy","new","year","2023"};
string [] newArray = new string [array.Length];

ShortArray(array,newArray);
ShowArray(newArray);



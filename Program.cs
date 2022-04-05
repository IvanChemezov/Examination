//              Lets the show begin
///*
Console.Clear();
int MaxLenght = 4;                                              //  Magic number from task
int WordPosition = 0;                                           //  

Console.Write("How many words do you want to print?\t");
int ArrayLenght = int.Parse(Console.ReadLine());


string[] OriginalArray  = new string[ArrayLenght];             //  array for draw numbers
string[] ShortArray     = new string[ArrayLenght];             //  change to int Counter


//                      Get information
for(int i = 0; i < ArrayLenght; i++)
{
    Console.Write($"Please, enter word №{i + 1}\t\t\t");          //  to know how many words were entered already
    OriginalArray[i] = Console.ReadLine();
}

//                      Filter information
for(int i = 0; i < ArrayLenght; i++)
{
    
    if(OriginalArray[i].Length < MaxLenght)
    {
        ShortArray[WordPosition] = OriginalArray[i];
        WordPosition++;
    }
}
//                      Show information
if(WordPosition == 0) Console.WriteLine("\nAll words longer when expacted(");
else
{
    for(int i = 0; i < WordPosition; i++)
    {
        Console.WriteLine($"Result array's number №{i}, value\t=\t{ShortArray[i]}");
    }
}
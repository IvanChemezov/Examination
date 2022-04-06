namespace ClassLib;
public class Class_Exam_Lib
{

    ///<summary>
    /// this function determine lenght of arrays
    ///<summery>
    public static int Get_Array_Lenght()
    {
        Console.Clear();
        Console.Write("How many words do you want to enter?\t");
        return int.Parse(Console.ReadLine());
    }

    ///<summary>
    /// this function is for filling original array
    ///<summery>
    public static void Fill_Array(int ArrayLenght, string[] Array)
    {
    for(int i = 0; i < ArrayLenght; i++)
        {
            Console.Write($"Please, enter word №{i + 1}\t\t\t");        //  to know how many words were entered already
            Array[i] = Console.ReadLine();
        }
    }

    ///<summary>
    /// this function add short words from original array to result array
    ///<summery>

    public static int Filling_Second_Array_Short_Words(string[] OriginalArray, string[] ShortArray, int ArrayLenght)
    {
    int MaxLenght       = 3;                                            //  Magic number from original task
    int WordsCounter    = 0;
    for(int i = 0; i < ArrayLenght; i++)
        {   
            if(OriginalArray[i].Length <= MaxLenght)
            {
                ShortArray[WordsCounter] = OriginalArray[i];
                WordsCounter++;
            }
        }
    return WordsCounter;
    }

    ///<summary>
    /// this function show all numbers of result array in console
    ///<summery>
    static public void Show_Information(string[] ShortArray,int Array_Lenght)
    {
        if(Array_Lenght == 0) Console.WriteLine("\nAll words longer when expacted( The array is empty");
        else
        {
            for(int i = 0; i < Array_Lenght; i++)
            {
                Console.WriteLine($"Result array's number №{i}, value\t=\t'{ShortArray[i]}'");
            }
        }
    }
}

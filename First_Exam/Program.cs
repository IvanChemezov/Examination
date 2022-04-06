using ClassLib;

int ArrayLenght = Class_Exam_Lib.Get_Array_Lenght();

string[] OriginalArray  = new string[ArrayLenght];              //  array for draw numbers
string[] ShortArray     = new string[ArrayLenght];              //  array for filtered words

Class_Exam_Lib.Fill_Array(ArrayLenght, OriginalArray);          //  Add words to Original Array
int WordsCounter = Class_Exam_Lib.Filling_Second_Array_Short_Words(OriginalArray, ShortArray, ArrayLenght);
Class_Exam_Lib.Show_Information(ShortArray, WordsCounter);      //  Show result's array
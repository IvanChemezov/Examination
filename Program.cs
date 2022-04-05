//              Lets the show begin
string[] OriginalArray = new string[30];        //  array for draw numbers
int MaxLenght = 4;                              //  Magic number from task
int WordsCounter = 1;
for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Could you please type the word");
    OriginalArray[i] = Console.ReadLine();
    WordsCounter++;

    //Console.WriteLine("Do you want to continue fill the array?\n\t Yes\t No");
    //string answer = Console.ReadLine();
    //if (answer == "No") i = 30;
}



string[] ShortArray = new string[30];           //  change to int Counter
for(int i = 0; i < 30; i++)
{
    int value = OriginalArray[i].ToString().Length;
    if(value < MaxLenght)
    {
        ShortArray[i] = OriginalArray[i];
    }
    else{}
}
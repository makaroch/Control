string[] inputArray = {"123","1234","2345","12"};

string[] outputArray = new string[0]; 
    
int length = inputArray.Length;

 for (int i = 0; i < length; i++)
{
    if (inputArray[i].Length <= 3)
        AddNewElement(inputArray[i]);
}

LookArray(outputArray);



void AddNewElement(string item){

    int length = outputArray.Length; 
   
    Array.Resize(ref outputArray, length+1);
    
    outputArray[length] = item;
  
}

void LookArray(string[] array){
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

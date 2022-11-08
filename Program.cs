
void Tack(){
    string[] inputArray = {"123","1234","2345","12"};

    string[] outputArray = new string[0]; 
    
    int length = inputArray.Length;

    for (int i = 0; i < length; i++)
    {
        if (inputArray[i].Length <= 3)
            AddNewElement(inputArray[i], outputArray);
    }
}
Tack();


void AddNewElement(string item, string[] array){

    int length = array.Length;
   

}



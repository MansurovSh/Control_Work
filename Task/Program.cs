string[] arr = (Console.ReadLine().Split(" ")).ToArray();


string[] New_matrix(string[] arr ){
    string[] new_arr = new string[arr.Length];
    int count = 0;
    
    if(arr.Length == 0){
        Array.Resize(ref new_arr, count);
        return new_arr;
    }
    
    
    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3)
            new_arr[count++] = arr[i];
    }
    Array.Resize(ref new_arr, count);
    return new_arr;
}


Console.Write("Новый массив : [ ");
Console.Write(string.Join(" , ",New_matrix(arr)));
Console.WriteLine(" ]");
string[] arr = (Console.ReadLine().Split(" ")).ToArray();
Console.WriteLine(string.Join(" ",arr));

string[] New_matrix(string[] arr ){
    string[] new_arr = new string[arr.Length];
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3)
            new_arr[count++] = arr[i];
    }
    return new_arr;
}

Console.WriteLine(string.Join("   ",New_matrix(arr)));
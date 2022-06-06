for(int i = 1; i <=255; i++){
    Console.WriteLine(i);
}


bool isDiv = false;
for(int j = 1; j <= 100; j++){
    isDiv = false;
    if(j % 5 == 0){
        isDiv = !isDiv;
    }
    if(j % 3 == 0){
        isDiv = !isDiv;
    }
    if(isDiv){
        Console.WriteLine(j);
    }
}

string result = "";
for(int k = 1; k <= 100; k++){
    result = "";
    if(k % 3 == 0){
        result += "Fizz";
    }
    if(k % 5 == 0){
        result += "Buzz"; 
    }
    if(result.Length > 0){
        Console.WriteLine(result);
    }
}
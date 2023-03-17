
//Method 4 - Prime Numbers

static bool primeCheck(int number)
{
    int counter = 0;
    for (int i = 1; i <= number; i++){
        if (number % i == 0){
            counter++;
        }
    }
    if (counter == 2){
        return true;
    }
    else {
        return false;
    }

}

Console.WriteLine($"The number 5 is a prime number is {primeCheck(5)}");
Console.WriteLine($"The number 10 is a prime number is {primeCheck(10)}");
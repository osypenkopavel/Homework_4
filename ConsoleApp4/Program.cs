//Method TrySumIfOdd that accepts 2 parameters and returns true if sum of numbers between inputs is odd, otherwise false, sum return as out parameter

bool TrySumIfOdd(int number1, int number2, out int sum)
{
    sum = number1 + number2;
    if (sum % 2 == 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

//Method that will return max value among all the parameters
//… min value …
//Overload first two methods with 3 and 4 parameters
class TestClass

{
    void MaxValue(int param1, int param2)
    {
        Console.WriteLine(Math.Max(param1, param2));
    }

    void MinValue(int param1, int param2)
    {
        Console.WriteLine(Math.Min(param1, param2));
    }

    void MaxValue(int param1, int param2, int param3)
    {
        Console.WriteLine(Math.Max(param1, Math.Max(param2, param3)));
    }

    void MinValue(int param1, int param2, int param3, string param4)
    {
        Console.WriteLine(param4 + " " + Convert.ToString(Math.Min(param1, Math.Min(param2, param3))));
    }
}
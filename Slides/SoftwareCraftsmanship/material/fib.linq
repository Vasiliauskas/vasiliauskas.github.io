<Query Kind="Program" />

void Main(int number = 10)
{
	// Loop
	Console.WriteLine(string.Format("Loop: {0}", GetFib(number)));
	
	// Linq
	Console.WriteLine(string.Format("Linq: {0}", GetFibs().Skip(number).First()));
	
	// Linq + Extensions method
	Console.WriteLine(string.Format("Extension on Linq: {0}", GetFibs().GiveMe(number)));
	
	// Recursion
	Console.WriteLine(string.Format("Extension on Linq: {0}", GetRecursiveFib(number)));
}

private int Get10thFib()
{
	int fib1 = 1;
	int fib2 = 1;
	for(int i = 2; i <= 10; i++)
	{
		int result = fib1 + fib2;
		fib1 = fib2;
		fib2 = result;
		
		if(i == 10)
			return result;
	}
	
	return 0;
}

private int GetFib(int number)
{
	int fib1 = 1;
	int fib2 = 1;
	for(int i = 2; i <= number; i++)
	{
		int result = fib1 + fib2;
		fib1 = fib2;
		fib2 = result;
		
		if(i == number)
			return result;
	}
	
	return 0;
}

private IEnumerable<int> GetFibs()
{
    int fib1 = 1;
	int fib2 = 1;
	
	yield return fib1;
	yield return fib2;
	
	while(true)
	{
		var result = fib1 + fib2;
		fib1 = fib2;
		fib2 = result;
		
		yield return result;
	}
}

private int GetRecursiveFib(int number)
{
    if(number == 1 || number == 2)
		return 1;
		
	if(number < 1)
		return 0;
	
	return GetRecursiveFib(number-1) + GetRecursiveFib(number-2);
}

static class FibExtensions
{
	public static int GiveMe(this IEnumerable<int> collection, int number)
	{
		return collection.Skip(number).First();
	}
}

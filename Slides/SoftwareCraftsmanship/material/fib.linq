<Query Kind="Program" />

void Main(int number = 10)
{
	// Loop
	Console.WriteLine(string.Format("Loop: {0}", GetFib(number)));
	
	// Linq
	Console.WriteLine(string.Format("Linq: {0}", GetFibs().Skip(number).First()));
	
	// Linq + Extensions method
	Console.WriteLine(string.Format("Extension on Linq: {0}", GetFibs().GiveMe(number)));
}

private int GetFib(int number)
{
	int fib1 = 1;
	int fib2 = 2;
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
    int fib1= 1;
	int fib2 = 2;
	
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

static class FibExtensions
{
	public static int GiveMe(this IEnumerable<int> collection, int number)
	{
		return collection.Skip(number).First();
	}
}

// Define other methods and classes here

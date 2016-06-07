***
# Software craftsmanship
***
Vidas Vasiliauskas
---
### Software engineer - who is this guy?!??
![Alt text](images/nerd.jpg)
---
![Alt text](images/chemistry.jpg)
---
***
### Ways we do it
***
---
### I want a program that can tell me what the 10th Fibonacci sequence number is
---
### **Fibonacci sequence** is a progression where the next member is calculated by summing up previous two
#### **fib(x) = fib(x-1) + fib(x-2)**
---
```
// Hardcoded Loop
private int Get10thFib()
{
	int fib1 = 1, fib2 = 1;
	
	for(int i = 3; i <= 10; i++)
	{
		int result = fib1 + fib2;
		fib1 = fib2;
		fib2 = result;
		
		if(i == 10)
			return result;
	}
	return 0;
}
```
---
```
// Loop
private int GetFib(int number)
{
	int fib1 = 1, fib2 = 1;
	
	for(int i = 3; i <= number; i++)
	{
		int result = fib1 + fib2;
		fib1 = fib2;
		fib2 = result;
		
		if(i == number)
			return result;
	}
	return 0;
}
```
---
```
// Recursion
private int GetRecursiveFib(int number)
{
    if(number == 1 || number == 2)
		return 1;
		
	if(number < 1)
		return 0;
	
	return GetRecursiveFib(number-1) + GetRecursiveFib(number-2);
}
```
---
```
// Lazy loop
private IEnumerable<int> GetFibs()
{
    int fib1= 1, fib2 = 1;
	
	yield return fib1; yield return fib2;
	
	while(true)
	{
		var result = fib1 + fib2;
		fib1 = fib2;
		fib2 = result;
		
		yield return result;
	}
}
```
---
```
	int number = 10;	

	// Hardcoded Loop
	Console.WriteLine("Hardcoded Loop: " + Get10thFib()));
	
	// Loop
	Console.WriteLine("Loop: " + GetFib(number)));
	
	// Recursion
	Console.WriteLine("Recursion: " + GetRecursiveFib(number)));
	
	// Linq
	Console.WriteLine("Linq: " + GetFibs().Take(number).Last()));
	
	// Linq + Extensions method
	Console.WriteLine("Extension on Linq: " + GetFibs().GiveMe(number)));	
```

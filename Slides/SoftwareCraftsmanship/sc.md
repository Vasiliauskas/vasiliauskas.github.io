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
``` cs
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
``` cs
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
``` cs
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
``` cs
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
``` cs
	// Hardcoded Loop
	string result = Get10thFib();
	
	// Loop
	string result = GetFib(10);
	
	// Recursion
	string result = GetRecursiveFib(10);
	
	// Linq
	string result = GetFibs().Take(10).Last();
	
	// Linq + Extensions method
	string result = GetFibs().GiveMe(10);	
```
---
Client comes in and *NOW* he wants the 15th fib number instead of 10th
---
![Alt text](images/batman.jpeg)
---
>As aspiring Software Craftsmen 
>we are raising the bar of professional software development 
>by practicing it and helping others learn the craft.
---
Through this work we have come to value:
* Not only working software, 
	but also well-crafted software
* Not only responding to change, 
	but also steadily adding value
* Not only individuals and interactions, 
	but also a community of professionals
* Not only customer collaboration, 
	but also productive partnerships
	
That is, in pursuit of the items on the left 
we have found the items on the right to be indispensable.
---
# This is it!
@Vasiliauskas
https://github.com/Vasiliauskas/
https://www.linkedin.com/in/vidasvasiliauskas
using System; 
class Program { 
	public int Add(int a, int b) 
	{ 
		int sum = a + b; 
		return sum; 
	} 

	
	public int Add(int a, int b, int c) 
	{ 
		int sum = a + b + c; 
		return sum; 
	} 

	
	public static void Main(String[] args) 
	{ 

		
		Program ob = new Program(); 

		int sum1 = ob.Add(8, 5); 
		Console.WriteLine("sum of the two "
						+ "integer value : " + sum1); 

		int sum2 = ob.Add(25, 6, 4); 
		Console.WriteLine("sum of the three "
						+ "integer value : " + sum2); 
	} 
} 

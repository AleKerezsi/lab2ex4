using System;

namespace lab2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 
		Scrieti un program care va determina daca un numar este sau nu palindrom.
		*/
		
		Console.WriteLine("Introduceti n= ");
		int n ;
		n = int.Parse(Console.ReadLine());
		
		int reverse=0;
		int ultimaCifra;         
		int copie = n;
		
		while(n!=0)      
        {      
			ultimaCifra = n%10;        
			reverse = reverse * 10 + ultimaCifra;      
			n = n / 10;      
        }
		
		if(copie == reverse) Console.WriteLine("Numarul " + copie + " este palindrom, deoarece este egal cu inversul lui " + reverse);
		else Console.WriteLine("Numarul " + copie + " nu este palindrom, deoarece nu este egal cu inversul lui " + reverse);
        }
    }
}

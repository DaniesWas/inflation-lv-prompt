using System;
using System.Text;

namespace Inflation;

static class Program 
{         
    static void Main(string[] args)
    {
		double a1;
		double a2;
	    
        Console.Title = "Инфлация";

        Console.OutputEncoding = Encoding.UTF8;
		Console.WriteLine("Базова година");
		a1 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Парична сума");
		a2 = Convert.ToDouble(Console.ReadLine());
		
		if(a1 == 1990){
		    Console.WriteLine(Convert.ToDouble( a2 * 4022.677));
		}
		
	    if(a1 == 1991){
		    Console.WriteLine(Convert.ToDouble( a2 * 701.196));
		}
	    
		if(a1 == 1992){
		    Console.WriteLine(Convert.ToDouble( a2 * 390.793));
		}
	    
	    if(a1 == 1993){
		    Console.WriteLine(Convert.ToDouble( a2 * 238.496));
        }
		
    	if(a1 == 1994){
		    Console.WriteLine(Convert.ToDouble( a2 * 107.462));
		}
		
    	if(a1 == 1995){
		    Console.WriteLine(Convert.ToDouble( a2 * 81.000));
		}
		
    	if(a1 == 1996){
		    Console.WriteLine(Convert.ToDouble( a2 * 19.680));
		}
	    
		if(a1 == 1997){
		    Console.WriteLine(Convert.ToDouble( a2 * 3.039));
		}
		
	    if(a1 == 1998){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.990));
		}
		
    	if(a1 == 1999){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.795));
		}
		
    	if(a1 == 2000){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.512));
		}
		
	    if(a1 == 2001){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.397));
		}
		
    	if(a1 == 2002){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.309));
		}
		
    	if(a1 == 2003){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.186));
		}
		
    	if(a1 == 2004){
		    Console.WriteLine(Convert.ToDouble( a2 * 2.102));
		}
		
    	if(a1 == 2005){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.975));
		}
		
    	if(a1 == 2006){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.854));
		}
		
    	if(a1 == 2007){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.648));
		}
		
    	if(a1 == 2008){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.530));
		}
		
    	if(a1 == 2009){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.521));
		}
		
    	if(a1 == 2010){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.455));
		}
		
	    if(a1 == 2011){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.416));
		}
		
    	if(a1 == 2012){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.359));
		}
		
    	if(a1 == 2013){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.381));
		}
		
	    if(a1 == 2014){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.393));
		}
		
    	if(a1 == 2015){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.398));
		}
		
	    if(a1 == 2016){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.397));
		}
		
    	if(a1 == 2017){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.359));
		}
		
    	if(a1 == 2018){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.324));
		}
		
    	if(a1 == 2019){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.275));
		}
		
	    if(a1 == 2020){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.273));
		}
		
    	if(a1 == 2021){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.182));
		}
		
    	if(a1 == 2022){
		    Console.WriteLine(Convert.ToDouble( a2 * 1.011));
		}
		
		Console.ReadKey();
    }
}

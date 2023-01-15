/*
    Created by Munawar Hasan
*/

using System;
using System.Numerics;

public class ExtendedEuclidean
{
	static void xgcd(BigInteger a, BigInteger b){
		BigInteger s = new BigInteger(0);
		BigInteger r = b;
		BigInteger old_s = new BigInteger(1);
    	BigInteger old_r = a;
    	BigInteger bezout_t;

		while (BigInteger.Compare(r, new BigInteger(0)) != 0){
			BigInteger quotient = BigInteger.Divide(old_r, r);
			BigInteger temp = r;
			r = BigInteger.Subtract(old_r, BigInteger.Multiply(quotient, r));
			old_r = temp;
			temp = s;
			s = BigInteger.Subtract(old_s, BigInteger.Multiply(quotient, s));
			old_s = temp;
		}

		if (BigInteger.Compare(b, new BigInteger(0)) != 0)
			bezout_t = BigInteger.Subtract(old_r, BigInteger.Divide(BigInteger.Multiply(old_s, a), b));
		else
			 bezout_t = new BigInteger(0);
		Console.WriteLine("Bézout coefficients: (" +old_s +", " +bezout_t +")");
	}
	public static void Main()
	{
		BigInteger a = new BigInteger(2304);
        BigInteger b = new BigInteger(13);
        xgcd(a, b);
	}
}
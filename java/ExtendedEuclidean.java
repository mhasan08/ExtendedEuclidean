/*
    Created by Munawar Hasan
*/

import java.math.BigInteger;

public class ExtendedEuclidean {
    
    static void xgcd(BigInteger a, BigInteger b){
        
        BigInteger s = BigInteger.ZERO;
    	BigInteger r = b;
    	BigInteger old_s = BigInteger.ONE;
    	BigInteger old_r = a;
    	BigInteger bezout_t = null;
    	
    	while (r.compareTo(BigInteger.ZERO) != 0){
    	    BigInteger quotient = old_r.divide(r);
    	    
    	    BigInteger temp = r;
    	    r = old_r.subtract(quotient.multiply(r));
 		    old_r = temp;
 		    
 		    temp = s;
     		s = old_s.subtract(quotient.multiply(s));
     		old_s = temp;
    	}
    	
    	if (b.compareTo(BigInteger.ZERO) != 0)
    	    bezout_t = old_r.subtract(old_s.multiply(a)).divide(b);
    	else
    	    bezout_t = BigInteger.ZERO;
    	
    	System.out.println("Bézout coefficients: (" +old_s +", " +bezout_t +")");
    	
    }
    
    public static void main(String args[]) {
        BigInteger a = BigInteger.valueOf(2304);
        BigInteger b = BigInteger.valueOf(13);
        xgcd(a, b);
    }
}
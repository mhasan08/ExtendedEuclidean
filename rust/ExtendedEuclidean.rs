/*
    Created by Munawar Hasan
*/

fn main() {
    xgcd(2304, 13);
}

fn xgcd(a: i64, b: i64){

    let mut s = 0i64; 
    let mut r = b;
    let mut old_s = 1i64;
    let mut old_r = a;
    let bezout_t: i64;
    
    while r != 0{
        let quotient = old_r / r;
        
        let mut temp = r;
        
        r = old_r - quotient * r;
        old_r = temp;

        temp = s;

        s = old_s - quotient * s;
        old_s = temp;
    }
    if b != 0{
        bezout_t = (old_r - old_s * a) / b;
    }
    else{
        bezout_t = 0;
    }
    println!("Bézout coefficients: ({}, {})", old_s, bezout_t);
}
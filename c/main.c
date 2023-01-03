/*
    Created by Munawar Hasan
*/

#include <stdio.h>

int xgcd(int a, int b){
    int s = 0;
	int r = b;
	int old_s = 1;
	int old_r = a;
    int quotient;
    int temp, bezout_t;

    while (r != 0){
        quotient = old_r / r;

        temp = r;
        r = old_r - quotient * r;
        old_r = temp;

        temp = s;
        s = old_s - quotient * s;
        old_s = temp;
    }

    if (b != 0)
        bezout_t = (old_r - old_s * a) / b;
    else
        bezout_t = 0;
    printf("Bézout coefficients: (%d, %d)\n", old_s, bezout_t);

    return 0;
}

int main() {
    xgcd(2304, 13);
    return 0;
}

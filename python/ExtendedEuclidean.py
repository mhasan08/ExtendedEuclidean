'''
	Created by Munawar Hasan
'''

def xgcd(a, b):
	s = 0
	r = b
	old_s = 1
	old_r = a

	while r != 0:
 		quotient = old_r // r

 		temp = r
 		r = old_r - quotient * r
 		old_r = temp

 		temp = s
 		s = old_s - quotient * s
 		old_s = temp

	if b != 0:
 		bezout_t = (old_r - old_s * a) // b
	else:
 		bezout_t = 0

	print("Bézout coefficients:", (old_s, bezout_t))

if __name__ == "__main__":
	xgcd(2304, 13)
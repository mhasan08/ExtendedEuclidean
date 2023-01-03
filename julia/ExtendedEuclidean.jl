#=
    Created by Munawar Hasan
=#

function xgcd(a, b)
    s = 0
    r = b
    old_s = 1
    old_r = a

    while r != 0
        quotient = old_r ÷ r

        temp = r
        r = old_r - quotient * r
        old_r = temp

        temp = s
        s = old_s - quotient * s
        old_s = temp
    end
    if b != 0
        bezout_t = (old_r - old_s * a) ÷ b
    else
        bezout_t = 0
    end
    println("Bézout coefficients: ", (old_s, bezout_t))
end

xgcd(2304, 13)
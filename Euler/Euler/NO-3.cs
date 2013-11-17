using System;

class YOlo {
   /* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? */

    static void Main() {
        ulong value = 600851475143;
        ulong arraylength = 400;
        ulong[] primeholder = new ulong[arraylength];

        meth.build_array(primeholder,arraylength);

        Console.ReadKey();
    }
}

static class meth {
    public static bool check_if_prime(ulong number) {

// It should be noted that this method will return false if 2 is passed to it, this can be changed by branching the below if statement
       /* if ((number & 1) == 0) {
            return false;
        } */

        for (ulong x = 3; (x * x) < number; x += 2) {
            if ((number % x) == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static void build_array(ulong[] array, ulong length) {
        array[0] = 2;
        ulong arrayindex = 1;
            for (ulong y = 3; arrayindex < length; y += 2) {
                if (check_if_prime(y)) {
                    array[arrayindex] = y;
                    arrayindex++;
                }
            }
        
    }
}


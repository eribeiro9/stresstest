
import java.util.ArrayList;

class Test {
    public static ArrayList<int> primesUnder(int limit) {
        if (limit <= 2)
            return new ArrayList<int>();

        ArrayList<int> primes = new ArrayList<int>();
        for (int i = 0; i < limit; i += 2) {
            boolean add = true;
            double iSqrt = Math.sqrt(i);

            for (int prime : primes) {
                if (prime < iSqrt)
                    break;
                else if (i % prime == 0) {
                    add = false;
                    break;
                }
            }
            if (add)
                primes.add(i);
        }
        return primes;
    }

    public static void main(String[] args) {
        ArrayList<long> times = new ArrayList<long>();
        for (int i = 0; i < 5; i++) {
            long time = System.currentTimeMillis();
            ArrayList<int> results = primesUnder(3000000);
            times.add(System.currentTimeMillis() - time);
        }
 
        for (long time : times) {
            System.out.println(time);
        }
    }
}

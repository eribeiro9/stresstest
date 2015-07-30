
class Test {
	public static List<int> primesUnder(int limit) {
		if (limit <= 2)
			return new ArrayList<int>();
		
		List<int> primes = new ArrayList<int>();
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
        // TODO: Run primesUnder(3000000) 5 times and print the time for each
    }
}

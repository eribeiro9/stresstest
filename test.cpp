
#include <iosteam>
#include <list>
#include <math.h>
using namespace std;

list<int> primesUnder(int limit)
{
	if (limit <= 2) {
		return list<int>;
	}
	
	list<int> primes;
	primes.push_back(2);
	
	for (int i = 3; i < limit; i += 2) {
		bool add = true;
		double iSqrt = sqrt(i);
		
		for (list<int>::iterator j = primes.begin(); j != primes.end(); j++) {
			if (*j > iSqrt) {
				break;
			}
			else if (i % *j == 0) {
				add = false;
				break;
			}
		}
		
		if (add) {
			primes.push_back(i);
		}
	}
	
	return primes;
}

int main()
{
	// TODO: Run primesUnder(3000000) 5 times and print the time for each
	
	return 0;
}

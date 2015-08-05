
from timeit import default_timer as timer
import math


def primes_under(limit):
    if limit <= 2:
        return list()

    primes = [2]
    for i in range(3, limit, 2):
        add = True
        i_sqrt = math.sqrt(i)

        for prime in primes:
            if prime > i_sqrt:
                break
            elif i % prime == 0:
                add = False
                break
        if add:
            primes.append(i)
    return primes


times = list()
for i in range(5):
    start = timer()
    results = primes_under(3000000)
    end = timer()
    times.append(end - start)
print(str(times))

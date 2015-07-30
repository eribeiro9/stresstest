
function primesUnder(var limit) {
	if (limit <= 2) return []
	
	var primes = [2]
	for (var i = 3; i < limit; i += 2) {
		var add = true
		var iSqrt = Math.sqrt(i)
		
		for (var prime in primes) {
			if (prime > iSqrt) {
				break
			} else if (i % prime === 0) {
				add = false
				break
			}
		}
		if (add) primes.push(i)
	}
	return primes
}

// TODO: Run primesUnder(3000000) 5 times and print the time for each

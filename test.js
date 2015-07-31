
function primesUnder(var limit) {
    if (limit <= 2) return []

    var primes = [2]
    for (i = 3; i < limit; i += 2) {
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

var times = []
for (i = 0; i < 5; i++) {
    var start = new Date().getTime()
    var results = primesUnder(3000000)
    var end = new Date().getTime()
    times.push(end - start)
}

for (var time in times) {
    console.log(time)
}

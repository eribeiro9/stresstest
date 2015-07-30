
open System

let primesUnder limit =
  if limit <= 2 then []

  let primes = [2]
  for i in 3 .. 2 .. limit do
    let add = true
    let iSqrt = sqrt i

    for prime in primes do
      if prime > iSqrt then break
      else
        add = false
        break
    if add then
      primes = List.append primes [i]
  primes

[<EntryPoint>]
let main argv =
  // TODO: Run primesUnder 3000000 5 times and print the time for each
  0

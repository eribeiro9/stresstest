
#include<stdlib.h>
#include<math.h>

typedef enum { false, true } bool;

struct node {
  int x;
  struct node *next;
}

struct node primes_under(int limit)
{
  if (limit <= 2) {
    // TODO: Look into mimicking an empty list
    return NULL;
  }

  struct node *primes;
  primes = (struct node *) malloc( sizeof(struct node) )
  primes->next = 0;
  primes->x = 2;

  for (int i = 3; i < limit; i += 2) {
    bool add = true;
    double i_sqrt = sqrt(i);

    struct node *prime;
    prime = primes;
    // TODO: foreach
    // http://www.cprogramming.com/tutorial/c/lesson15.html
  }
}

main()
{
  // TODO: Run primes_under(3000000) 5 times and print the time for each

  return 0;
}

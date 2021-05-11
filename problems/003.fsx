//https://projecteuler.net/problem=3

#time
let inline ``Largest prime factor`` n =
    let isPrime n =
        let rec isPrime counter =
            if counter >= n then
                true
            elif n % counter = 0 then
                false
            else
                isPrime (counter + 1)

        isPrime 2

    let nSqrt = (n |> float |> sqrt |> int)

    seq { nSqrt .. -1 .. 2  }
    |> Seq.filter isPrime
    |> Seq.filter (fun x -> (int64 n) % (int64 x) = 0L)
    |> Seq.head

``Largest prime factor`` 600851475143L

#time

// 01:21 :(

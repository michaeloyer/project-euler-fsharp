//https://projecteuler.net/problem=1

let ``Multiples of 3 and 5`` upper =
    { 1 .. upper - 1 }
    |> Seq.sumBy (fun n -> if n % 3 = 0 || n % 5 = 0 then n else 0)

``Multiples of 3 and 5`` 10
``Multiples of 3 and 5`` 1000

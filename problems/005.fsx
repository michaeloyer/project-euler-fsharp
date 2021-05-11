//https://projecteuler.net/problem=5


let ``Smallest multiple`` n =
    let rec findMultiple x =
        if Seq.forall (fun i -> x % i = 0) (seq { 2 .. n })
        then x
        else findMultiple (x + n)

    findMultiple n

``Smallest multiple`` 20


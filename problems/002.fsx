//https://projecteuler.net/problem=2

let fibonnaci x y = seq {
    let rec fibonnaci x y = seq {
        yield y
        yield! fibonnaci y (x + y)
    }

    yield x
    yield! fibonnaci x y
}

let isEven n = n % 2 = 0

fibonnaci 1 2
|> Seq.takeWhile ((>) 4_000_000)
|> Seq.filter isEven
|> Seq.sum

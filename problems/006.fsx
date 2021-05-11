//https://projecteuler.net/problem=6

let squareOfTheSum = Seq.sum (seq { 1I .. 100I }) |> fun i -> i * i
let sumOfTheSquares = Seq.sum (seq { 1I .. 100I } |> Seq.map (fun i -> i * i))

squareOfTheSum - sumOfTheSquares

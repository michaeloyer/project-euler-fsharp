//https://projecteuler.net/problem=4

let isPalendrom n =
    let text = string n

    let rec isPalendrom left right =
        match text.[left], text.[right] with
        | x, y when x = y && right - left <= 1 ->
            true
        | x, y when x = y ->
            isPalendrom (left + 1) (right - 1)
        | _ ->
            false

    isPalendrom 0 (String.length text - 1)


seq { for x in 100 .. 999 do
      for y in 100 .. 999 do
      yield x, y }
|> Seq.map (fun (x, y) -> x * y)
|> Seq.sortDescending
|> Seq.map string
|> Seq.filter isPalendrom
|> Seq.head

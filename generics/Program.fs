/// リストを結合する
let rec append xs ys =
    match xs with
    | [] -> ys
    | x :: xs' -> x :: (append xs' ys)

[<EntryPoint>]
let main argv =
    printfn "%A" <| append [1; 2; 3] [4; 5; 6] // => [1; 2; 3; 4; 5; 6]
    printfn "%A" <| append [true; false] [true] // => [true; false; true]
    0

let inline plus (x : ^a) (y : ^b) =  x + y

[<EntryPoint>]
let main argv =
    printfn "%d" <| plus 4 3 // => 7
    printfn "%s" <| plus "Hello, " "world!" // => Hello, world!
    0

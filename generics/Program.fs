[<Struct>]
type A =
    static member GetName() = "foo"

[<Struct>]
type B =
    static member GetName() = "bar"

let inline getName< ^X when ^X : (static member GetName : unit -> string)> () =
    (^X : (static member GetName : unit -> string) ())

[<EntryPoint>]
let main argv =
    printfn "%s" <| getName<A>() // => foo
    printfn "%s" <| getName<B>() // => bar
    0

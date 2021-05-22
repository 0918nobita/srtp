[<Struct>]
type A =
    static member GetName() = "foo"

[<Struct>]
type B =
    static member GetName() = "bar"

[<Struct>]
type C =
    static member GetAorB(_ : A) = 0

[<Struct>]
type D =
    static member GetAorB(_ : B) = 0

let inline getName (x : ^X) : _ when ^X : (static member GetAorB : ^AorB -> int) =
    (^AorB : (static member GetName : unit -> string) ())

[<EntryPoint>]
let main argv =
    printfn "%s" <| getName(C()) // => foo
    printfn "%s" <| getName(D()) // => bar
    0

(********************************************
*DEV207.1x: Module One Assignment           *
*Program Name: Koan	                        *                
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
*Date(DD/MM/YYYY): 18/10/2015               *
********************************************)
open System

let a = 100
let b = 1000
let f x y = x + y / 10
[<EntryPoint>]
let main argv =
    let a = 101
    let ans = f a b
    printfn "%A" ans
    Console.ReadKey()
    0
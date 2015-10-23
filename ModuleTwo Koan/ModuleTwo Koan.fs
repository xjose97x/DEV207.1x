(*******************************************
*DEV207.1x: Module Two Assignment           *
*Program Name: Koan                         *                    
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
********************************************)

open System

let rec dosomethingrandom (x : int) =
    if x = 0 then 1
    else dosomethingrandom (x - 1) * x
[<EntryPoint>]
let main argv = 
    let input = Console.ReadLine()
    let input = int input
    let calc = dosomethingrandom input
    Console.WriteLine("{0}", calc)
    0

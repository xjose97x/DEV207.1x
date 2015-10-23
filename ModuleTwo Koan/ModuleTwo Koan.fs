(********************************************
*DEV207.1x                                  *
*Program Name: Module Two Koan              *                    
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
********************************************)

open System

let rec dosomethingrandom x =
    if x = 0 then Console.WriteLine(1)
    else dosomethingrandom ((x - 1) * x)
[<EntryPoint>]
let main argv = 
    let input = Console.ReadLine()
    let input = int input
    let calc = dosomethingrandom input
    0

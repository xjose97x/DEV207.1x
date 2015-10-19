(********************************************
*DEV207.1x                                  *
*Program Name: Area of Hexagon		        *                    
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
*Date(DD/MM/YYYY): 18/10/2015               *
********************************************)

open System

let hexarea t : float =
    (3.0 * Math.Sqrt(3.0) / 2.0) * Math.Pow(t,2.0)

[<EntryPoint>]  
    let main argv =
    // Read a line from the console application - Side Effect
    let value = Console.ReadLine()
    // Convert to a float
    let f = float value
    // Execute Calc
    let calc  = hexarea f
    // Display on screen - Side Effect
    printf "%f" calc
    0 // return an integer exit code
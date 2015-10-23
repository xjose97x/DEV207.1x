﻿(**********************************************
*DEV207.1x                                    *
*Program Name: Fibonacci Number not Recursive *                    
*Programming Language:                        *
*Author: José I. Escudero                     *
*E-mail: joseignacioescudero97@hotmail.com    *
**********************************************)

open System

let checkvalue (argv : string []) : int =
    if argv.Length > 0 then      
        let couldparse, consolein = Int32.TryParse(argv.[0])
        if couldparse then consolein
        else
            let canparse, keyin = Int32.TryParse(Console.ReadLine())
            if canparse then keyin
            else 0
    else
        let canparse, keyin = Int32.TryParse(Console.ReadLine())
        if canparse then keyin
        else 0

let fibonacci n =
    let mutable first = 0
    let mutable second = 1
    let mutable temp = 0
    for index = 1 to n do
        temp <- first + second
        first <- second
        second <- temp
    first

[<EntryPoint>]    
let main argv =
    let input = checkvalue argv
    let calc = fibonacci input
    Console.WriteLine(calc)
    Console.ReadKey()
    0 // return an integer exit code
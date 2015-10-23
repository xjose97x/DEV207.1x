(********************************************
*DEV207.1x: Module Two Assignment           *
*Program Name: Name and Age                 *                    
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
********************************************)

open System

let ParseInteger (str: string) =
    let mutable intvalue = 0
    if System.Int32.TryParse(str, &intvalue) then Some(intvalue)
    else None

let Analyzer (age : int) = 
    if age >= 20 then "no longer a teenager"
    elif age <=20 && age > 13 then "is a teenager"
    else "is a child"


[<EntryPoint>]
let main argv = 
    Console.WriteLine("Enter # of people:")
    let number = Console.ReadLine();
    let check = ParseInteger number
    let number = check
    
    if check.IsNone then
        Console.WriteLine("Input is not a number")        
        Environment.Exit(1)
    for i = 0 to (number.Value - 1) do
        Console.WriteLine("Enter Name:")
        let name = Console.ReadLine()
        if String.IsNullOrWhiteSpace(name) then
            Console.WriteLine("Name is not valid!")
            Environment.Exit(2)

        Console.WriteLine("Enter Age:")
        let age = Console.ReadLine()
        let scheck = ParseInteger age
        let age = scheck

        if scheck.IsSome then
            let answer = Analyzer age.Value
            Console.WriteLine("Name: {0}, Age: {1}, Age Analysis: {2}", name, age.Value, answer)
        else
            Console.WriteLine("Input not valid!")
            Environment.Exit(3)
    0
        


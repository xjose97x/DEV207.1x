(********************************************
*DEV207.1x: Module Three Assignment         *
*Program Name: Golden Ratio                 *                    
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
********************************************)
open System

let goldenRatio = 
    (1.0 + (Math.Sqrt 5.0)) / 2.0

let rec Another() =
    printfn "add another number Y/N?"
    let yesNo = Console.ReadLine()
    let yesNo = yesNo.Trim().ToLower()

    if yesNo = "n" then
        false
    elif yesNo = "y" then
        true
    else
        Another()

let rec enterNumber() = 
    printfn "Please enter a number: "
    let age = Console.ReadLine() 
    let couldParse, parsed = System.Double.TryParse(age)
    if couldParse then
        parsed
    else
        enterNumber()

let printResult initalValue product =
    printfn "first value: %f product %f" initalValue product
    ()

[<EntryPoint>]
let main argv = 
    printfn "The Golden Ratio is : %.10f" goldenRatio
    
    //first input
    let mutable numbers = [enterNumber()]

    //allow user to input as many more values as they like
    while Another() do        
        numbers <- enterNumber() :: numbers

    //Calculate product for provided values
    let products = numbers |> List.map (fun x -> (x,x * goldenRatio))

    //Print
    products |> List.iter(fun x ->  
        let init , prod = x
        printResult init prod) 
    
    Console.ReadKey()
    0 // return an integer exit code
(********************************************
*DEV207.1x: Module One Assignment           *
*Program Name: Cylinder Volume  	        *                    
*Programming Language: F#                   *
*Author: José I. Escudero                   *
*E-mail: joseignacioescudero97@hotmail.com  *
*Date(DD/MM/YYYY): 18/10/2015               *
********************************************)
open System

let CylinVol (r : float) (h : float) = Math.PI * Math.Pow(r, 2.0) * h
[<EntryPoint>]
let main argv =
    let ask = Console.WriteLine("Radius of Cylinder?")
    let r = Console.ReadLine() 
    let r = float r
    let ask1 = Console.WriteLine("Height of Cylinder?")
    let h = Console.ReadLine()
    let h = float h
    let calc = CylinVol r h
    Console.WriteLine("The Volume of the Cylinder with the data you provided is: {0}", calc)
    Console.ReadKey();
    0
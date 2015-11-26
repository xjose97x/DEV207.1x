(*******************************************
*DEV207.1x                                 *
*Program Name: Module Three Koan           *                    
*Programming Language: F#                  *
*Author: José I. Escudero                  *
*E-mail: joseignacioescudero97@hotmail.com *
*******************************************)
open System

let arr = [| 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
let l = arr.Length
let isEven x = x % 2 = 0

let out =
    [ for i = 0 to l do
          if isEven arr.[i] then yield arr.[i] ]

let newout = arr @ out
﻿module tostring4

// <Snippet4>
let values = [| -124y; 0y; 118y |]
let specifiers = 
    [| "G"; "C"; "D3"; "E2"; "e3"; "F" 
       "N"; "P"; "X"; "00.0"; "#.0" 
       "000(0)**Zero**" |]

for value in values do
    for specifier in specifiers do
        printfn $"{specifier}: {value.ToString specifier}"
    printfn ""
// The example displays the following output:
//       G: -124
//       C: ($124.00)
//       D3: -124
//       E2: -1.24E+002
//       e3: -1.240e+002
//       F: -124.00
//       N: -124.00
//       P: -12,400.00 %
//       X: 84
//       00.0: -124.0
//       #.0: -124.0
//       000(0)**Zero**: (124)
//       
//       G: 0
//       C: $0.00
//       D3: 000
//       E2: 0.00E+000
//       e3: 0.000e+000
//       F: 0.00
//       N: 0.00
//       P: 0.00 %
//       X: 0
//       00.0: 00.0
//       #.0: .0
//       000(0)**Zero**: **Zero**
//       
//       G: 118
//       C: $118.00
//       D3: 118
//       E2: 1.18E+002
//       e3: 1.180e+002
//       F: 118.00
//       N: 118.00
//       P: 11,800.00 %
//       X: 76
//       00.0: 118.0
//       #.0: 118.0
//       000(0)**Zero**: 118
// </Snippet4>
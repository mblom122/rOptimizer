open System
open System.IO
open System.Reflection
open System.Collections.Generic
open Types

let lstMonsters = new List<Monster>()
let mutable testMob = Monster(0,"test",0,0.0,0.0,0.0,0.0,0,0,0,0,0.0,0.0,0.0,0.0,0,0,0,0,"1","2","3")

lstMonsters.Add(testMob)

printf "%A"  lstMonsters.[0].Name
testMob.Name <- "hoho"
printf "%A"  testMob.Name

[<EntryPoint>]
let main argv = 
    
    //let mutable continueLooping = true
    //    while continueLooping do

    Console.ReadKey() |> ignore
    0 // return an integer exit code

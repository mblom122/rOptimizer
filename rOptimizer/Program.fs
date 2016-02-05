open System
open System.IO
open System.Reflection
open System.Collections.Generic
open Types
open ConsoleCommands

let lstMonsters = new List<Monster>()
let mutable testMob = Monster(0,"test",0,0.0,0.0,0.0,0.0,0,0,0,0,0.0,0.0,0.0,0.0,0,0,0,0,"1","2","3")

lstMonsters.Add(testMob)

//printf "%A"  lstMonsters
//testMob.Name <- "hoho"
//printf "%A"  testMob.Name

[<EntryPoint>]
let main argv = 
    let mutable run = true

    //Clears console and writes menu, function is loacated in ConsoleCommands
    ConClear()
    // Makes an loop to keep program running
    while run do
        // Changes color of console and ask for command
        Console.ForegroundColor<-ConsoleColor.Green 
        printf "Write your command: " 
        Console.ForegroundColor<-ConsoleColor.White 

        //Waits for user input
        let userInput = Console.ReadLine()

        // Checks the user input and do the commands linked to it
        match userInput with
            | "q" | "quit" -> run <- false
            | "clr" -> ConClear();
            | "commands" -> ConCommands();
            | "add m" -> lstMonsters.Add(testMob); printf "    What are the monster stats? (id, name, level, base_hp, base_atk, base_def, base_spd, base_critrate, base_critdmg, base_res, base_acc, set_hp, set_atk, set_def, set_spd, set_critrate, set_critdmg, set_res, set_acc, runeset_1, runeset_2, runeset_3)\n"
            | "list m" -> printf "%A \n\n"  lstMonsters
            | _ -> Console.ForegroundColor<-ConsoleColor.Red ; 
                   printf "\nInvalid input!\n";

        Threading.Thread.Sleep(1);
    
    // Waits for user key to close
    printf "\nClosing... Press any key!"
    Console.ReadKey() |> ignore

     // Ask the user for input
    //Console.Write("Enter your input: ")
    
    // Read user input
    //let input = Console.ReadLine()

     // Print the entered input
    //Console.Write("You entered: {0} \n", input)
    //Console.WriteLine("sign 5: {0}", ("test"))
    //lstMonsters.Add(testMob)
    //printf "%A \n\n"  lstMonsters
    // you may want to sleep to prevent 100% CPU usage
    //Threading.Thread.Sleep(1);
    (*let myInput = Console.ReadLine()

    match myInput with
    | "q" -> ()
    | "m" -> writeMenu(); main();
    | _ -> main()*)

    0

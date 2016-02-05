module ConsoleCommands
    open System

    let ConClear() = 
        Console.Clear()
        Console.ForegroundColor<-ConsoleColor.Blue 
        Console.Write("Menu: clr, commands, q/quit \n")

    let ConCommands() =
        Console.Clear()
        Console.ForegroundColor<-ConsoleColor.Blue 
        Console.Write("Menu: clr, commands, q/quit \n")
        Console.ForegroundColor<-ConsoleColor.Cyan 
        Console.Write("Commands avalible: \n")
        Console.Write("     clr: clears screen \n")
        Console.Write("     commands: shows commands \n")
        Console.Write("     q/quit: quits app \n")
        Console.Write("     list m: list all monsters \n")
        Console.Write("     list r: list all runes \n")
        Console.Write("     add m: adds monster to list \n")
        Console.Write("     add r: adds rune to list \n")
        Console.ForegroundColor<-ConsoleColor.White 

        

    
       

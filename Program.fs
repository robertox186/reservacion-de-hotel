open System
open reservacion.reservacion


[<EntryPointAttribute>]
  let main args =

    match args[0] with 
       |"fiesta"  ->  
         let cliente = crear_reservacion "d"
         printfn "la reserva es: %A" cliente
         0
       |"casa" ->  
         printfn "es una casa"
         0
      
       
  
    
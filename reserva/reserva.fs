namespace reservacion
open System

type Reservacion = {

    fecha_entrada:string;
    fecha_salida:string;
    hora_entrada:string;
    hora_salida:string
    NombreCompleto:String;
    cedula:int;
    habitacion:string;

}

module reservacion =
 
   let crear_reservacion  (r)= 
  
       printfn "Nombre del huesped:"
       let NombreCompleto=Console.ReadLine();
       printfn "fehca de llegada del huesped" 
       let fecha_entrada =Console.ReadLine();
       printfn "fehca de salida del huesped" 
       let fecha_salida =Console.ReadLine();
       printfn "Cedula del cliente"
       let cedula = System.Int32.Parse(Console.ReadLine())   
       printfn "Habitacion del huesped"
       let habitacion= Console.ReadLine()
       printfn "Hora de llegada del huesped"
       let hora_llegada=Console.ReadLine()    
       printfn "fehca de salida del huesped" 
       let hora_salida =Console.ReadLine();
       {
           NombreCompleto=NombreCompleto;
           fecha_entrada=fecha_entrada;
           cedula=cedula;
           habitacion=habitacion;
           hora_entrada=hora_llegada
           hora_salida=hora_salida
           fecha_salida=fecha_salida
        }  


    
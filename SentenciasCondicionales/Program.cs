// See https://aka.ms/new-console-template for more information

// condicionales (if - switch )

#region ejercicio01
//string UsuarioAdmin, ClaveAdmin, usuarioInput, claveInput;


//UsuarioAdmin = "Victor";
//ClaveAdmin = "123456";

//Console.WriteLine("Ingrese Usuario");
//usuarioInput = Console.ReadLine();


//Console.WriteLine("Ingrese Clave");
//claveInput = Console.ReadLine();

///**

//        ==   --->  comparar valores si son iguales los valores
//        =     ---> es para asignar, asignas el valor de la derecha al valor de la izquierda
//        !=   ----> comapara si son diferentes
//        < >= <= (numericos)
//        ===   ---> comparar valores, compara el tipo de dato ( float(2.0) === decimal(2.0) )
//        !()
//        && || --->
//*/


//if (UsuarioAdmin == usuarioInput && ClaveAdmin == claveInput)
//    Console.WriteLine("Bienvenido admin!");

//else
//    Console.WriteLine("Usuario y/o password incorecto!");


#endregion

Console.WriteLine("ingrese un numero");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero  == 0) {
    Console.WriteLine("el numero ingresado  es igual a :" + numero );
}
else if (numero % 2 == 0)
{
    Console.WriteLine("El numero ingresado " + numero + " es par ");
}
else
{
    Console.WriteLine("En numero no es par");
}

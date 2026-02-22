
//if (numberInt % 2 == 0) // si el numero es par
//                        //    {
//                        //        Console.WriteLine($"El número {numberInt}, es par.");// para que salte y quede en la otra linea 
//                        //    }
//                        //    else // si el numero es impar
//                        //    {
//                        //        Console.WriteLine($"El número {numberInt}, es impar.");
//                        //    }
//                        //////////////////OTRAS MEJORAS EN LA VARIABLE ///////////
//    using System.ComponentModel.Design;

/////
//do
//{
//    Console.Write("Ingrese Número entero o presione Ctrl + C para salir: ");
//    var numberString = Console.ReadLine(); //"45" string number es ="45" yo quiero que numero = 45 (45 sin comilla un # pero 45 con comilla.... si utilizo var me las leer como string pero para  
//    var numberInt = 0; //inicializamos la variable para que no de error, pero no le asignamos un valor porque lo vamos a asignar con el try parse
//    if (int.TryParse(numberString, out numberInt))  // 45 como # # //funcion try parse 
//    {
//        if (numberInt % 2 == 0) // si el numero es par
//        {
//            Console.WriteLine($"El número {numberInt}, es par."); // para que salte y quede en la otra linea 
//        }
//        else // si el numero es impar
//        {
//            Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
//        }
//    }
//    else
//    {
//        Console.WriteLine($"lo que ingresaste: {numberString}, no es un numero entero.");
//    }
//} while (true);  // el true es para que se repita infinitamente, si queremos que se repita 5 veces por ejemplo, ponemos while (5) o while (i < 5) y i++ para que se vaya incrementando el contador

//////////////////////////////////////////////////////////
///
var numberString = string.Empty; //inicializamos la variable para que no de error, pero no le asignamos un valor porque lo vamos a asignar con el try parse
do
{//PERO SI YO QUIERO CO¿A MBIAR LA SALIDA  OSEA CTRL C
    Console.Write("Ingrese Número entero o la palabra 'salir' para salir: ");
    numberString = Console.ReadLine(); //"45" string number es ="45" yo quiero que numero = 45 (45 sin comilla un # pero 45 con comilla.... si utilizo var me las leer como string pero para  
    //Tolower para convertir en minuscula
    if (numberString!.ToLower () == "salir" || numberString == "s") // || doble pai es  O si el usuario ingresa S o s para salir, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while, pero como el numeroString es igual a S o s, el programa se detiene y no hace nada mas, sino que continua con el siguiente ciclo del do while
    {
        continue;
    }

    var numberInt = 0; //inicializamos la variable para que no de error, pero no le asignamos un valor porque lo vamos a asignar con el try parse
    if (int.TryParse(numberString, out numberInt))  // 45 como # # //funcion try parse 
    {
        if (numberInt % 2 == 0) // si el numero es par
        {
            Console.WriteLine($"El número {numberInt}, es par."); // para que salte y quede en la otra linea 
        }
        else // si el numero es impar
        {
            Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
        }
    }
    else
    {
        Console.WriteLine($"lo que ingresaste: {numberString}, no es un numero entero.");
    }
    //OSEA HAGA MIENTRAS # STRING SEA DIFERENTE DE ¨S¨
    //la condicion cambia haga mientras el numberstringtyolower sea diferente de salir 
} while (numberString!.ToLower() != "salir");  // el true es para que se repita infinitamente, si queremos que se repita 5 veces por ejemplo, ponemos while (5) o while (i < 5) y i++ para que se vaya incrementando el contador
Console.WriteLine("Game Over.");


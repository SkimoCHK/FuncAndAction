namespace FuncAndAction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////// Action ////////
            //Action es un delegado predefinido que no tiene un valor de retorno.
            //Se utiliza para representar un método que realiza una acción o modifica el estado de un objeto sin devolver ningún valor.
            //Por ejemplo, supongamos que tienes un método llamado ImprimirMensaje que toma
            //un mensaje como parámetro y lo imprime en la consola. Este método sería un candidato perfecto para ser representado por un delegado Action.

            Action<string> imprimirMensaje = m => Console.WriteLine(m);

            imprimirMensaje("Hola cabros");

            //aqui este action hicimos q no reciba nada..
            Action imprimrHolaMundo = () => Console.WriteLine("Hola mundo cabros");
            imprimrHolaMundo();

            //////// Func ////////
            //Func es otro delegado predefinido que representa un método que
            //devuelve un valor. A diferencia de Action, Func especifica el tipo de valor de retorno.

            Func<int, int, int> Suma = (n1,n2) => n1 + n2;
            int resultado = Suma(2, 2);
            Console.WriteLine("El resultado de la suma es: " + resultado);



        }
    }
}

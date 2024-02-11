using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Stack procesosListos = new Stack();

        Queue procesosEjecucion = new Queue();
                
        procesosListos.Push("Inicializar el juego");
        procesosListos.Push("Pantalla de carga del juego");
        procesosListos.Push("Abrir el juego");

        Console.WriteLine("Simulación de planificador de tareas:");
        while (procesosListos.Count > 0 || procesosEjecucion.Count > 0)
        {
            // Si no hay procesos en ejecución, tomar uno de la pila de procesos listos
            if (procesosEjecucion.Count == 0 && procesosListos.Count > 0)
            {
                string proceso = (string)procesosListos.Pop();
                procesosEjecucion.Enqueue(proceso);
                Console.WriteLine($"Se está ejecutando: {proceso}");
            }

            // Ejecutar el primer proceso de la cola de procesos en ejecución
            if (procesosEjecucion.Count > 0)
            {
                string procesoEnEjecucion = (string)procesosEjecucion.Peek();
                Console.WriteLine($"Proceso en ejecución: {procesoEnEjecucion}");

                procesosEjecucion.Dequeue();
            }

            // Simular una pausa entre cada paso de la simulación
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        Console.WriteLine("Todos los procesos han sido ejecutados.");
    }
}

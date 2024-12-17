using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Proyecto_Archivos_Sec
{
    class VectorEnt
    {
        // Constante que define el tamaño máximo del vector
        const int MAX = 50;

        // Atributos privados
        private int[] v; // Vector para almacenar los elementos enteros
        private int n;   // Número de elementos presentes en el vector

        // Constructor: Inicializa el vector y el contador de elementos
        public VectorEnt()
        {
            n = 0;            // Inicializa la cantidad de elementos en 0
            v = new int[MAX]; // Crea un vector con capacidad máxima de 50
        }

        // Método para cargar elementos aleatorios en el vector dentro del rango [a, b)
        public void cargar(int nu, int a, int b)
        {
            n = nu; // Define la cantidad de elementos que se cargarán
            Random r = new Random(); // Instancia para generar números aleatorios
            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b); // Asigna un número aleatorio en cada posición
            }
        }

        // Método para cargar manualmente los elementos del vector ingresados por el usuario
        public void cargarmanual(int n1)
        {
            n = n1; // Asigna la cantidad de elementos
            for (int i = 1; i <= n; i++)
            {
                // Solicita un número entero al usuario mediante un cuadro de diálogo
                v[i] = Conversions.ToInteger(Interaction.InputBox("Ingrese elemento", "Elemento"));
            }
        }

        // Método para devolver los elementos del vector en formato de cadena
        public string descargar()
        {
            string s = ""; // Inicializa la cadena resultante
            for (int i = 1; i <= n; i++)
            {
                s += v[i] + " | "; // Concatena cada elemento seguido del separador
            }
            return s; // Retorna la cadena construida
        }

        // Método para intercambiar dos elementos del vector en las posiciones a y b
        public void inter(int a, int b)
        {
            int aux = v[a]; // Almacena temporalmente el valor de v[a]
            v[a] = v[b];    // Asigna el valor de v[b] a v[a]
            v[b] = aux;     // Asigna el valor temporal a v[b]
        }

        // Método para ordenar el vector en orden ascendente usando comparación directa
        public void Ord()
        {
            for (int p = 1; p <= n - 1; p++) // Itera sobre cada posición
            {
                for (int d = p + 1; d <= n; d++) // Compara con las posiciones siguientes
                {
                    if (v[p] <= v[d]) // Si v[p] es mayor o igual que v[d]
                        inter(p, d);  // Intercambia los valores
                }
            }
        }

        // Método para grabar los elementos del vector en un archivo
        public void GrabarV(string narch1)
        {
            Archivo a1 = new Archivo(); // Instancia un objeto de la clase Archivo
            a1.Abrir_Grab(narch1); // Abre el archivo en modo grabación
            for (int i = 1; i <= n; i++)
            {
                a1.Grabar(v[i]); // Graba cada elemento del vector en el archivo
            }
            a1.Cerrar_Grab(); // Cierra el archivo
        }

        // Método para acceder (leer) los elementos desde un archivo al vector
        public void AccesarV(string narch1)
        {
            Archivo a1 = new Archivo(); // Instancia un objeto de la clase Archivo
            int i = 0; // Inicializa el índice
            a1.Abrir_Leer(narch1); // Abre el archivo en modo lectura
            while (!a1.Verif_Fin()) // Lee hasta llegar al final del archivo
            {
                i++;
                v[i] = a1.leer(); // Guarda cada valor leído en el vector
            }
            n = i; // Actualiza la cantidad de elementos en el vector
            a1.Cerrar_Leer(); // Cierra el archivo
        }

        // Método alternativo de ordenamiento (nota: contiene un error lógico)
        public void ordenar()
        {
            for (int i = 1; i < n; i++) // Recorre las posiciones del vector
            {
                for (int j = i + 1; j <= n; j++) // Compara con las posiciones siguientes
                {
                    if (v[i] > v[j]) // Si v[i] es mayor que v[j], intercambia valores
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
    }
}

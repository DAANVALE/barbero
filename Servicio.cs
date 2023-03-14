using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace barbero
{
    internal class Servicio
    {
        Random timerandom = new Random();
        int[] barber = new int[0];
        Cliente cliente = new Cliente();

        public Servicio() {
            cliente.Key = 1;
            agregarCliente(cliente);
        }

        public Cliente agregarCliente(Cliente c) {
            int i = 0;
            if (c == null)
            {
                c.Tiempo = timerandom.Next(2, 5);
                c.SigCliente = new Cliente();
            }
            else {
                c.SigCliente.Key = c.Key + 1;
                agregarCliente(cliente.SigCliente);
            }
            return c;
        }

        public void AgregarBarbero(bool agregar)
        {
            if (agregar)
            {
                Array.Resize(ref barber, barber.Length + 1);
                System.Console.WriteLine(barber.Length);
            }
            else {
                if (barber.Length > 0)
                {
                    Array.Resize(ref barber, barber.Length - 1);
                    System.Console.WriteLine(barber.Length);
                }
                else {
                    System.Console.WriteLine("No hay mas barberos para quitar ");
                }
            }
        }
    }
}

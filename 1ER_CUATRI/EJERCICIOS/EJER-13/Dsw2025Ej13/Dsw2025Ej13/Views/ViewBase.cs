﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej13.Presentation.Views
{
    public abstract class ViewBase
    {
        
        protected void CentrarTexto(string? texto, out int usado, int? ancho = null, bool salto = true)
        {
            texto ??= string.Empty;
            ancho ??= Console.WindowWidth;
            int largo = texto.Length;
            int espacios = (ancho.Value - largo) / 2;
            espacios = espacios % 2 == 0 ? espacios : espacios + 1;
            string fin = salto ? "\n" : string.Empty;
            string final = new string(' ', espacios) + texto + fin;
            Console.Write(final);
            usado = final.Length;
        }
        protected void LimpiarPantalla()
        {
            Console.Clear();
        }

        protected void DibujarLinea()
        {
            var with = Console.WindowWidth;
            for (int i = 0; i < with; i++)
            {
                Console.Write("-");
            }
        }

        protected void DibujarEncabezado(params string[] columnas)
        {
            DibujarLinea();
            int ancho = Console.WindowWidth / columnas.Length;

            foreach (var columna in columnas)
            {
                Console.Write("|");
                CentrarTexto(columna, out int l, ancho - 1, false);
                Console.Write("".PadRight(ancho - 1 - l));
            }
            Console.Write("\n");
            DibujarLinea();
        }

    }
}


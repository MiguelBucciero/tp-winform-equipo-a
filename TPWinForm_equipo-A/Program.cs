using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_A
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //FUNCIONALIDAD 

            //VENTANA PRINCIPAL ----> BOTON 1,2 Y 3 

                //Listado de artículos. -----> BOTON 1 ----> VENTAN 1
                //Búsqueda de artículos por distintos criterios. ------> BOTON 1 ---->VENTANA 1
                //Agregar artículos. --------> BOTON 2 ---->VENTANA 2
                //Modificar artículos. ------> BOTON 2 ---->VENTANA 2
                //Eliminar artículos. -------> BOTON 2 ---->VENTANA 2
                //Ver detalle de un artículo. BOTON 3 ---->VENTANA 3

            //MODELO DE DOMINIO

            //Clase Articulo 
                //Código de artículo.>> NO PERMITIR SE DE DE ALTA SIN COGIDO (VALIDACION)
                //Nombre. >> NO PERMITIR DAR DE ALTA SIN NOMBRE (VALIDACION)
                //Descripción.
                //Marca(seleccionable de una lista desplegable).
                //Categoría(seleccionable de una lista desplegable.
                //Imagen.
                //Precio. >> NO PERMITIR SE CARGUEN LETRAS(VALIDACION)


            //clase Marca >> ID >> Descripcion 

            //Clase Categoria >> ID >> Descripcion 

            //Clase Imagen

            //HACER VALIDACIONES DE REQUIRIDO Y DE TIPO

        }
    }
}

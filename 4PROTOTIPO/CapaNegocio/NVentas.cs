using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CapaNegocio
{
    public class NVentas
    {
        // Metodo Insertar que llama al método Insertar de DVenta de la CapaDatos
        public static string Insertar(int idcliente, int idtrabajador, DateTime fecha, string serie, string correlativo, decimal iva,
            DataTable dtDetalles)
        {
            DVentas Obj = new DVentas();
          

                    if (String.IsNullOrEmpty(idcliente.ToString()) == true || idcliente > 999 || idcliente < 0)
            {
                return "Id de cliente está vacío, ingresa un cliente";

            }
            else if (String.IsNullOrEmpty(idtrabajador.ToString()) == true || idcliente > 999 || idcliente < 0)

            {
                    return "Id de trabajador está vacío, ingresa un trabajador";

            }
            else if(serie == string.Empty || Regex.IsMatch(serie, @"^[a-zA-Z]+$") || (serie.Length < 6 && serie.Length > 6))
            {
                return "Error de cadena en serie1 de factura";
            }
            else if(correlativo == string.Empty || Regex.IsMatch(serie, @"^[a-zA-Z]+$") || (serie.Length <9 && serie.Length > 9))
            {
                return "Error de cadena en serie2 de factura";
            }
            else if (iva != 12 && iva != 0)
            {
                return "Error, iva tiene que ser 12 o 0";
            }
            foreach (DataRow row in dtDetalles.Rows)
            {
                if((String.IsNullOrEmpty(row["iddetalle_ingreso"].ToString()) == true) || Convert.ToInt32(row["subtotal"]) > 9999
                    || Convert.ToInt32(row["subtotal"]) < 1 || Regex.IsMatch(row["iddetalle_ingreso"].ToString(), @"^[a-zA-Z]+$")) {
                    return "Error el id de detalle es un número incorrecto";
                }else if((String.IsNullOrEmpty(row["articulo"].ToString()) == true))
                {
                    return "Error el nombre de articulo está vacío";
                }else if ((String.IsNullOrEmpty(row["cantidad"].ToString()) == true) || Convert.ToInt32(row["cantidad"]) > 99
                    || Convert.ToInt32(row["cantidad"]) < 1 || Regex.IsMatch(row["iddetalle_ingreso"].ToString(), @"^[a-zA-Z]+$"))
                {
                    return "La cantidad de elementos es un número incorrecto";
                }
                else if ((String.IsNullOrEmpty(row["precio_venta"].ToString()) == true) || Convert.ToInt32(row["precio_venta"]) > 500
                    || Convert.ToInt32(row["precio_venta"]) < 0.10 || Regex.IsMatch(row["iddetalle_ingreso"].ToString(), @"^[a-zA-Z]+$"))
                {
                    return "El precio de venta es un número incorrecto";
                }
                else if ((String.IsNullOrEmpty(row["subtotal"].ToString()) == true) || Convert.ToInt32(row["subtotal"]) > 500
                    || Convert.ToInt32(row["subtotal"]) < 0.10 || Regex.IsMatch(row["iddetalle_ingreso"].ToString(), @"^[a-zA-Z]+$"))
                {
                    return "El subtotal es un número incorrecto";
                }

            }
                Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Fecha = fecha;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Iva = iva;
            List<DetalleVentas> detalles = new List<DetalleVentas>();
            foreach (DataRow row in dtDetalles.Rows)
            {
            
                DetalleVentas detalle = new DetalleVentas();
                detalle.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());

                detalles.Add(detalle);
                
            }

            return Obj.Insertar(Obj, detalles);
        }

        // Metodo Eliminar que llama al método Anular de DVenta de la CapaDatos
        public static string Eliminar(int idventa)
        {
            DVentas Obj = new DVentas();
            Obj.Idventa = idventa;
            return Obj.Eliminar(Obj);
        }

        // Metodo Mostrar que llama al método Mostrar de DVenta de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DVentas().Mostrar();
        }

        // Metodo BuscarFechas que llama al método BuscarFechas de DVenta de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DVentas Obj = new DVentas();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        // Metodo MostrarDetalle que llama al método MostrarDetalle de DVenta de la CapaDatos
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DVentas Obj = new DVentas();
            return Obj.MostrarDetalle(textobuscar);
        }

        // Metodo MostrarArticulo_Venta_Nombre que llama al método MostrarArticulo_Venta_Nombre de DVenta de la CapaDatos
        public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            DVentas Obj = new DVentas();
            return Obj.MostrarArticulo_Venta_Nombre(textobuscar);
        }

        // Metodo MostrarArticulo_Venta_Codigo que llama al método MostrarArticulo_Venta_Codigo de DVenta de la CapaDatos
        public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            DVentas Obj = new DVentas();
            return Obj.MostrarArticulo_Venta_Codigo(textobuscar);
        }
    }
}

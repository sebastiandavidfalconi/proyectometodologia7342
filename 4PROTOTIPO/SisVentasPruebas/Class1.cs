using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CapaPresentacion;
using CapaNegocio;
using CapaDatos;

using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DemoProjectTest
{
    [TestFixture]
    public class DemoTests
    {
        frmLogin prueba = new frmLogin();


        [Test]
        public void U1_cliente_correcto()
        {
            {
                Assert.AreEqual("OK", NCliente.Insertar("aaa".Trim().ToUpper(), "bbb".Trim().ToUpper(),
                            "F", Convert.ToDateTime("11/12/2002"), "CEDULA", "1111111111",
                            "aaaaaaaaaa", "0000000000", "aaa@a.z"));
            }

        }

        [Test]
        public void U2_cliente_correcto()
        {
            {
                Assert.AreEqual("OK", NCliente.Insertar("zzz".Trim().ToUpper(), "ccc".Trim().ToUpper(),
                            "F", Convert.ToDateTime("11/12/2002"), "CEDULA", "2222222222",
                            "zzzzzzzzzz", "999999999", "zzz@z.z"));
            }

        }

        [Test]
        public void U3_cliente_correcto()
        {
            {
                Assert.AreEqual("OK", NCliente.Insertar("Juan".Trim().ToUpper(), "Perez".Trim().ToUpper(),
                            "M", Convert.ToDateTime("11/12/2002"), "CEDULA", "3333333333",
                            "Av. 1", "0000000000", "prueba@liv.com"));
            }
        }

        [Test]
        public void U4_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("@".Trim().ToUpper(), "asd".Trim().ToUpper(),
                            "", Convert.ToDateTime("1/1/2000"), "CEDULA", "@@",
                            "1", "@@", "@@"));
            }
        }

        [Test]
        public void U5_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("Juan".Trim().ToUpper(), "dd".Trim().ToUpper(),
                            "", Convert.ToDateTime("1/1/2000"), "CEDULA", "@@",
                            "Eloy Alfaro", "@@", "@@"));
            }
        }

        [Test]
        public void U6_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("juan".Trim().ToUpper(), "1".Trim().ToUpper(),
                            "", Convert.ToDateTime("1/1/2000"), "CEDULA", "23",
                            "Eloy Alffaro", "dd", "Hotmail"));
            }
        }

        [Test]
        public void U7_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("luis@".Trim().ToUpper(), "323".Trim().ToUpper(),
                            "-", Convert.ToDateTime("1/1/2000"), "CEDULA", "1755555555",
                            "Contraseña", "1", "Hotmail"));
            }
        }

        [Test]
        public void U8_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("--".Trim().ToUpper(), "t".Trim().ToUpper(),
                            "-", Convert.ToDateTime("1/1/2000"), "CEDULA", "1755555555",
                            "ggg", "1", "Hotmail"));
            }
        }

        [Test]
        public void U9_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("--".Trim().ToUpper(), "z".Trim().ToUpper(),
                            "1", Convert.ToDateTime("1/1/2000"), "CEDULA", "1755555555",
                            "as", "3333", "Hotmail"));
            }
        }

        [Test]
        public void U10_cliente_correcto()
        {
            {
                Assert.AreEqual("OK", NCliente.Insertar("Juan".Trim().ToUpper(), "Perez".Trim().ToUpper(),
                            "F", Convert.ToDateTime("1/1/2000"), "CEDULA", "5555333333",
                            "Av. Eloy Alfaro", "0993113455", "Karenperez@hotmail.com"));
            }
        }

        [Test]
        public void U11_cliente_correcto()
        {
            {
                Assert.AreEqual("OK", NCliente.Insertar("Gis".Trim().ToUpper(), "Beltran".Trim().ToUpper(),
                            "F", Convert.ToDateTime("1/1/2000"), "CEDULA", "7777777713",
                            "Av. Eloy Alfaro", "0992455435", "gis_flores@hotmail.com"));
            }
        }

        [Test]
        public void U12_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("Elizabeth".Trim().ToUpper(), "Teran".Trim().ToUpper(),
                            "d", Convert.ToDateTime("1/1/2000"), "CEDULA", "s",
                            "Av. Eloy Alfaro", "09934334554", "Hotmail.es"));
            }
        }

        [Test]
        public void U13_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("Perez".Trim().ToUpper(), "Teran".Trim().ToUpper(),
                            "ca", Convert.ToDateTime("1/1/2000"), "CEDULA", "s",
                            "Av. Eloy Alfaro", "099333354", "hotmailes"));
            }
        }

        [Test]
        public void U14_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("..".Trim().ToUpper(), "..".Trim().ToUpper(),
                            "d", Convert.ToDateTime("1/1/2000"), "CEDULA", "111111111111111",
                            "Av. Eloy Alfaro", "@4554", "@hotmail.com"));
            }
        }

        [Test]
        public void U15_cliente_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NCliente.Insertar("Karen".Trim().ToUpper(), "@".Trim().ToUpper(),
                            "s", Convert.ToDateTime("1/1/2000"), "CEDULA", "1733441144",
                            "Av. Eloy Alfaro", "4ñ`", "Karen_anonimo@hotmail.com"));
            }
        }


        [Test]
        public void U16_trabajador_correcto()
        {
            {
                Assert.AreEqual("OK", NTrabajador.Insertar("aaa".Trim().ToUpper(), "bbb".Trim().ToUpper(),
                            "F", Convert.ToDateTime("11/12/2002"), "0000000000",
                            "aaaaaaaaa", "000000000", "aaa@a.z", "VENDEDOR", "Aaa32", "asd"));
            }
        }

        [Test]
        public void U17_trabajador_correcto()
        {
            {
                Assert.AreEqual("OK", NTrabajador.Insertar("zzz".Trim().ToUpper(), "ccc".Trim().ToUpper(),
                            "F", Convert.ToDateTime("11/12/2002"), "9999999999",
                            "zzzzzzzzzz", "999999999", "zzz@z.z", "VENDEDOR", "Zzz32", "123"));
            }
        }

        [Test]
        public void U18_trabajador_correcto()
        {
            {
                Assert.AreEqual("OK", NTrabajador.Insertar("Juan".Trim().ToUpper(), "Perez".Trim().ToUpper(),
                            "M", Convert.ToDateTime("11/12/2002"), "0000000000",
                            "Av. 1", "0000000000", "prueba@liv.com", "ADMINISTRADOR", "Juan21", "asd"));
            }
        }

        [Test]
        public void U19_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("@".Trim().ToUpper(), "asd".Trim().ToUpper(),
                            "", Convert.ToDateTime("11/12/2002"), "@@",
                            "1", "@@", "@@", "", "1", "@"));
            }
        }

        [Test]
        public void U20_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("Juan".Trim().ToUpper(), "dd".Trim().ToUpper(),
                            "", Convert.ToDateTime("11/12/2002"), "@@",
                            "Eloy alfaro", "@@", "@@", "", "A", "4"));
            }
        }


        [Test]
        public void U21_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("juan".Trim().ToUpper(), "1".Trim().ToUpper(),
                            "", Convert.ToDateTime("11/12/2002"), "23",
                            "Eloy alffaro", "dd", "Hotmail", "", "Sd", "3"));
            }
        }

        [Test]
        public void U22_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("luis@".Trim().ToUpper(), "323".Trim().ToUpper(),
                            "-", Convert.ToDateTime("11/12/2002"), "1755555555",
                            "Contraseña", "1", "Hotmail", "-", "Asda d", "2"));
            }
        }

        [Test]
        public void U23_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("--".Trim().ToUpper(), "t".Trim().ToUpper(),
                            "asd", Convert.ToDateTime("11/12/2002"), "1755555555",
                            "ggg", "33", "Hotmail", "asd", "--", "1"));
            }
        }

        [Test]
        public void U24_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("--".Trim().ToUpper(), "z".Trim().ToUpper(),
                            "1", Convert.ToDateTime("11/12/2002"), "1755555555",
                            "as", "3333", "Hotmail", "1", "", ","));
            }
        }

        [Test]
        public void U25_trabajador_correcto()
        {
            {
                Assert.AreEqual("OK", NTrabajador.Insertar("Juan".Trim().ToUpper(), "Perez".Trim().ToUpper(),
                            "M", Convert.ToDateTime("11/12/2002"), "1754545345",
                            "Av. Eloy Alfaro", "0993113554", "Karen_perez@hotmail.com", "VENDEDOR", "Perez934", "@"));
            }
        }

        [Test]
        public void U26_trabajador_correcto()
        {
            {
                Assert.AreEqual("OK", NTrabajador.Insertar("Gis".Trim().ToUpper(), "Beltran".Trim().ToUpper(),
                            "M", Convert.ToDateTime("11/12/2002"), "1754545346",
                            "Av. Eloy Alfaro", "0992455432", "gis_flores@hotmail.com", "VENDEDOR", "Gis112", ".."));
            }
        }

        [Test]
        public void U27_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("Elizabeth".Trim().ToUpper(), "Teran".Trim().ToUpper(),
                            "d", Convert.ToDateTime("11/12/2002"), "",
                            "Av. Eloy Alfaro", "09934334554", "Hotmail.es", "d", "….", "-"));
            }
        }

        [Test]
        public void U28_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("Perez".Trim().ToUpper(), "".Trim().ToUpper(),
                            "ca", Convert.ToDateTime("11/12/2002"), "s",
                            "Av. Eloy Alfaro", "099333354", "hotmailes", "ca", "@@", "!!"));
            }
        }

        [Test]
        public void U29_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("..".Trim().ToUpper(), "..".Trim().ToUpper(),
                            "d", Convert.ToDateTime("11/12/2002"), "111111111111111",
                            "Av. Eloy Alfaro", "@4554", "@hotmail.com", "d", "._", "Contraseña"));
            }
        }

        [Test]
        public void U30_trabajador_incorrecto()
        {
            {
                Assert.AreNotEqual("OK", NTrabajador.Insertar("Karen".Trim().ToUpper(), "@".Trim().ToUpper(),
                            "s", Convert.ToDateTime("11/12/2002"), "1733441144",
                            "Av. Eloy Alfaro", "4ñ`", "Karen_anonimo@hotmail.com", "s", "1", "Contraseña"));
            }
        }

        [Test]
        public void U31_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("bbb", "Hamburguesa"));
            }
        }

        [Test]
        public void U32_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("Agua", "Zzz"));
            }
        }

        [Test]
        public void U33_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("Hamburguesa", "Agua"));
            }
        }

        [Test]
        public void U34_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("asd", "@"));
            }
        }

        [Test]
        public void U35_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("dd", "Comida"));
            }
        }

        [Test]
        public void U36_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("1", "L"));
            }
        }

        [Test]
        public void U37_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("323", "luis@"));
            }
        }

        [Test]
        public void U38_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NCategoria.Insertar("t", "--"));
            }
        }

        [Test]
        public void U39_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("bbb", "Hamburguesa"));
            }
        }

        [Test]
        public void U40_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("Agua", "Zzz"));
            }
        }

        [Test]
        public void U41_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("Hamburguesa", "Agua"));
            }
        }

        [Test]
        public void U42_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("asd", "@"));
            }
        }

        [Test]
        public void U43_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("dd", "Comida"));
            }
        }

        [Test]
        public void U44_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("1", "L"));
            }
        }

        [Test]
        public void U45_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("323", "luis@"));
            }
        }

        [Test]
        public void U46_categoría_correcta()
        {
            {
                Assert.AreEqual("OK", NPresentacion.Insertar("t", "--"));
            }
        }


        [Test]

        public void U47_usuariocorrecto()
        {
            {
                prueba.retornarUsuario("admin");
                prueba.retornarContraseña("admin");
                prueba.Ingresar();
                Assert.AreEqual("Exitoso", prueba.Ingresar());
            }
        }

        [Test]

        public void U48_usuarioincorrecto()
        {
            {
                prueba.retornarUsuario("amdin");
                prueba.retornarContraseña("admin");
                prueba.Ingresar();
                Assert.AreEqual("Error", prueba.Ingresar());
            }
        }
        [Test]
        public void U49_usuarioincorrecto()
        {
            {
                prueba.retornarUsuario("");
                prueba.retornarContraseña("");
                prueba.Ingresar();
                Assert.AreEqual("Error", prueba.Ingresar());
            }
        }
        [Test]
        public void U50_usuarioincorrecto()
        {
            {
                prueba.retornarUsuario("admin");
                prueba.retornarContraseña("");
                prueba.Ingresar();
                Assert.AreEqual("Error", prueba.Ingresar());
            }
        }
        [Test]
        public void U51_usuarioincorrecto()
        {
            {
                prueba.retornarUsuario("pedro");
                prueba.retornarContraseña("123");
                prueba.Ingresar();
                Assert.AreEqual("Error", prueba.Ingresar());
            }
        }


        [Test]
        public void U52_ingresarventacorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = 5;
            row["articulo"] = "probando";
            row["cantidad"] = 0;
            row["precio_venta"] = Convert.ToDecimal("125");
            row["subtotal"] = Convert.ToDecimal("125");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(120, 120, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);
            /*
                 Assert.AreEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle)); //12 es el iva //2 es la cantidad de articulos
             }
            */
            //}
        }
        [Test]
        public void U53_ingresarventacorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = 5;
            row["articulo"] = "hola";
            row["cantidad"] = 0;
            row["precio_venta"] = Convert.ToDecimal("125");
            row["subtotal"] = Convert.ToDecimal("125");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(121, 121, 
                             Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);
            /*
                 Assert.AreEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle)); //12 es el iva //2 es la cantidad de articulos
             }
            */
            //}
        }

        [Test]
        public void U54_ingresarventaincorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = 12;
            row["articulo"] = "";
            row["cantidad"] = 13;
            row["precio_venta"] = Convert.ToDecimal("2");
            row["subtotal"] = Convert.ToDecimal("2");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(121, 121, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2002"), "33", "331", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);
    
                 Assert.AreNotEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("13"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle)); //12 es el iva //2 es la cantidad de articulos
             }

        [Test]
        public void U55_ingresarventaincorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = 5;
            row["articulo"] = "comida";
            row["cantidad"] = -1;
            row["precio_venta"] = Convert.ToDecimal("125");
            row["subtotal"] = Convert.ToDecimal("125");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(121, 121, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);

            Assert.AreNotEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                        Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                        dtDetalle)); //12 es el iva //2 es la cantidad de articulos
        }


        [Test]
        public void U56_ingresarventaincorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = -5;
            row["articulo"] = "comida";
            row["cantidad"] = -1;
            row["precio_venta"] = Convert.ToDecimal("125");
            row["subtotal"] = Convert.ToDecimal("125");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(11, 11, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2022"), "1231", "3212", Convert.ToDecimal("22"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);

            Assert.AreNotEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                        Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                        dtDetalle)); //12 es el iva //2 es la cantidad de articulos
        }

        [Test]
        public void U57_ingresarventaincorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = 5;
            row["articulo"] = "comida";
            row["cantidad"] = 1;
            row["precio_venta"] = Convert.ToDecimal("-125");
            row["subtotal"] = Convert.ToDecimal("125");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(33, 33, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("1/1/2000"), "1", "1", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);

            Assert.AreNotEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                        Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                        dtDetalle)); //12 es el iva //2 es la cantidad de articulos
        }
        [Test]
        public void U58_ingresarventaincorrecta()
        {
            var dtDetalle = new DataTable();
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            decimal subTotal = Convert.ToDecimal(0);
            DataRow row = dtDetalle.NewRow();
            row["iddetalle_ingreso"] = 5;
            row["articulo"] = "comida";
            row["cantidad"] = 1;
            row["precio_venta"] = Convert.ToDecimal("-125");
            row["subtotal"] = Convert.ToDecimal("-125");
            dtDetalle.Rows.Add(row);

            var rpta = "";

            rpta = NVentas.Insertar(21, 21, //0001 puede ser coca cola //juan perez es el cliente
                             Convert.ToDateTime("20/02/2022"), "1231", "f", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                             dtDetalle);
            MessageBox.Show(rpta);

            Assert.AreNotEqual("OK", NVentas.Insertar(116, 116, //0001 puede ser coca cola //juan perez es el cliente
                        Convert.ToDateTime("1/1/2000"), "1231", "1231", Convert.ToDecimal("12"), //001 es el codigo inicial //000000 es el codigo siguiente //2.50 precio de venta //1.50 precio de venta
                        dtDetalle)); //12 es el iva //2 es la cantidad de articulos
        }
    }
   
}
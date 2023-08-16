using CRUD_BD_Clientes1.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_BD_Clientes1.CapaDatos
{
    public class ClientesRepository
    {

        SqlConnection sqlConnection;
        SqlCommand cmd;
        string sql;
        string cadenaConexion = "Data Source=192.168.220.251\\SQLTESTZEUS,51427;Initial Catalog=INTELAF TIENDA;Integrated Security=True;";
        //Prueba para hacer commit desde cmd

        public ClientesRepository()
        {

          sqlConnection = new SqlConnection(cadenaConexion);

        }

        //METODO PARA AGREGAR
        public void Add(Clientes cliente)
        {
            //se abre conexion con BD
            sqlConnection.Open();

            // comando inser into para agregar datos a BD
            var command = new SqlCommand("INSERT INTO [INTELAF TIENDA].DBO.CLIENTES (CODIGO, NOMBRE, DIRECCION, TELEFONO, FAX, NIT, ATENCION, DISTR, CORREO, DESCUENTO, E_MAIL, ANOTACIONES, LISTA_NEGRA, TIPO_DE_RETENEDOR, DIRECCION_ENTREGA, ZONA_ENTREGA, DPI, PASAPORTE) " +
                "VALUES (@CODIGO, @NOMBRE, @DIRECCION, @TELEFONO, @FAX, @NIT, @ATENCION, @DISTR, @CORREO, @DESCUENTO, @E_MAIL, @ANOTACIONES, @LISTA_NEGRA, @TIPO_DE_RETENEDOR, @DIRECCION_ENTREGA, @ZONA_ENTREGA, @DPI, @PASAPORTE)", sqlConnection);

            //envio de valores tomados de metodos set
            command.Parameters.AddWithValue("@CODIGO", cliente.CODIGO);
            command.Parameters.AddWithValue("@NOMBRE", cliente.NOMBRE);
            command.Parameters.AddWithValue("@DIRECCION", cliente.DIRECCION);
            command.Parameters.AddWithValue("@TELEFONO", cliente.TELEFONO);
            command.Parameters.AddWithValue("@FAX", cliente.FAX);
            command.Parameters.AddWithValue("@NIT", cliente.NIT);
            command.Parameters.AddWithValue("@ATENCION", cliente.ATENCION);
            command.Parameters.AddWithValue("@DISTR", cliente.DISTR);
            command.Parameters.AddWithValue("@CORREO", cliente.CORREO);
            command.Parameters.AddWithValue("@DESCUENTO", cliente.DESCUENTO);
            command.Parameters.AddWithValue("@E_MAIL", cliente.E_MAIL);
            command.Parameters.AddWithValue("@ANOTACIONES", cliente.ANOTACIONES);
            command.Parameters.AddWithValue("@LISTA_NEGRA", cliente.LISTA_NEGRA);
            command.Parameters.AddWithValue("@TIPO_DE_RETENEDOR", cliente.TIPO_DE_RETENEDOR);
            command.Parameters.AddWithValue("@DIRECCION_ENTREGA", cliente.DIRECCION_ENTREGA);
            command.Parameters.AddWithValue("@ZONA_ENTREGA", cliente.ZONA_ENTREGA);
            command.Parameters.AddWithValue("@DPI", cliente.DPI);
            command.Parameters.AddWithValue("@PASAPORTE", cliente.PASAPORTE);
          
            command.ExecuteNonQuery();

            //se cierra conexion a BD
            sqlConnection.Close();  

        }

        //METODO PARA BUSCAR
        public  Clientes FindAll(string codigo)
        {

            Clientes resultado = new Clientes();

            
            sql = "SELECT * FROM [INTELAF TIENDA].DBO.CLIENTES WHERE CODIGO =" +"'"+codigo+"'";
            //envio de valores tomados de metodos set
            
            sqlConnection.Open();
            cmd = new SqlCommand(sql, sqlConnection);

            var dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                resultado.NOMBRE = dataReader["NOMBRE"].ToString();
                resultado.DIRECCION = dataReader["DIRECCION"].ToString();
                resultado.TELEFONO = dataReader["TELEFONO"].ToString();
                resultado.FAX = dataReader["FAX"].ToString();
                resultado.NIT = dataReader["NIT"].ToString();
                resultado.ATENCION = dataReader["ATENCION"].ToString();
                resultado.DISTR = dataReader["DISTR"].ToString();
                resultado.CORREO = dataReader["CORREO"].ToString();
                resultado.DESCUENTO = Convert.ToSingle(dataReader["DESCUENTO"].ToString());
                resultado.E_MAIL = dataReader["E_MAIL"].ToString();
                resultado.ANOTACIONES = dataReader["ANOTACIONES"].ToString();
                resultado.LISTA_NEGRA = Convert.ToChar(dataReader["LISTA_NEGRA"].ToString());
                resultado.TIPO_DE_RETENEDOR = dataReader["TIPO_DE_RETENEDOR"].ToString();
                resultado.DIRECCION_ENTREGA = dataReader["DIRECCION_ENTREGA"].ToString();
                resultado.ZONA_ENTREGA = Convert.ToInt32(dataReader["ZONA_ENTREGA"].ToString());
                resultado.DPI = dataReader["DPI"].ToString();
                resultado.PASAPORTE = dataReader["PASAPORTE"].ToString();
            }
            sqlConnection.Close();
            return resultado;
            
        }


        //ACTUALIZAR
        public void Update(Clientes cliente, string codigo)
        {
            //se abre conexion con BD
            sqlConnection.Open();

            // comando inser into para agregar datos a BD
            var command = new SqlCommand("UPDATE [INTELAF TIENDA].DBO.CLIENTES SET NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@TELEFONO, FAX=@FAX, NIT=@NIT, ATENCION=@ATENCION, DISTR=@DISTR, CORREO=@CORREO, DESCUENTO=@DESCUENTO, E_MAIL=@E_MAIL, ANOTACIONES=@ANOTACIONES, LISTA_NEGRA=@LISTA_NEGRA, TIPO_DE_RETENEDOR=@TIPO_DE_RETENEDOR, DIRECCION_ENTREGA=@DIRECCION_ENTREGA, ZONA_ENTREGA=@ZONA_ENTREGA, DPI=@DPI, PASAPORTE=@PASAPORTE WHERE CODIGO = '"+codigo+"'", sqlConnection);

            //envio de valores tomados de metodos set
            command.Parameters.AddWithValue("@NOMBRE", cliente.NOMBRE);
            command.Parameters.AddWithValue("@DIRECCION", cliente.DIRECCION);
            command.Parameters.AddWithValue("@TELEFONO", cliente.TELEFONO);
            command.Parameters.AddWithValue("@FAX", cliente.FAX);
            command.Parameters.AddWithValue("@NIT", cliente.NIT);
            command.Parameters.AddWithValue("@ATENCION", cliente.ATENCION);
            command.Parameters.AddWithValue("@DISTR", cliente.DISTR);
            command.Parameters.AddWithValue("@CORREO", cliente.CORREO);
            command.Parameters.AddWithValue("@DESCUENTO", cliente.DESCUENTO);
            command.Parameters.AddWithValue("@E_MAIL", cliente.E_MAIL);
            command.Parameters.AddWithValue("@ANOTACIONES", cliente.ANOTACIONES);
            command.Parameters.AddWithValue("@LISTA_NEGRA", cliente.LISTA_NEGRA);
            command.Parameters.AddWithValue("@TIPO_DE_RETENEDOR", cliente.TIPO_DE_RETENEDOR);
            command.Parameters.AddWithValue("@DIRECCION_ENTREGA", cliente.DIRECCION_ENTREGA);
            command.Parameters.AddWithValue("@ZONA_ENTREGA", cliente.ZONA_ENTREGA);
            command.Parameters.AddWithValue("@DPI", cliente.DPI);
            command.Parameters.AddWithValue("@PASAPORTE", cliente.PASAPORTE);

            command.ExecuteNonQuery();

            //se cierra conexion a BD
            sqlConnection.Close();

        }


        //ELIMINAR
        public void Eliminar(string codigo)
        {
            //se abre conexion con BD
            sqlConnection.Open();
            try { 
            // comando delete para eliminar datos en BD
            var command = new SqlCommand("DELETE FROM [INTELAF TIENDA].DBO.CLIENTES WHERE CODIGO = '" + codigo + "'", sqlConnection);
                command.ExecuteNonQuery();
            }
            catch { MessageBox.Show("No eliminado"); }
            //se cierra conexion a BD
            sqlConnection.Close();

        }
    }
}

using CRUD_BD_Clientes1.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_BD_Clientes1.CapaDominio
{
    public class Clientes
    {
  
        //Constructor vacio
        public Clientes()
        {

        }

        
        //Metodos GET y SET
        public string CODIGO { get;  set; } = null;
        public string NOMBRE { get;  set; } = null;
        public string DIRECCION { get;  set; } = null;
        public string TELEFONO { get;  set; } = null;
        public string FAX { get;  set; } = null;
        public string NIT { get;  set; } = null;
        public string ATENCION { get;  set; } = null;
        public float SALDO_CON { get;  set; } = 0.0f;
        public float SALDO_SIN { get;  set; } = 0.0f;
        public string TERITORIO { get;  set; } = null;
        public string DISTR { get;  set; } = null;
        public string TECNICO { get;  set; } = null;
        public string VENDEDOR { get;  set; } = null;
        public float NIVEL_CONT { get;  set; } = 0;
        public float NIVEL_CRED { get;  set; } = 0.0f;
        public float LIMIT_CRED { get;  set; } = 0.0f;
        public float LIMIT_CHEQ { get;  set; } = 0.0f;
        public string FECHA_INI { get;  set; } = null;
        public string CORREO { get;  set; } = null;
        public string TARJ_PEND { get;  set; } = null;
        public float CHQ_PREF_P { get;  set; } = 0.0f;
        public float DESCUENTO { get;  set; } = 0.0f;
        public string E_MAIL { get;  set; } = null;
        public float CHQ_RECH { get;  set; } = 0.0f;
        public string ANOTACIONES { get;  set; } = null;
        public char LISTA_NEGRA { get;  set; } = '\0';
        public string ULT_TRANS { get;  set; } = null;
        public float CREDITO_PENDIENTE { get;  set; } = 0.0f;
        public float CHQ_RECH_DOLARES { get;  set; } = 0.0f;
        public string TIPO_DE_RETENEDOR { get;  set; } = null;
        public string DIRECCION_ENTREGA { get;  set; } = null;
        public int ZONA_ENTREGA { get;  set; } = 0;
        public string ACTUALIZADO_CORREO_Y_TELEFONO { get; set; } = null;
        public string ACTUALIZADO_CORREO { get;  set; } = null;
        public string ACTUALIZADO_TELEFONO { get;  set; } = null;
        public int SECUENCIA { get;  set; } = 0;
        public string DPI { get;  set; } = null;
        public string PASAPORTE { get;  set; } = null;


        //METODO PARA CREAR EN CAPA DE DOMINIO
        public static Clientes Create(string CODIGO, string NOMBRE, string DIRECCION, string TELEFONO, string FAX, string NIT, string ATENCION,
        string DISTR, string CORREO, string DESCUENTO, string E_MAIL, string ANOTACIONES, string LISTA_NEGRA, string TIPO_RETENEDOR, string DIRECCION_ENTREGA, string ZONA_ENTREGA,
        string DPI, string PASAPORTE)
        {

            if (string.IsNullOrEmpty(CODIGO)) throw new Exception("El codigo no puede estar en blanco");
            if (string.IsNullOrEmpty(NOMBRE)) throw new Exception("El nombre no puede estar en blanco");
            if (string.IsNullOrEmpty(DIRECCION)) throw new Exception("La direccion no puede estar en blanco");
            if (string.IsNullOrEmpty(TELEFONO)) throw new Exception("El telefono no puede estar en blanco");
            if (string.IsNullOrEmpty(FAX)) throw new Exception(" no puede estar en blanco");
            if (string.IsNullOrEmpty(ATENCION)) throw new Exception("Atencion no puede estar en blanco");
            if (string.IsNullOrEmpty(DISTR)) throw new Exception("El campo mayorista no puede estar en blanco");
            if (string.IsNullOrEmpty(CORREO)) throw new Exception("El correo no puede estar en blanco");
            if (string.IsNullOrEmpty(DESCUENTO)) throw new Exception("El descuento no puede estar en blanco");
            if (string.IsNullOrEmpty(E_MAIL)) throw new Exception("El nombre no puede estar en blanco");
            if (string.IsNullOrEmpty(ANOTACIONES)) throw new Exception("El codigo de sucursal no puede estar en blanco");
            if (string.IsNullOrEmpty(LISTA_NEGRA)) throw new Exception("Lista Negra no puede estar en blanco");
            if (string.IsNullOrEmpty(TIPO_RETENEDOR)) throw new Exception("El tipo de retenedor no puede estar en blanco");
            if (string.IsNullOrEmpty(DIRECCION_ENTREGA)) throw new Exception("La direccion de entrega no puede estar en blanco");
            if (string.IsNullOrEmpty(ZONA_ENTREGA)) throw new Exception("La zona no puede estar en blanco");

            
            return new Clientes()
            {
                CODIGO = CODIGO,
                NOMBRE = NOMBRE,
                DIRECCION = DIRECCION,
                TELEFONO = TELEFONO,
                FAX = FAX,
                NIT = NIT,
                ATENCION = ATENCION,
                DISTR = DISTR,
                CORREO = CORREO,
                DESCUENTO = Convert.ToSingle(DESCUENTO),
                E_MAIL = E_MAIL,
                ANOTACIONES = ANOTACIONES,
                LISTA_NEGRA = Convert.ToChar(LISTA_NEGRA),
                TIPO_DE_RETENEDOR = TIPO_RETENEDOR,
                DIRECCION_ENTREGA = DIRECCION_ENTREGA,
                ZONA_ENTREGA = Convert.ToInt32(ZONA_ENTREGA),
                DPI = DPI,
                PASAPORTE = PASAPORTE,
            };


        }



        //METODO PARA BUSCAR EN CAPA DE DOMINIO
        public static Clientes Buscar(string codigo)
        {
            ClientesRepository clientesRepository = new ClientesRepository();
            return clientesRepository.FindAll(codigo);

        }



        //METODO PARA ACTUALIZAR EN CAPA DE DOMINIO
        public static Clientes Update(string NOMBRE, string DIRECCION, string TELEFONO, string FAX, string NIT, string ATENCION,
        string DISTR, string CORREO, string DESCUENTO, string E_MAIL, string ANOTACIONES, string LISTA_NEGRA, string TIPO_RETENEDOR, string DIRECCION_ENTREGA, string ZONA_ENTREGA,
        string DPI, string PASAPORTE)
        {

            if (string.IsNullOrEmpty(NOMBRE)) throw new Exception("El nombre no puede estar en blanco");
            if (string.IsNullOrEmpty(DIRECCION)) throw new Exception("La direccion no puede estar en blanco");
            if (string.IsNullOrEmpty(TELEFONO)) throw new Exception("El telefono no puede estar en blanco");
            if (string.IsNullOrEmpty(FAX)) throw new Exception(" no puede estar en blanco");
            if (string.IsNullOrEmpty(ATENCION)) throw new Exception("Atencion no puede estar en blanco");
            if (string.IsNullOrEmpty(DISTR)) throw new Exception("El campo mayorista no puede estar en blanco");
            if (string.IsNullOrEmpty(CORREO)) throw new Exception("El correo no puede estar en blanco");
            if (string.IsNullOrEmpty(DESCUENTO)) throw new Exception("El descuento no puede estar en blanco");
            if (string.IsNullOrEmpty(E_MAIL)) throw new Exception("El nombre no puede estar en blanco");
            if (string.IsNullOrEmpty(ANOTACIONES)) throw new Exception("El codigo de sucursal no puede estar en blanco");
            if (string.IsNullOrEmpty(LISTA_NEGRA)) throw new Exception("Lista Negra no puede estar en blanco");
            if (string.IsNullOrEmpty(TIPO_RETENEDOR)) throw new Exception("El tipo de retenedor no puede estar en blanco");
            if (string.IsNullOrEmpty(DIRECCION_ENTREGA)) throw new Exception("La direccion de entrega no puede estar en blanco");
            if (string.IsNullOrEmpty(ZONA_ENTREGA)) throw new Exception("La zona no puede estar en blanco");

            return new Clientes()
            {
                NOMBRE = NOMBRE,
                DIRECCION = DIRECCION,
                TELEFONO = TELEFONO,
                FAX = FAX,
                NIT = NIT,
                ATENCION = ATENCION,
                DISTR = DISTR,
                CORREO = CORREO,
                DESCUENTO = Convert.ToSingle(DESCUENTO),
                E_MAIL = E_MAIL,
                ANOTACIONES = ANOTACIONES,
                LISTA_NEGRA = Convert.ToChar(LISTA_NEGRA),
                TIPO_DE_RETENEDOR = TIPO_RETENEDOR,
                DIRECCION_ENTREGA = DIRECCION_ENTREGA,
                ZONA_ENTREGA = Convert.ToInt32(ZONA_ENTREGA),
                DPI = DPI,
                PASAPORTE = PASAPORTE,
            };


        }




        //METODO PARA ELIMINAR EN CAPA DE DOMINIO
        public static Clientes Eliminar(string codigo)
        {
            ClientesRepository clientesRepository = new ClientesRepository();
            clientesRepository.Eliminar(codigo);
            return new Clientes();

        }



    }
}

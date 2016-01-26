using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public static class Cliente
    {

        public class CLNT 
        {

            int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            string apellido;

            public string Apellido
            {
                get { return apellido; }
                set { apellido = value; }
            }
            string telefono;

            public string Telefono
            {
                get { return telefono; }
                set { telefono = value; }
            }
            string numerodocumento;

            public string Numerodocumento
            {
                get { return numerodocumento; }
                set { numerodocumento = value; }
            }
            string domicilio;

            public string Domicilio
            {
                get { return domicilio; }
                set { domicilio = value; }
            }
            string cuit;

            public string Cuit
            {
                get { return cuit; }
                set { cuit = value; }
            }
            string cuil;

            public string Cuil
            {
                get { return cuil; }
                set { cuil = value; }
            }

            public CLNT(int p_id,
                string p_nombre,
            string p_apellido,
            string p_telefono,
            string p_numerodocumento,
            string p_domicilio,
            string p_cuit,
            string p_cuil) 
            {
                id = p_id;
                 nombre=p_nombre;
                 apellido=p_apellido;
                 telefono=p_telefono;
                 numerodocumento=p_numerodocumento;
                 domicilio=p_domicilio;
                 cuit=p_cuit;
                 cuil=p_cuil;
            }
        }




        public static void InsertarCliente(string p_Nombre, string p_Apellido, string p_telefono, string p_numerodocumento, string p_domicilio, string p_cuit, string p_cuil) 
        {

            Database1DataSetTableAdapters.QueriesTableAdapter QTA = new Database1DataSetTableAdapters.QueriesTableAdapter();
            QTA.InsertarCliente(p_Nombre, p_Apellido, p_telefono, p_numerodocumento, p_domicilio, p_cuit, p_cuil);
        }

        public static List<CLNT> ObtenerTodosLosClientes() 
        {
            List<CLNT> _tempClients = new List<CLNT>();
            Database1DataSet.ObtenerTodoLosClientesDataTable DT = new Database1DataSet.ObtenerTodoLosClientesDataTable();
            Database1DataSetTableAdapters.ObtenerTodoLosClientesTableAdapter TA = new Database1DataSetTableAdapters.ObtenerTodoLosClientesTableAdapter();
            TA.Fill(DT);
            if (DT.Rows.Count > 0) 
            {
                foreach (System.Data.DataRow DR in DT.Rows) 
                {
                    _tempClients.Add(new CLNT(
                        int.Parse(DR["Id"].ToString()),
                        DR["Nombre"].ToString(),
                        DR["Apellido"].ToString(),
                        DR["Telefono"].ToString(),
                        DR["NumeroDocumento"].ToString(),
                        DR["Domicilio"].ToString(),
                        DR["CUIT"].ToString(),
                        DR["CUIL"].ToString()
                        ));
                }
            }
            return _tempClients;
        }

    }
}

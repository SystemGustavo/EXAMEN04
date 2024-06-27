using Examen04.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen04.Datos
{
    public class DRegion
    {
        public void Registrar(ERegion objRegion)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("sp_CreateRegion", connection) ;
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.NVarChar, 100);
                parameter.Value = objRegion.RegionName;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = objRegion.Enabled;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();
                

            }
        }

        public void Actualizar(ERegion objRegion)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("sp_UpdateRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter1 = new SqlParameter("@RegionName", SqlDbType.NVarChar, 100);
                parameter1.Value = objRegion.RegionName;
                command.Parameters.Add(parameter1);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = objRegion.Enabled;
                command.Parameters.Add(parameter2);

                SqlParameter parameter3 = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter3.Value = objRegion.RegionId;
                command.Parameters.Add(parameter3);

                command.ExecuteNonQuery();


            }
        }

        public void Eliminar(int RegionID)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_DeleteRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value = RegionID;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

            }
        }


        public List<ERegion> ListarRegiones()
        {

            List<ERegion> regiones = new List<ERegion>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("sp_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {

                    int RegionId = reader.GetInt32(0);
                    string RegionName = reader.GetString(1);
                    bool Enabled = reader.GetBoolean(2);

                    regiones.Add(new ERegion { RegionId = RegionId, RegionName = RegionName, Enabled = Enabled });
                }
                reader.Close();
            }
            return regiones;

        }
    }
}

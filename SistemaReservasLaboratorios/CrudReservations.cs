using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservasLaboratorios
{
    internal class CrudReservations
    {
        public class Laboratory
        {
            public string NameLab { get; set; }
            public string Available { get; set; }

        }



        public static int? verificationAvailableReserve(Reserve reserve)
        {
            int? idLab = null;

            using (SqlConnection cnn = conection.Conection())
            {
                try
                {
                    string query = "SELECT IdLab, Avaliable FROM laboratories WHERE LabNumber = @LabNumber";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@LabNumber", reserve.Laboratory);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        bool available = reader.GetBoolean(1); // Avaliable es bit
                        if (available)
                        {
                            idLab = reader.GetInt32(0); // existe y disponible
                        }
                        else
                        {
                            idLab = -1; // existe pero no disponible
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener IdLab: " + ex.Message);
                }
            }

            return idLab;
        }

        public static void CreateUserAndReservation(Reserve reserve, int idLab)
        {
            using (SqlConnection cnn = conection.Conection())
            {
                try
                {
                    int idUser;

                    // Verificar si el usuario existe
                    string checkUserQuery = "SELECT IdUser FROM [User] WHERE name = @Name";
                    SqlCommand cmdCheck = new SqlCommand(checkUserQuery, cnn);
                    cmdCheck.Parameters.AddWithValue("@Name", reserve.Name);

                    object result = cmdCheck.ExecuteScalar();

                    if (result != null)
                    {
                        idUser = (int)result;
                    }
                    else
                    {
                        // Crear usuario y obtener IdUser autoincremental
                        string insertUserQuery = "INSERT INTO [User] (name) OUTPUT INSERTED.IdUser VALUES (@Name)";
                        SqlCommand cmdUser = new SqlCommand(insertUserQuery, cnn);
                        cmdUser.Parameters.AddWithValue("@Name", reserve.Name);
                        idUser = (int)cmdUser.ExecuteScalar();
                    }

                    // Crear reserva con IdUser e IdLab
                    string insertReserveQuery = @"INSERT INTO Reservations 
                                          (Laboratory, Date_start, Date_end, IdUser, IdLab) 
                                          VALUES (@Laboratory, @DateStart, @DateEnd, @IdUser, @IdLab)";
                    SqlCommand cmdReserve = new SqlCommand(insertReserveQuery, cnn);
                    cmdReserve.Parameters.AddWithValue("@Laboratory", reserve.Laboratory);
                    cmdReserve.Parameters.AddWithValue("@DateStart", reserve.Date_start);
                    cmdReserve.Parameters.AddWithValue("@DateEnd", reserve.Date_end);
                    cmdReserve.Parameters.AddWithValue("@IdUser", idUser);
                    cmdReserve.Parameters.AddWithValue("@IdLab", idLab);

                    cmdReserve.ExecuteNonQuery();

                    // Marcar laboratorio como ocupado
                    string updateLabQuery = "UPDATE laboratories SET Avaliable = 0 WHERE IdLab = @IdLab";
                    SqlCommand cmdUpdateLab = new SqlCommand(updateLabQuery, cnn);
                    cmdUpdateLab.Parameters.AddWithValue("@IdLab", idLab);
                    cmdUpdateLab.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear usuario y reserva: " + ex.Message);
                }
            }
        }





        public static List<Laboratory> ListarLaboratorios()
        {
            List<Laboratory> lista = new List<Laboratory>();

            using (SqlConnection cnn = conection.Conection())
            {
                try
                {
                    string query = "SELECT LabNumber , Avaliable  FROM laboratories";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Laboratory lab = new Laboratory();
                        lab.NameLab = reader.GetString(0);
                        bool avaliable = reader.GetBoolean(1);
                        lab.Available = avaliable ? "Disponible" : "No disponible";
                        lista.Add(lab);
                    }

                    reader.Close(); // Cierra el lectors
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar laboratorios: " + ex.Message);
                }
            }

            return lista;
        }

       
    }
}

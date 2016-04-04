using System;
using System.Data.Objects;
using System.Linq;
using MySql.Data.MySqlClient;

namespace app2
{
    class DipendenteRepository : IRepository<Dipendente>
    {
        string connString = "Server=localhost;Database=palmi;Uid=admin;Pwd=password";

        public void Add(ref Dipendente model)
        {
            using (var db = new MySqlConnection(connString))
            {
                db.Open();
                var cmd = db.CreateCommand();
                cmd.CommandText = "dipendente_ins";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var newId = new MySqlParameter("@new_id", MySqlDbType.Int32);
                newId.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(newId);

                cmd.Parameters.AddWithValue("@cognome", model.Cognome);
                cmd.Parameters.AddWithValue("@nome", model.Nome);
                cmd.Parameters.AddWithValue("@matricola", null);
                cmd.Parameters.AddWithValue("@qualifica", null);
                cmd.Parameters.AddWithValue("@luogo_nascita", null);
                cmd.Parameters.AddWithValue("@data_nascita", null);
                cmd.Parameters.AddWithValue("@codice_fiscale", null);
                cmd.Parameters.AddWithValue("@cittadinanza", null);
                cmd.Parameters.AddWithValue("@indirizzo_residenza", null);
                cmd.Parameters.AddWithValue("@cap", null);
                cmd.Parameters.AddWithValue("@comune_residenza", null);
                cmd.Parameters.AddWithValue("@telefono", null);
                cmd.Parameters.AddWithValue("@cellulare1", null);
                cmd.Parameters.AddWithValue("@cellulare2", null);
                cmd.Parameters.AddWithValue("@cellulare3", null);
                cmd.Parameters.AddWithValue("@data_assunzione", null);
                cmd.Parameters.AddWithValue("@data_cessazione", null);

                int ret = cmd.ExecuteNonQuery();
                model.Id = (int)newId.Value;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Dipendente GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

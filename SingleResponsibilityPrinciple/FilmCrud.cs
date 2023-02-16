using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SingleResponsibilityPrinciple
{
    public class FilmCrud
    {
        public void FilmList()
        {
            SqlCommand command1 = new SqlCommand("select * from TblFilm ", ConnectionSql.connect);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4] + " " + dr[5]);
            }

            command1.Connection.Close();

        }

        public int FilmAdd(FilmDef f)
        {
            SqlCommand commandAddFilm = new SqlCommand("insert into TblFilm (NAME,GENRE,POINT,CATEGORY,IMAGE) values (@p2,@p3,@p4,@p5,@p6)",ConnectionSql.connect);
            if (commandAddFilm.Connection.State != ConnectionState.Open)
            {
                commandAddFilm.Connection.Open();
            }
            commandAddFilm.Parameters.AddWithValue("@p2", f.NAME);
            commandAddFilm.Parameters.AddWithValue("@p3", f.GENRE);
            commandAddFilm.Parameters.AddWithValue("@p4", f.POINT);
            commandAddFilm.Parameters.AddWithValue("@p5", f.CATEGOTY);
            commandAddFilm.Parameters.AddWithValue("@p6", f.PATH);
            //commandAddFilm.Connection.Close();

            return commandAddFilm.ExecuteNonQuery();
        }

    }
}

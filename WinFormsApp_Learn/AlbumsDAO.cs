using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp_Learn
{
    internal class AlbumsDAO
    {
        // version 1 only contains fake data. No connection to actual db
        //public List<Album> albums = new List<Album>() ;

        // connect to Mysql database

        string connectionString = "server=localhost;Uid=root;Pwd=312314;" +
            "                   Database=music;";

        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnThese = new List<Album>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            // define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT * FROM albums;", 
                connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            //as MySqlDataReader)
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)

                    };

                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;

        }


        public List<Album> searchTitles(string searchTerm)
        {
            // start with an empty list
            List<Album> returnThese = new List<Album>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            // define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = 
                "SELECT * FROM albums WHERE album_title LIKE @search";
            
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            //as MySqlDataReader)
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)

                    };

                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;

        }


    }
}

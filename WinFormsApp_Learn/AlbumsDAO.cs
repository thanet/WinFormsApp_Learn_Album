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

        string connectString = "datasource=localhost;port=3306;username=root;password=312314," +
            "                   database=music;";

        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnThese = new List<Album>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection
                (connectString);
            connection.Open();

            return returnThese;

        }


    }
}

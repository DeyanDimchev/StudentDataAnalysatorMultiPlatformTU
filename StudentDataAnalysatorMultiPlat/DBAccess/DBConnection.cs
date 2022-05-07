using StudentDataAnalysatorMultiPlat.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentDataAnalysatorMultiPlat.DBAccess
{



    public class DBConnection
    {

        string ConnectionString = "";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
        
        public void WriteStatisticalDispersionResult(ObservableCollection<StatisticalDispersionResult> sdr) { }



        //public SqlDataReader DataReader(string Query_)
        //{
        //    SqlCommand cmd = new SqlCommand(Query_, con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    return dr;
        //}


        //public object ShowDataInGridView(string Query_)
        //{
        //    SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
        //    DataSet ds = new DataSet();
        //    dr.Fill(ds);
        //    object dataum = ds.Tables[0];
        //    return dataum;
        //}
    }

    public class CopyOfDBConnection
    {

        string ConnectionString = "";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public void WriteStatisticalDispersionResult(ObservableCollection<StatisticalDispersionResult> sdr) { }



        //public SqlDataReader DataReader(string Query_)
        //{
        //    SqlCommand cmd = new SqlCommand(Query_, con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    return dr;
        //}


        //public object ShowDataInGridView(string Query_)
        //{
        //    SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
        //    DataSet ds = new DataSet();
        //    dr.Fill(ds);
        //    object dataum = ds.Tables[0];
        //    return dataum;
        //}
    }
}

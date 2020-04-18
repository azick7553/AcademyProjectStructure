using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

using lesson3.Models;

namespace lesson3
{
    public class Company : IQueryable<Company>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public int InsertOne(Company model)
        {
            SqlConnection conn = new SqlConnection(DataAccess.MSSqlDA.ConnectionString);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string insertCommand = $"Insert into Company([CompanyName]) Values('{model.CompanyName}');";
            SqlCommand comm = new SqlCommand(insertCommand, conn);
            var result = comm.ExecuteNonQuery();
            return result;
        }

        public List<Company> SelectAll()
        {
            List<Company> compList = new List<Company>();

            SqlConnection conn = new SqlConnection(DataAccess.MSSqlDA.ConnectionString);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string selectCommand = "Select * from Company";
            SqlCommand comm = new SqlCommand(selectCommand, conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                var comp = new Company();
                comp.Id = Convert.ToInt32(reader.GetValue(0).ToString());
                comp.CompanyName = reader.GetValue(1).ToString();
                compList.Add(comp);
            }
            if (conn.State != ConnectionState.Closed) conn.Close();
            return compList;
        }

        public Company SelectById(int id)
        {
            Company company = new Company();

            SqlConnection conn = new SqlConnection(DataAccess.MSSqlDA.ConnectionString);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string selectCommand = "Select * from Company";
            SqlCommand comm = new SqlCommand(selectCommand, conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                company.Id = Convert.ToInt32(reader.GetValue(0).ToString());
                company.CompanyName = reader.GetValue(1).ToString();
            }
            if (conn.State != ConnectionState.Closed) conn.Close();
            return company;
        }
    }
}
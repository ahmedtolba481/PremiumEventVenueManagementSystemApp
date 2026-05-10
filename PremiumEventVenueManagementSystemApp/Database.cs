using System;
using System.Data;
using System.Data.SqlClient;

namespace PremiumEventVenueManagementSystemApp
{
    internal static class Database
    {
        public static SqlConnection con =
            new SqlConnection(
                @"Data Source=AHMED-LAPTOP;
                Initial Catalog=PremiumEventVenueManagementSystem;
                Integrated Security=True");


        internal const string PurchaseTableQualified = "[dbo].[PURCHASE]";
        internal const string EntryPassTableQualified = "[dbo].[ENTRYPASS]";


     
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                try
                {
                    con.Open();
                    return cmd.ExecuteScalar();
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        public static DataTable FillDataTable(string sql, params SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static void FillDataTable(DataTable dt, string sql, params SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                try
                {
                    con.Open();
                    using (var adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(dt);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }
    }
}

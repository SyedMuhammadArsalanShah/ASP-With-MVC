﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lecture06TraditionalBusinesslayerWithoutEF.Models
{
    public class TraditonalLayer
    {


        public IEnumerable<Teachers> teachers
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
                List<Teachers> teachers = new List<Teachers>();


                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("select * from info " ,con);
                    con.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Teachers teacher = new Teachers();

                        teacher.Id      = Convert.ToInt32(dataReader["Id"]);
                        teacher.name    = dataReader["Name"].ToString();
                        teacher.contact = dataReader["contact"].ToString();
                        teacher.salary  = Convert.ToInt32(dataReader["salary"]);
                        teachers.Add(teacher);


                    }

                }

                return teachers;
            }

        }

    }
}
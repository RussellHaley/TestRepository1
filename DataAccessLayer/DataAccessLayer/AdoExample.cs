using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OIS.CA.DataAccessLayer
{
	public class ADODataAccess
	{
		private string UserName { get; set; }

		private string Password { get; set; }

		private string ServerName { get; set; }

		private string DatabaseName { get; set; }

		public string ConString { get; set; }

		public ADODataAccess(string serverName, string userName, string password)
		{
			UserName = userName;
			Password = password;
			ServerName = serverName;
			DatabaseName = "PersonModel";

			ConString = "Data source=" + ServerName + "; Initial Catalog=" + DatabaseName + "; user ID=" + UserName + "; password=" + Password;
			
		}

		public IDataReader GetPerson(string firstName, string lastName)
		{
			SqlConnection con = new SqlConnection(ConString);
			
				SqlCommand comm = new SqlCommand();
				comm.CommandText = "select * from person";
				comm.Connection = con;
				con.Open();

				SqlDataReader reader = comm.ExecuteReader(CommandBehavior.CloseConnection);



				return reader;
		}
	}
}

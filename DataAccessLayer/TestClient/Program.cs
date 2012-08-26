using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OIS.CA.DataAccessLayer;
using System.Data;


namespace OIS.CA.TestClient
{
	class Program
	{
		static void Main(string[] args)
		{
			ADODataAccess da = new ADODataAccess("layne\\sqlexpress","DevUser","DevUser");

			Console.Write(da.ConString);

			Console.ReadLine();

			OutputPeople(da.GetPerson("russell", "haley"));
		}

		static void OutputPeople(IDataReader reader)
		{
			while (reader.Read())
			{
				Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2],reader[3]);
			}
			reader.Close();
			Console.ReadLine();
		}
	}
}

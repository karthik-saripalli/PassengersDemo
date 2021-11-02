using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BALFlights;

namespace DALFlights
{
    public class FlightsDAL
    {
        public DataTable showAllDetails()
        {
            SqlConnection con = new SqlConnection("server=LAPTOP-362TBH8P\\SQLEXPRESS;integreated security=true;database=FlightDB");
            SqlDataAdapter da = new SqlDataAdapter("select * from Flights", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "Flights");
            return ds.Tables[0];
        }
    }
}

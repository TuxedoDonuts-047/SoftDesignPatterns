using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using String = System.String;

namespace DatabaseConnect
{
    class Reservation
    {
        private int resNo;
        private int hobbyID;
        private int tableNo;
        private String name;
        private String phoneNo;
        private String email;
        private String resDate;
        private String resTime;
        private String cardNo;
        private String status;

        //Reservation()
        public Reservation()
        {
            this.resNo = 0;
            this.hobbyID = 0;
            this.tableNo = 0;
            this.name = "";
            this.phoneNo = "";
            this.email = "";
            this.resDate = "dd:mmm:yyyy";
            this.resTime = "hh:mm";
            this.cardNo = "";
            this.status = "U";//U is for Unchecked
        }
        //Reservation(int,int,int,String,String,String,String,String,String,String)
        public Reservation(int resNo, int hobbyID, int tableNo, String name, String phoneNo, String email, String resDate, String resTime, String cardNo, String status)
        {
            this.resNo = resNo;
            this.hobbyID = hobbyID;
            this.tableNo = tableNo;
            this.name = name;
            this.phoneNo = phoneNo;
            this.email = email;
            this.resDate = resDate;
            this.resTime = resTime;
            this.cardNo = cardNo;
            this.status = status;
        }

        //Getters
        public int GetResNo() { return resNo; }
        public int GetTableNo() { return tableNo; }
        public int GetHobbyID() { return hobbyID; }
        public String GetName() { return name; }
        public String GetPhoneNo() { return phoneNo; }
        public String GetEmail() { return email; }
        public String GetResDate() { return resDate; }
        public String GetResTime() { return resTime; }
        public String GetCardNo() { return cardNo; }
        public String GetStatus() { return status; }

        //Setters
        public int SetResNo(int ResNo) { return this.resNo = ResNo; }
        public int SetTableNo(int TableNo) { return this.tableNo = TableNo; }
        public int SetHobbyID(int HobbyID) { return this.hobbyID = HobbyID; }
        public String SetName(String Name) { return this.name = Name; }
        public String SetPhoneNo(String PhoneNo) { return this.phoneNo = PhoneNo; }
        public String SetEmail(String Email) { return this.email = Email; }
        public String SetResDate(String ResDate) { return this.resDate = ResDate; }
        public String SetResTime(String ResTime) { return this.resTime = ResTime; }
        public String SetCardNo(String CardNo) { return this.cardNo = CardNo; }
        public String SetStatus(String Status) { return this.status = Status; }

        //GetNextResNo(int ResNo)
        public static int GetNextResNo(int ResNo)
        {
            return GetNextResNo(ResNo);
        }

        //GetNextResNo()
        public static int GetNextResNo()
        {
            string sqlQuery = "SELECT MAX(ResNo) " +
                              "FROM Reservations";
            int nextNo;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.IsDBNull(0))
            {
                nextNo = 1;
            }
            else
            {
                nextNo = dr.GetInt32(0) + 1;
            }
            //Close db connection
            conn.Close();
            return nextNo;
        }

        //makeReservation()
        public void makeReservation()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "INSERT INTO Reservations Values (" +
               GetResNo() + " ,'" +
               GetHobbyID() + "','" +
               GetTableNo() + "','" +
               GetName() + "','" +
               GetPhoneNo() + "','" +
               GetEmail() + "','" +
               GetResDate() + "','" +
               GetResTime() + "','" +
               GetCardNo() + "','" +
               GetStatus() + "')";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //getReservation()
        public void getReservation(int ResNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT * " +
                              "FROM Reservations " +
                              "WHERE ResNo = " + ResNo;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            SetResNo(dr.GetInt32(0));
            SetHobbyID(dr.GetInt32(1));
            SetTableNo(dr.GetInt32(2));
            SetName(dr.GetString(3));
            SetPhoneNo(dr.GetString(4));
            SetEmail(dr.GetString(5));
            SetResDate(dr.GetString(6));
            SetResTime(dr.GetString(7));
            SetCardNo(dr.GetString(8));
            SetStatus(dr.GetString(9));
            conn.Close();
        }

        //cancelReservation()
        public void cancelReservation()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "UPDATE Reservations SET " +
                              "Status = 'C' " +//C for Cancelled
                              "WHERE ResNo = " + this.resNo;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //checkInCustomer()
        public void checkInCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "UPDATE Reservations SET " +
                              "Status = 'I' " +
                              "Where ResNo = " + this.resNo;//I = checked In
            OracleCommand cmd = new OracleCommand(sqlQuery,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //checkOutCustomer()
        public void checkOutCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "UPDATE Reservations SET " +
                              "Status = 'O' " +
                              "WHERE ResNo = " + this.resNo;//O = checked Out
            OracleCommand cmd = new OracleCommand(sqlQuery,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //checkDateCustomer()
        public static DataSet checkDateCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT * " +
                              "FROM Reservations " +
                              "WHERE Status = 'B' " +
                              "AND TO_DATE(ResDate, 'DD-MM-YYYY') = TRUNC(SYSDATE) " +
                              "ORDER BY ResNo";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn); 
            OracleDataAdapter da = new OracleDataAdapter(cmd); 
            DataSet ds = new DataSet();  
            da.Fill(ds, "res"); 
            conn.Close(); 
            return ds;
        }

        //getBookedRes()
        public static DataSet getBookedRes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT ResNo, HobbyID, TableNo,Name,PhoneNo,Email,ResDate,ResTime,CardNo,Status " +
                              "FROM RESERVATIONS " +
                              "WHERE Status = 'B' " +
                              "ORDER BY ResNo";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "res");
            conn.Close();
            return ds;
        }

        //getCheckedRes()
        public static DataSet getCheckedRes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT ResNo, HobbyID, TableNo,Name,PhoneNo,Email,ResDate,ResTime,CardNo,Status " +
                              "FROM RESERVATIONS " +
                              "WHERE Status = 'I' " +
                              "ORDER BY ResNo";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "res");
            conn.Close();
            return ds;
        }

        //GetAverageRevenue()
        public static DataSet GetAverageRevenue()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT H.HobbyID, H.Description, " +
                              "COUNT(R.ResNo) AS Total_Res, " +
                              "SUM(H.Price) AS Total_Rev_Eur, " +
                              "SUM(H.Price) / COUNT(R.ResNo) AS Avg_Rev_Eur " +
                              "FROM Reservations R " +
                              "INNER JOIN Hobbies H ON H.HobbyID = R.HobbyID " +
                              "GROUP BY H.HobbyID,H.Description " +
                              "ORDER BY Avg_Rev_Eur DESC";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "res");
            conn.Close();
            return ds;
        }
    }//I was unable to get the chart into a graph format but i was able to display average 
}
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseConnect
{
    internal class Table
    {
        private int tableNo;
        private int hobbyID;
        private string status;

        //Table()
        public Table()
        {
            tableNo = 0;
            hobbyID = 0;
            status = "";
        }

        //Table(int,int,string)
        public Table(int tableNo, int hobbyID , string status)
        {
            this.tableNo = tableNo;
            this.hobbyID = hobbyID;
            this.status = status;
        }

        //Getters
        public int getTableNo() { return tableNo; }
        public int getHobbyID() { return hobbyID; }
        public string getStatus() { return status; }

        //Setters
        public int setTableNo(int TableNo) { return this.tableNo = TableNo; }
        public int setHobbyID(int HobbyID) { return this.hobbyID =HobbyID; }
        public string setStatus(string Status) { return this.status = Status; }

        //GetNextTableNo()
        public static int GetNextTableNo()
        {
            string sqlQuery = "SELECT MAX(TableNo) FROM Tables";
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

        //addTable()
        public void addTable()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "INSERT INTO Tables Values (" +
               getTableNo() + " ," +
               getHobbyID() + " ,'" +
               getStatus() + "')";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //changeTable()
        public void changeTable()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "UPDATE Tables SET " +
                               "HobbyID = " + this.hobbyID + ", " +
                               "Status = 'O' "+
                               "WHERE TableNo = " + this.tableNo;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //GetOpenTables()
        public static DataSet GetOpenTables()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT TableNo,HobbyID,Status " +
                                "FROM Tables " +
                                "WHERE Status = 'O' " +
                                "ORDER BY TableNo";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tab");
            conn.Close();
            return ds;
        }

        //getTable(int TableNo)
        public void getTable(int TableNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT TableNo, " +
                              "HobbyID, " +
                              "Status " +
                              "FROM Tables  " +
                              "WHERE TableNo =" + TableNo;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setTableNo(dr.GetInt32(0));
            setHobbyID(dr.GetInt32(1));
            setStatus(dr.GetString(2));
            
            conn.Close();
        }

        //closeTable()
        public void closeTable()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "UPDATE Tables SET " +
                              "Status = 'C' " +
                              "WHERE TableNo = " + this.tableNo;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //GetHobbyTable(int HobbyID)
        public static DataSet GetHobbyTable(int HobbyID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT t.TableNo, t.HobbyID, t.Status " +
                              "FROM Tables t " +
                              "JOIN Hobbies h ON h.HobbyID = t.HobbyID " +
                              "WHERE t.Status = 'O' " +
                              "AND h.HobbyID = " + HobbyID + 
                              "ORDER BY t.TableNo";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tab");
            conn.Close();
            return ds;
        }
    }
}

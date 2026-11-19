using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Runtime.CompilerServices;

namespace DatabaseConnect
{
    internal class Hobby
    {
        private int hobbyID;
        private string description;
        private int playerNum;
        private decimal price;

        //Hobby()
        public Hobby()
        {
            hobbyID = 0;
            description = "";
            playerNum = 0;
            price = 0;
        }

        //Hobby(int hobbyID, string description, int playerNum, decimal price)
        public Hobby(int hobbyID, string description, int playerNum, decimal price)
        {
            this.hobbyID = hobbyID;
            this.description = description;
            this.playerNum = playerNum;
            this.price = price;
        }

        //Getters
        public int GetHobbyID() { return hobbyID; }
        public string GetDescription() { return description; }
        public int GetPlayerNum() { return playerNum; }
        public decimal GetPrice() { return price; }

        //Setters
        public void SetDescription(string Description) { this.description = Description; }
        public void SetPlayerNum(int PlayerNum) { this.playerNum = PlayerNum; }
        public void SetPrice(decimal Price) { this.price = Price; }
        public void SetHobbyID(int HobbyID) { this.hobbyID = HobbyID; }

        //GetNextHobbyID()
        public static int GetNextHobbyID(int HobbyID)
        {
            return GetNextHobbyID(HobbyID);
        }

        //GetNextHobbyID()
        public static int GetNextHobbyID()
        {
            String sqlQuery = "SELECT MAX(HobbyID) FROM Hobbies";
            int nextID;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.IsDBNull(0))
            {
                nextID = 1;
            }
            else
            {
                nextID = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();
            return nextID;

        }

        //addHobby()
        public void addHobby()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "INSERT INTO Hobbies Values (" +
               GetHobbyID() + " ,'" +
               GetDescription() + "','" +
               GetPlayerNum() + "','" +
               GetPrice() + "')";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        //updateHobby()
        public void updateHobby()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //SQL Code
            String sqlQuery = "UPDATE Hobbies SET " +
                "Description = '" + this.description + "'," +
                "PlayerNum = " + this.playerNum + "," +
                "Price = " + this.price + " " +
                "WHERE HobbyID = " + this.hobbyID;

            //SQL Query Execution
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //GetAllHobbies()
        public static DataSet GetAllHobbies()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT HobbyID, Description,PlayerNum,Price " +
                              "FROM Hobbies " +
                              "ORDER BY HobbyID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "hob");
            conn.Close();
            return ds;
        }

        //GetTotalHobbies()
        public static DataSet GetTotalHobbies()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT H.HobbyID, H.Description, " +
                              "H.Price, SUM(H.Price) AS Total_Year " +
                              "FROM Hobbies H " +
                              "LEFT JOIN Reservations R ON H.HobbyID = R.HobbyID " +
                              "GROUP BY H.HobbyID, H.Description, H.Price "+
                              "ORDER BY Total_Year DESC";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "hob");
            conn.Close();
            return ds;
        }

        //getHobby()
        public void getHobby(int HobbyID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT HobbyID,Description, PlayerNum, Price " +
                              "FROM Hobbies " +
                              "WHERE HobbyID = " + HobbyID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            SetHobbyID(dr.GetInt32(0));
            SetDescription(dr.GetString(1));
            SetPlayerNum(dr.GetInt32(2));
            SetPrice(dr.GetDecimal(3));

            conn.Close();
        }
    }
}

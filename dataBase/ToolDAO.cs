using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseClass
{
    internal class ToolDAO
    {
 
        string connectionString =
             "Server=127.0.0.1;port=3306;username=username;password=password;database=machine_tools";

        public List<ToolAtribute> GetAllToolData()
        {
            List<ToolAtribute> returnTool = new List<ToolAtribute>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ID, TOOL_NUMBER, TOOL_NAME, TOOL_TYPE, ON_MACHINE FROM TOOL_INFO", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ToolAtribute toolAtribute = new ToolAtribute
                    {
                        ID = reader.GetInt32(0),
                        ToolNumber = reader.GetInt32(1),
                        ToolName = reader.GetString(2),
                        ToolType = ConvertStringToToolEnum(reader.GetString(3)),
                        OnMachine = reader.GetString(4),
                    };
                    returnTool.Add(toolAtribute);
                }
            }

            connection.Close();
            return returnTool;
        }

        public List<ToolAtribute> GetSearchToolName(string searchTerm)
        {
            List<ToolAtribute> returnTool = new List<ToolAtribute>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, TOOL_NUMBER, TOOL_NAME, TOOL_TYPE, ON_MACHINE FROM TOOL_INFO WHERE TOOL_NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ToolAtribute toolAtribute = new ToolAtribute
                    {
                        ID = reader.GetInt32(0),
                        ToolNumber = reader.GetInt32(1),
                        ToolName = reader.GetString(2),
                        ToolType = ConvertStringToToolEnum(reader.GetString(3)),
                        OnMachine = reader.GetString(4),
                    };
                    returnTool.Add(toolAtribute);
                }
            }

            connection.Close();
            return returnTool;

        }

        public List<ToolAtribute> GetSearchToolNumber(int searchTerm)
        {
            List<ToolAtribute> returnTool = new List<ToolAtribute>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, TOOL_NUMBER, TOOL_NAME, TOOL_TYPE, ON_MACHINE FROM TOOL_INFO WHERE TOOL_NUMBER LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ToolAtribute toolAtribute = new ToolAtribute
                    {
                        ID = reader.GetInt32(0),
                        ToolNumber = reader.GetInt32(1),
                        ToolName = reader.GetString(2),
                        ToolType = ConvertStringToToolEnum(reader.GetString(3)),
                        OnMachine = reader.GetString(4),
                    };
                    returnTool.Add(toolAtribute);
                }
            }

            connection.Close();
            return returnTool;

        }

        public List<ToolOffset> GetOffsetMagazine(int ToolID)
        {
            List<ToolOffset> returnTool = new List<ToolOffset>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

           

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM MAGAZINE WHERE TOOL_INFO_ID = @ToolID";
            command.Parameters.AddWithValue("@ToolID", ToolID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ToolOffset tooloffset = new ToolOffset
                    {
                        ID = reader.GetInt32(0),
                        Xoffset = reader.GetDecimal(1),
                        Yoffset = reader.GetDecimal(2),
                        Zoffset = reader.GetDecimal(3),
                        dateTime = reader.GetDateTime(4),
                    };
                    returnTool.Add(tooloffset);
                }
            }

            connection.Close();
            return returnTool;

        }

        public List<ToolOffset> GetOffsetMachine(int ToolID)
        {
            List<ToolOffset> returnTool = new List<ToolOffset>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();



            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM MACHINE WHERE TOOL_INFO_ID = @ToolID";
            command.Parameters.AddWithValue("@ToolID", ToolID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ToolOffset tooloffset = new ToolOffset
                    {
                        ID = reader.GetInt32(0),
                        Xoffset = reader.GetDecimal(1),
                        Yoffset = reader.GetDecimal(2),
                        Zoffset = reader.GetDecimal(3),
                        dateTime = reader.GetDateTime(4),
                    };
                    returnTool.Add(tooloffset);
                }
            }

            connection.Close();
            return returnTool;

        }
            public ToolTypeEnum ConvertStringToToolEnum(string stringToConvert)
        {
            if (stringToConvert == "Milling")
                return ToolTypeEnum.Mill;
            else if (stringToConvert == "Tapered")
                return ToolTypeEnum.Tap;
            else if (stringToConvert == "Drilling")
                return ToolTypeEnum.Drill;
            else
                return ToolTypeEnum.Uknown;
              
        }

    }
}

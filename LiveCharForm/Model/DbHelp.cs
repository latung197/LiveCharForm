using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office2013StyleSplashScreen.Model
{
    public class DbHelp
    {
        private static SqlConnection conn = null;

        public static string DBConnString { get; private set; }
        public static bool bDBConnCheck = false;
        private static int errorBoxCount = 0;
        /// <summary>
        /// 생성자
        /// </summary>
        public DbHelp() { }


        public static SqlConnection DBConn
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }

        /// <summary>
        /// Database 접속 시도
        /// </summary>
        /// <returns></returns>
        public static bool ConnectToDB()
        {
            if (conn == null)
            {
                //StreamReader SR = new StreamReader(Application.StartupPath + @"\SqlMap.config");
                //string sConfig = SR.ReadToEnd();
                //sConfig.IndexOf("connectionString");
                //sConfig = sConfig.Substring(sConfig.IndexOf("connectionString"), 160);
                //sConfig = sConfig.Substring(sConfig.IndexOf(";") + 1);
                //sConfig = sConfig.Substring(0, sConfig.IndexOf("/>") - 1);
                //DBConnString = sConfig;

                //App.config 이용(21.07.22.)
                //DBConnString = Configurations.GetConfig("DBConnstring");

                //서버명, 초기 DB명, 인증 방법
                conn = new SqlConnection(DBConnString);
            }
            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        bDBConnCheck = true;
                    }
                    else
                    {
                        bDBConnCheck = false;
                    }
                }
            }
            catch (SqlException e)
            {
                errorBoxCount++;
                if (errorBoxCount == 1)
                {
                }
                return false;
            }
            return true;
        }


        /// <summary>
        /// Database Open 여부 확인
        /// </summary>
        public static bool IsDBConnected
        {
            get
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Database 해제
        /// </summary>
        public static void Close()
        {
            if (IsDBConnected)
                DBConn.Close();
        }

        public static void Clear()
        {
            if (conn != null)
                conn = null;
        }


        public static DataTable Adapter(StringBuilder Query)
        {
            try
            {
                if (Query.Length <= 0 || Query == null)
                    return null;
                else
                {
                    DataTable table = new DataTable();
                    ConnectToDB();

                    var adapter = new SqlDataAdapter(Query.ToString(), DBConn);
                    adapter.Fill(table);

                    return table;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Command(StringBuilder Query)
        {
            try
            {
                if (Query.Length <= 0 || Query == null)
                    return;
                else
                {
                    ConnectToDB();
                    SqlCommand comm = new SqlCommand(Query.ToString(), DBConn);
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}

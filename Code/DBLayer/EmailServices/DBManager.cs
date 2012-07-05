using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using DatabaseLayer;
using System.Diagnostics;
namespace EmailServices
{
    /// <summary>
    /// Management connection for database and execute store or sql command
    /// </summary>
    static class DBManager
    {
        #region "global variable"
        //public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SharelendarConnect"].ToString();
       // private static SqlConnection objConn = null;

      //
          
        #endregion

        public static void initConnection(){
            Globals.ConnectionString = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["EmailConnectionString"].ToString());
            ChilkatEmail.Utils.Constants.strSmtpHost = System.Configuration.ConfigurationManager.AppSettings["SmtpServer"].ToString();
            ChilkatEmail.Utils.Constants.strSmtpUser = System.Configuration.ConfigurationManager.AppSettings["AuthenticationMailUser"].ToString();
            ChilkatEmail.Utils.Constants.strSmtpPass = System.Configuration.ConfigurationManager.AppSettings["AuthenticationMailPassword"].ToString();
            ChilkatEmail.Utils.Constants.emailSentPerTime = int.Parse(System.Configuration.ConfigurationManager.AppSettings["emailSentPerTime"].ToString());
            ChilkatEmail.Utils.Constants.bounceEmailAddress = System.Configuration.ConfigurationManager.AppSettings["BounceAddress"].ToString();
            ChilkatEmail.Utils.Constants.bounceEmailPassword = System.Configuration.ConfigurationManager.AppSettings["BounceEmailPassword"].ToString();
            Debug.WriteLine("Globals.ConnectionString=" + Globals.ConnectionString);
            Debug.WriteLine("strSmtpHost" + ChilkatEmail.Utils.Constants.strSmtpHost);
            Debug.WriteLine("strSmtpUser=" + ChilkatEmail.Utils.Constants.strSmtpUser);
            Debug.WriteLine("strSmtpPass=" + ChilkatEmail.Utils.Constants.strSmtpPass);
             Debug.WriteLine("emailSentPerTime=" + ChilkatEmail.Utils.Constants.emailSentPerTime);
             Debug.WriteLine("bounceEmailAddress="+ChilkatEmail.Utils.Constants.bounceEmailAddress);
             Debug.WriteLine("bounceEmailPassword="+ChilkatEmail.Utils.Constants.bounceEmailPassword);
        }
        /// <summary>
        /// Open a connection. Check if connection' state is closing then open connection 
        /// </summary>
        /// <returns></returns>
        //public static bool OpenConnection()
        //{
            
            
            
        //    try
        //    {
        //        if (DBManager.objConn == null || DBManager.objConn.State == ConnectionState.Closed)
        //        {
        //            DBManager.objConn = new SqlConnection(DBManager.ConnectionString);
        //            DBManager.objConn.Open();
        //        }
        //        return true;
        //    }
        //    catch { }
        //    return false;
        //}

        ///// <summary>
        ///// Close Connection. If connection's state is openning then close connection
        ///// </summary>
        ///// <returns></returns>
        //public static bool CloseConnection()
        //{
        //    try
        //    {
        //        if (DBManager.objConn.State == ConnectionState.Open)
        //        {
        //            DBManager.objConn.Close();
        //            return true;
        //        }
        //        return true;
        //    }
        //    catch { }
        //    return false;

        //}

        ///// <summary>
        ///// Execute Query Store With Params
        ///// </summary>
        ///// <param name="strNameStoreProcedure"></param>
        ///// <param name="arrParams"></param>
        ///// <returns></returns>
        //public static DataTable ExecuteQueryStoreProcedure(string strNameStoreProcedure, ArrayList arrParams)
        //{
        //    try
        //    {
        //        if (strNameStoreProcedure == null || strNameStoreProcedure == ""
        //            || arrParams.Count == 0 || arrParams == null)
        //        {
        //            return null;
        //        }

        //        DBManager.OpenConnection();
        //        SqlCommand objComm = new SqlCommand(strNameStoreProcedure, DBManager.objConn);
        //        objComm.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter objDataAdap;
        //        DataTable objTable = new DataTable();
        //        //Add Params
        //        foreach (SqlParameter param in arrParams)
        //        {
        //            //param.Value= HttpContext.Current.Server.HtmlEncode(param.Value.ToString());
        //            objComm.Parameters.Add(param);
        //        }
        //        objDataAdap = new SqlDataAdapter(objComm);
        //        objDataAdap.Fill(objTable);
        //        if (objTable.Rows.Count > 0)
        //        {
        //            return objTable;
        //        }
        //    }
        //    catch { }
        //    finally
        //    {
        //        DBManager.CloseConnection();
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// Execute Query Store Non Params
        ///// </summary>
        ///// <param name="strNameStoreProcedure"></param>
        ///// <returns></returns>
        //public static DataTable ExecuteQueryStoreProcedure(string strNameStoreProcedure)
        //{
        //    try
        //    {
        //        if (strNameStoreProcedure == null || strNameStoreProcedure == "")
        //        {
        //            return null;
        //        }

        //        DBManager.OpenConnection();
        //        SqlCommand objComm = new SqlCommand(strNameStoreProcedure, DBManager.objConn);
        //        objComm.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter objDataAdap;
        //        DataTable objTable = new DataTable();
        //        objDataAdap = new SqlDataAdapter(objComm);
        //        objDataAdap.Fill(objTable);

        //        if (objTable.Rows.Count > 0)
        //        {
        //            return objTable;
        //        }
        //    }
        //    catch { }
        //    finally
        //    {
        //        DBManager.CloseConnection();
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// Execute NonQuery Store With Params
        ///// </summary>
        ///// <param name="strNameStoreProcedure"></param>
        ///// <param name="arrParams"></param>
        ///// <returns></returns>
        //public static int ExecuteNonQueryStoreProcedure(string strNameStoreProcedure, ArrayList arrParams)
        //{
        //    try
        //    {
        //        if (strNameStoreProcedure == null || strNameStoreProcedure == ""
        //            || arrParams.Count == 0 || arrParams == null)
        //        {
        //            return 0;
        //        }

        //        DBManager.OpenConnection();
        //        SqlCommand objComm = new SqlCommand(strNameStoreProcedure, DBManager.objConn);
        //        objComm.CommandType = CommandType.StoredProcedure;
        //        int intNumRecoderAff = 0;
        //        foreach (SqlParameter param in arrParams)
        //        {
        //            //param.Value = HttpContext.Current.Server.HtmlEncode(param.Value.ToString());
        //            objComm.Parameters.Add(param);
        //        }
        //        intNumRecoderAff = objComm.ExecuteNonQuery();
        //        return intNumRecoderAff;
        //    }
        //    catch { }
        //    finally
        //    {
        //        DBManager.CloseConnection();
        //    }

        //    return 0;
        //}

        ///// <summary>
        ///// Execute NonQuery Store Non Params
        ///// </summary>
        ///// <param name="strNameStoreProcedure"></param>
        ///// <returns></returns>
        //public static int ExecuteNonQueryStoreProcedure(string strNameStoreProcedure)
        //{
        //    try
        //    {
        //        if (strNameStoreProcedure == null || strNameStoreProcedure == "")
        //        {
        //            return 0;
        //        }
        //        DBManager.OpenConnection();
        //        SqlCommand objComm = new SqlCommand(strNameStoreProcedure, DBManager.objConn);
        //        objComm.CommandType = CommandType.StoredProcedure;
        //        int intNumRecoderAff = 0;
        //        intNumRecoderAff = objComm.ExecuteNonQuery();
        //        return intNumRecoderAff;
        //    }
        //    catch { }
        //    finally
        //    {
        //        DBManager.CloseConnection();
        //    }
        //    return 0;
        //}


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="strNameStoreProcedure"></param>
        ///// <param name="arrParams"></param>
        ///// <param name="intDefault"></param>
        ///// <returns></returns>
        //public static int ExecuteScalarStoreProcedure(string strNameStoreProcedure, ArrayList arrParams, int intDefault)
        //{
        //    try
        //    {
        //        if (strNameStoreProcedure == null || strNameStoreProcedure == ""
        //            || arrParams.Count == 0 || arrParams == null)
        //        {
        //            return intDefault;
        //        }

        //        DBManager.OpenConnection();
        //        SqlCommand objComm = new SqlCommand(strNameStoreProcedure, DBManager.objConn);
        //        objComm.CommandType = CommandType.StoredProcedure;

        //        foreach (SqlParameter param in arrParams)
        //        {
        //            //param.Value = HttpContext.Current.Server.HtmlEncode(param.Value.ToString());
        //            objComm.Parameters.Add(param);
        //        }
        //        //add @return_value parameter
        //        objComm.Parameters.Add("return_value", SqlDbType.Int);
        //        objComm.Parameters["return_value"].Direction = ParameterDirection.ReturnValue;

        //        objComm.ExecuteNonQuery();
        //        int intReturn = (int)objComm.Parameters["return_value"].Value;
        //        return intReturn;
        //    }
        //    catch { }
        //    finally
        //    {
        //        DBManager.CloseConnection();
        //    }

        //    return intDefault;
        //}


        ///// <summary>
        ///// Execute Query SQL
        ///// </summary>
        ///// <param name="strSQL"></param>
        ///// <returns></returns>
        //public static DataTable ExecuteQuery(string strSQL)
        //{
        //    try
        //    {
        //        if (strSQL == null || strSQL == "")
        //        {
        //            return null;
        //        }

        //        DBManager.OpenConnection();
        //        DataTable objTable = new DataTable("ResultTable");
        //        SqlDataAdapter objDataAdap = new SqlDataAdapter(strSQL, DBManager.objConn);
        //        objDataAdap.Fill(objTable);

        //        if (objTable.Rows.Count > 0)
        //        {
        //            return objTable;
        //        }
        //    }
        //    catch { }
        //    finally
        //    {
        //        DBManager.CloseConnection();
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// Execute a query string or a store procedure
        ///// </summary>
        ///// <param name="sql">Query string or store procedure name</param>
        ///// <param name="commandType">Execute type: query string or store procedure</param>
        ///// <param name="pars">Parameters for store procedure</param>
        //public static void ExecuteNonQuery(
        //    string sql,
        //    CommandType commandType,
        //    params object[] pars)
        //{
        //    DBManager.OpenConnection();

        //    SqlCommand com = new SqlCommand(sql, DBManager.objConn);
        //    com.CommandType = commandType;

        //    for (int i = 0; i < pars.Length; i += 2)
        //    {
        //        SqlParameter par = new SqlParameter(pars[i].ToString(), pars[i + 1]);
        //        com.Parameters.Add(par);
        //    }

        //    com.ExecuteNonQuery();
        //    DBManager.CloseConnection();
        //}

        //public static bool ExecuteNonQuery(string strSQL)
        //{
        //    DBManager.OpenConnection();

        //    SqlCommand com = new SqlCommand(strSQL, DBManager.objConn);
        //    com.CommandType = CommandType.Text;
        //    int intI = 0;
        //    intI = com.ExecuteNonQuery();
        //    DBManager.CloseConnection();
        //    return intI > 0;
        //}
    }
}

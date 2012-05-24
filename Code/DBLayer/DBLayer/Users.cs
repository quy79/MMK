using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Users
	{

	#region Constructor
	public Users()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private string _FIRSTNAME;
	private string _LASTNAME;
	private string _USERNAME;
	private string _PASSWORD;
	private string _EMAIL;
	private string _PHONE;
	private string _COMPANYNAME;
	private System.DateTime _MODIFIEDDATE;
	Users  objclsUSERS;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public string FIRSTNAME
	{ 
		get { return _FIRSTNAME; }
		set { _FIRSTNAME = value; }
	}
	
     public string LASTNAME
	{ 
		get { return _LASTNAME; }
		set { _LASTNAME = value; }
	}
	
    public string USERNAME
	{ 
		get { return _USERNAME; }
		set { _USERNAME = value; }
	}
	public string PASSWORD
	{ 
		get { return _PASSWORD; }
		set { _PASSWORD = value; }
	}
	
	public string EMAIL
	{ 
		get { return _EMAIL; }
		set { _EMAIL = value; }
	}
	public string PHONE
	{ 
		get { return _PHONE; }
		set { _PHONE = value; }
	}

    public string COMPANYNAME
	{ 
		get { return _COMPANYNAME; }
        set { _COMPANYNAME = value; }
	}
	public System.DateTime MODIFIEDDATE
	{ 
		get { return _MODIFIEDDATE; }
		set { _MODIFIEDDATE = value; }
	}
	#endregion

	#region Public Methods
	public DataTable Select()
	{
		DataSet ds;
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@FIRSTNAME",SqlDbType.NVarChar),
				new SqlParameter("@LASTNAME",SqlDbType.NVarChar),
				new SqlParameter("@USERNAME",SqlDbType.NVarChar),
				new SqlParameter("@PASSWORD",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@PHONE",SqlDbType.NVarChar),
                new SqlParameter("@COMPANYNAME",SqlDbType.NVarChar)
			};
			

				if (ID != null && ID!= 0)
				{
					Params[0].Value = ID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (FIRSTNAME != null)
				{
					Params[1].Value = FIRSTNAME;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (LASTNAME != null)
				{
					Params[2].Value = LASTNAME;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (USERNAME != null)
				{
					Params[3].Value = USERNAME;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

				if (PASSWORD != null)
				{
					Params[4].Value = PASSWORD;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

				if (EMAIL != null)
				{
					Params[5].Value = EMAIL;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (PHONE != null)
				{
					Params[6].Value = PHONE;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				

				if (COMPANYNAME != null)
				{
                    Params[7].Value = COMPANYNAME;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

		
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_USERS_Select",Params);
			return ds.Tables[0];
		}
		catch(Exception ex)
		{
            return null;
			//throw new Exception(ex.Message);
		}
	}
	public bool Insert()
	{
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@FIRSTNAME",SqlDbType.NVarChar),
				new SqlParameter("@LASTNAME",SqlDbType.NVarChar),
				new SqlParameter("@USERNAME",SqlDbType.NVarChar),
				new SqlParameter("@PASSWORD",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@PHONE",SqlDbType.NVarChar),
                new SqlParameter("@COMPANYNAME",SqlDbType.NVarChar)
			};

            if (FIRSTNAME != null)
            {
                Params[0].Value = FIRSTNAME;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (LASTNAME != null)
            {
                Params[1].Value = LASTNAME;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }

            if (USERNAME != null)
            {
                Params[2].Value = USERNAME;
            }
            else
            {
                Params[2].Value = DBNull.Value;
            }

            if (PASSWORD != null)
            {
                Params[3].Value = PASSWORD;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }

            if (EMAIL != null)
            {
                Params[4].Value = EMAIL;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }

            if (PHONE != null)
            {
                Params[5].Value = PHONE;
            }
            else
            {
                Params[5].Value = DBNull.Value;
            }


            if (COMPANYNAME != null)
            {
                Params[6].Value = COMPANYNAME;
            }
            else
            {
                Params[6].Value = DBNull.Value;
            }
           

			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_USERS_Insert",Params);
			if (result > 0)
			{
				return true;
			}
			return false;
		}
		catch(Exception ex)
		{
            return false;
			//throw new Exception(ex.Message);
		}
	}
	public bool Update()
	{
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@ID",ID),
				new SqlParameter("@FIRSTNAME",SqlDbType.NVarChar),
				new SqlParameter("@LASTNAME",SqlDbType.NVarChar),
				new SqlParameter("@USERNAME",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@PHONE",SqlDbType.NVarChar),
                new SqlParameter("@COMPANYNAME",SqlDbType.NVarChar)
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_USERS_Update",Params);
			if (result > 0)
			{
				return true;
			}
			return false;
		}
		catch(Exception ex)
		{
			//throw new Exception(ex.Message);
            return false;
		}
	}
	public bool Delete()
	{
		try
		{
			SqlParameter[] Params = { new SqlParameter("@ID",ID) };
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_USERS_Delete",Params);
			if (result > 0)
			{
				return true;
			}
			return false;
		}
		catch(Exception ex)
		{
			//throw new Exception(ex.Message);
            return false;
		}
	}

    public bool IsExistUsername()
    {
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@USERNAME",USERNAME)
			};
            DataSet ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CHECK_EXISTUSERNAME", Params);
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            //throw new Exception(ex.Message);
            return false;
        }
    }


    public bool IsExistEmail()
    {
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@EMAIL",EMAIL)
			};
            DataSet ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CHECK_EXISTEMAIL", Params);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
           // throw new Exception(ex.Message);
            return false;
        }
    }

    public bool CheckUserPass()
    {
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@USERNAME",USERNAME)
			};
            DataSet ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CHECK_USERPASS", Params);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if((ds.Tables[0].Rows[0]["PASSWORD"].ToString().Equals(PASSWORD) ))  return true;
            }
            return false;
        }
        catch (Exception ex)
        {
           // throw new Exception(ex.Message);
        }

        return false;
    }
	#endregion

	}
}

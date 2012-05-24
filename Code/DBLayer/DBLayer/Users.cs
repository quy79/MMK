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
	private string _TITLE;
	private string _EMAIL;
	private string _PHONE;
	private string _CITY;
	private string _PROVINCE;
	private string _POSTCODE;
	private string _COUNTRY;
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
	public string TITLE
	{ 
		get { return _TITLE; }
		set { _TITLE = value; }
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
	public string CITY
	{ 
		get { return _CITY; }
		set { _CITY = value; }
	}
	public string PROVINCE
	{ 
		get { return _PROVINCE; }
		set { _PROVINCE = value; }
	}
	public string POSTCODE
	{ 
		get { return _POSTCODE; }
		set { _POSTCODE = value; }
	}
	public string COUNTRY
	{ 
		get { return _COUNTRY; }
		set { _COUNTRY = value; }
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
				new SqlParameter("@TITLE",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@PHONE",SqlDbType.NVarChar),
				new SqlParameter("@CITY",SqlDbType.NVarChar),
				new SqlParameter("@PROVINCE",SqlDbType.NVarChar),
				new SqlParameter("@POSTCODE",SqlDbType.NVarChar),
				new SqlParameter("@COUNTRY",SqlDbType.NVarChar),
				new SqlParameter("@MODIFIEDDATE",SqlDbType.DateTime) 
			};
			

				if (ID != null)
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

				if (TITLE != null)
				{
					Params[5].Value = TITLE;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (EMAIL != null)
				{
					Params[6].Value = EMAIL;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				if (PHONE != null)
				{
					Params[7].Value = PHONE;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

				if (CITY != null)
				{
					Params[8].Value = CITY;
				}
				else
				{
					Params[8].Value = DBNull.Value;
				}

				if (PROVINCE != null)
				{
					Params[9].Value = PROVINCE;
				}
				else
				{
					Params[9].Value = DBNull.Value;
				}

				if (POSTCODE != null)
				{
					Params[10].Value = POSTCODE;
				}
				else
				{
					Params[10].Value = DBNull.Value;
				}

				if (COUNTRY != null)
				{
					Params[11].Value = COUNTRY;
				}
				else
				{
					Params[11].Value = DBNull.Value;
				}

				if (MODIFIEDDATE != null)
				{
					Params[12].Value = MODIFIEDDATE;
				}
				else
				{
					Params[12].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_USERS_Select",Params);
			return ds.Tables[0];
		}
		catch(Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
	public bool Insert()
	{
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@FIRSTNAME",FIRSTNAME),
				new SqlParameter("@LASTNAME",LASTNAME),
				new SqlParameter("@USERNAME",USERNAME),
				new SqlParameter("@PASSWORD",PASSWORD),
				new SqlParameter("@TITLE",TITLE),
				new SqlParameter("@EMAIL",EMAIL),
				new SqlParameter("@PHONE",PHONE),
				new SqlParameter("@CITY",CITY),
				new SqlParameter("@PROVINCE",PROVINCE),
				new SqlParameter("@POSTCODE",POSTCODE),
				new SqlParameter("@COUNTRY",COUNTRY),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_USERS_Insert",Params);
			if (result > 0)
			{
				return true;
			}
			return false;
		}
		catch(Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
	public bool Update()
	{
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@ID",ID),
				new SqlParameter("@FIRSTNAME",FIRSTNAME),
				new SqlParameter("@LASTNAME",LASTNAME),
				new SqlParameter("@USERNAME",USERNAME),
				new SqlParameter("@PASSWORD",PASSWORD),
				new SqlParameter("@TITLE",TITLE),
				new SqlParameter("@EMAIL",EMAIL),
				new SqlParameter("@PHONE",PHONE),
				new SqlParameter("@CITY",CITY),
				new SqlParameter("@PROVINCE",PROVINCE),
				new SqlParameter("@POSTCODE",POSTCODE),
				new SqlParameter("@COUNTRY",COUNTRY),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
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
			throw new Exception(ex.Message);
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
			throw new Exception(ex.Message);
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
            throw new Exception(ex.Message);
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
            throw new Exception(ex.Message);
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

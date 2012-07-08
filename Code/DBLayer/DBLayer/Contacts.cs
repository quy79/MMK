using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Contacts
	{

	#region Constructor
	public Contacts()
	{}
	#endregion

	#region Private Variables
	private int _ID;
    private int _USERID;
	private string _FIRSTNAME;
	private string _LASTNAME;
	private string _PREFIX;
	private string _SUFFIX;
	private string _EMAIL;
	private string _ADDRESS1;
	private string _ADDRESS2;
	private string _CITY;
	private string _PROVINCE;
	private string _ZIP;
    private string _BUSINESSNAME;
	private string _PHONE;
	private string _FAX;
	private bool _REQUIRECONFIRM;
    private bool _SENDEMAIL;
    private string _CONFIRMCODE;
	private System.DateTime _MODIFIEDDATE;
	 Contacts  objclsCONTACTS;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
    public int USERID
    {
        get { return _USERID; }
        set { _USERID = value; }
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
	public string PREFIX
	{ 
		get { return _PREFIX; }
		set { _PREFIX = value; }
	}
	public string SUFFIX
	{ 
		get { return _SUFFIX; }
		set { _SUFFIX = value; }
	}
	public string EMAIL
	{ 
		get { return _EMAIL; }
		set { _EMAIL = value; }
	}
	public string ADDRESS1
	{ 
		get { return _ADDRESS1; }
		set { _ADDRESS1 = value; }
	}
	public string ADDRESS2
	{ 
		get { return _ADDRESS2; }
		set { _ADDRESS2 = value; }
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
	public string ZIP
	{ 
		get { return _ZIP; }
		set { _ZIP = value; }
	}

    public string BUSINESSNAME
	{
        get { return _BUSINESSNAME; }
        set { _BUSINESSNAME = value; }
	}

	public string PHONE
	{ 
		get { return _PHONE; }
		set { _PHONE = value; }
	}
	public string FAX
	{ 
		get { return _FAX; }
		set { _FAX = value; }
	}
	public bool CONFIRMED
	{ 
		get { return _REQUIRECONFIRM; }
		set { _REQUIRECONFIRM = value; }
	}

	

    public bool SENDEMAIL
    {
        get { return _SENDEMAIL; }
        set { _SENDEMAIL = value; }
    }

    public string CONFIRMCODE
    {
        get { return _CONFIRMCODE; }
        set { _CONFIRMCODE = value; }
    }

    public System.DateTime MODIFIEDDATE
    {
        get { return _MODIFIEDDATE; }
        set { _MODIFIEDDATE = value; }
    }
	#endregion

	#region Public Methods
    public DataTable ExecuteSql(string sql)
    {
        DataSet ds;
        try
        {


            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.Text, sql );
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
    public DataTable SelectSummartContacts()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@USERID",USERID )				
			};








            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "[SP_SUMMARYCONTACT_INFO]", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
    public DataTable QuickSearch(string text, bool subscribed)
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@Text",SqlDbType.NVarChar),
                new SqlParameter("@USERID",SqlDbType.Int),
                new SqlParameter("@SUBSCRIBES",SqlDbType.Bit),
			};

            Params[0].Value = text;
            Params[1].Value = USERID;
            Params[2].Value = subscribed;

            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "[SP_CONTACTS_QSearch]", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }

    public DataTable SelectContactListsbyListIDs(int listIDs, bool subcribes)
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@ListIDs",SqlDbType.Int)		,		
                new SqlParameter("@SUBSCRIBES",SqlDbType.Bit)				
			};

            Params[0].Value = listIDs;
            Params[1].Value = subcribes;

            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "[SP_CONTACTS_SelectContactListsbyListIDs]", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }

    public DataTable GetListNamesForCountactID(int contactID)
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 
				new SqlParameter("@CONTACTID",contactID)
            };


            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_GETLISTNAMESOFCONTACTS", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }

    public DataTable SelectAll()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 
				new SqlParameter("@USERID",USERID)
            };

            
            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CONTACTS_SelectAll", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
    public DataTable SelectContactsFromContactID()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@ID",ID )				
			};








            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "[SP_CONTACTS_SelectByContactID]", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
    public DataTable SelectContactFromEmail()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@USERID",SqlDbType.Int)
			};


           

            if (EMAIL != null)
            {
                Params[0].Value = EMAIL;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (USERID != null)
            {
                Params[1].Value = USERID;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }
            


            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CONTACTS_SelectByEmail", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
	public DataTable Select(DateTime date1, DateTime date2)
	{
		DataSet ds;
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@FIRSTNAME",SqlDbType.NVarChar),
				new SqlParameter("@LASTNAME",SqlDbType.NVarChar),
				new SqlParameter("@PREFIX",SqlDbType.NVarChar),
				new SqlParameter("@SUFFIX",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@ADDRESS1",SqlDbType.NVarChar),
				new SqlParameter("@ADDRESS2",SqlDbType.NVarChar),
				new SqlParameter("@CITY",SqlDbType.NVarChar),
				new SqlParameter("@PROVINCE",SqlDbType.NVarChar),
				new SqlParameter("@ZIP",SqlDbType.NVarChar),
                new SqlParameter("@BUSINESSNAME",SqlDbType.NVarChar),
				new SqlParameter("@PHONE",SqlDbType.NVarChar),
				new SqlParameter("@FAX",SqlDbType.NVarChar),				
				new SqlParameter("@DATE1",SqlDbType.DateTime) ,
                new SqlParameter("@DATE2",SqlDbType.DateTime) ,
                new SqlParameter("@USERID",SqlDbType.Int) 
			};
			

				if (FIRSTNAME != null )
				{
					Params[0].Value = FIRSTNAME;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

                if (LASTNAME != null )
				{
					Params[1].Value = LASTNAME;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

                if (PREFIX != null )
				{
					Params[2].Value = PREFIX;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

                if (SUFFIX != null)
				{
					Params[3].Value = SUFFIX;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

                if (EMAIL != null )
				{
					Params[4].Value = EMAIL;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

                if (ADDRESS1 != null)
				{
					Params[5].Value = ADDRESS1;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

                if (ADDRESS2 != null )
				{
					Params[6].Value = ADDRESS2;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

                if (CITY != null )
				{
					Params[7].Value = CITY;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

                if (PROVINCE != null)
				{
					Params[8].Value = PROVINCE;
				}
				else
				{
					Params[8].Value = DBNull.Value;
				}

                if (ZIP != null )
				{
					Params[9].Value = ZIP;
				}
				else
				{
					Params[9].Value = DBNull.Value;
				}

                if (BUSINESSNAME != null )
                {
                    Params[10].Value = BUSINESSNAME;
                }
                else
                {
                    Params[10].Value = DBNull.Value;
                }

                if (PHONE != null )
				{
					Params[11].Value = PHONE;
				}
				else
				{
					Params[11].Value = DBNull.Value;
				}

                if (FAX != null)
				{
					Params[12].Value = FAX;
				}
				else
				{
					Params[12].Value = DBNull.Value;
				}

        


                Params[13].Value = date1;
                Params[14].Value = date2;

                if (USERID != null)
                {
                    Params[15].Value = USERID;
                }
                else
                {
                    Params[15].Value = DBNull.Value;
                }

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Select",Params);
			return ds.Tables[0];
		}
		catch(Exception ex)
		{
            return null;// throw new Exception(ex.Message);
		}
	}
	public int Insert()
	{
		try
		{
			SqlParameter[] Params = 
			{ 
                new SqlParameter("@USERID",USERID),
				new SqlParameter("@FIRSTNAME",FIRSTNAME),
				new SqlParameter("@LASTNAME",LASTNAME),
				new SqlParameter("@PREFIX",PREFIX),
				new SqlParameter("@SUFFIX",SUFFIX),

				new SqlParameter("@EMAIL",EMAIL),

				new SqlParameter("@ADDRESS1",ADDRESS1),
				new SqlParameter("@ADDRESS2",ADDRESS2),

				new SqlParameter("@CITY",CITY),
				new SqlParameter("@PROVINCE",PROVINCE),
				new SqlParameter("@ZIP",ZIP),

                new SqlParameter("@BUSINESSNAME",BUSINESSNAME),
				new SqlParameter("@PHONE",PHONE),
				new SqlParameter("@FAX",FAX),

				new SqlParameter("@REQUIRECONFIRM",CONFIRMED),
                new SqlParameter("@SENDEMAIL",SENDEMAIL),
                new SqlParameter("@CONFIRMCODE",CONFIRMCODE) 
			};
            DataSet ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CONTACTS_Insert", Params);
			//if (result > 0)
			//{
				//return true;
			//}
			//return false;
            if (ds.Tables.Count > 0) return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            return -1;
		}
		catch(Exception ex)
		{
            return -1;
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
				new SqlParameter("@FIRSTNAME",FIRSTNAME),
				new SqlParameter("@LASTNAME",LASTNAME),
				new SqlParameter("@PREFIX",PREFIX),
				new SqlParameter("@SUFFIX",SUFFIX),
				new SqlParameter("@EMAIL",EMAIL),
				new SqlParameter("@ADDRESS1",ADDRESS1),
				new SqlParameter("@ADDRESS2",ADDRESS2),
				new SqlParameter("@CITY",CITY),
				new SqlParameter("@PROVINCE",PROVINCE),
				new SqlParameter("@ZIP",ZIP),
				new SqlParameter("@PHONE",PHONE),
				new SqlParameter("@FAX",FAX),
				new SqlParameter("@REQUIRECONFIRM",CONFIRMED),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Update",Params);
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

   public int IsExistContactEmail()
    {
        try
        {
            SqlParameter[] Params = 
			{ 				
				new SqlParameter("@EMAIL",EMAIL),
                new SqlParameter("@USERID",USERID)
			};
            DataSet ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "[SP_CHECK_ExistContactEmail]", Params);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                
            }
            return 0;
        }
        catch (Exception ex)
        {
            // throw new Exception(ex.Message);
            return -1;
        }
    }


	public bool Delete()
	{
		try
		{
			SqlParameter[] Params = { new SqlParameter("@ID",ID) };
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Delete",Params);
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
	#endregion

	}
}

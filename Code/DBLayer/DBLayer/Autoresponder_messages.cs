using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Autoresponder_messages
	{

	#region Constructor
	public Autoresponder_messages()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _AUTORESPONDERID;
	private int _MESSAGEID;
    private int _STATUS;
    private DateTime _ENDDATE;
    private int _DURATION;

	 Autoresponder_messages  objclsAUTORESPONDER_MESSAGES;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public int AUTORESPONDERID
	{ 
		get { return _AUTORESPONDERID; }
		set { _AUTORESPONDERID = value; }
	}
	public int MESSAGEID
	{ 
		get { return _MESSAGEID; }
		set { _MESSAGEID = value; }
	}
   
    public int STATUS
    {
        get { return _STATUS; }
        set { _STATUS = value; }
    }
    
    public System.DateTime ENDDATE
    {
        get { return _ENDDATE; }
        set { _ENDDATE = value; }
    }
    public int DURATION
    {
        get { return _DURATION; }
        set { _DURATION = value; }
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
				new SqlParameter("@AUTORESPONDERID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
                new SqlParameter("@STATUS",SqlDbType.Int) ,
				new SqlParameter("@ENDDATE",SqlDbType.DateTime) ,
                new SqlParameter("@DURATION",SqlDbType.Int)
			};
			

				if (ID != 0)
				{
					Params[0].Value = ID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (AUTORESPONDERID != 0)
				{
					Params[1].Value = AUTORESPONDERID;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (MESSAGEID != 0)
				{
					Params[2].Value = MESSAGEID;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}
               
                if (STATUS != 0)
                {
                    Params[3].Value = STATUS;
                }
                else
                {
                    Params[3].Value = DBNull.Value;
                }

                if (ENDDATE != null)
                {
                    Params[4].Value = ENDDATE;
                }
                else
                {
                    Params[4].Value = DBNull.Value;
                }

                if (DURATION != 0)
                {
                    Params[5].Value = DURATION;
                }
                else
                {
                    Params[5].Value = DBNull.Value;
                }

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_MESSAGES_Select",Params);
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
				new SqlParameter("@AUTORESPONDERID",AUTORESPONDERID),
				new SqlParameter("@MESSAGEID",MESSAGEID) ,
                new SqlParameter("@STATUS",STATUS) ,
                new SqlParameter("@ENDDATE",SqlDbType.DateTime) ,
                new SqlParameter("@DURATION",SqlDbType.Int)
			};
           
           

            if (AUTORESPONDERID != 0)
            {
                Params[0].Value = AUTORESPONDERID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (MESSAGEID != 0)
            {
                Params[1].Value = MESSAGEID;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }

            if (STATUS != 0)
            {
                Params[2].Value = STATUS;
            }
            else
            {
                Params[2].Value = DBNull.Value;
            }

            if (ENDDATE != null)
            {
                Params[3].Value = ENDDATE;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }

            if (DURATION != 0)
            {
                Params[4].Value = DURATION;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_MESSAGES_Insert",Params);
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
				new SqlParameter("@AUTORESPONDERID",AUTORESPONDERID),
				new SqlParameter("@MESSAGEID",MESSAGEID) ,
                new SqlParameter("@STATUS",STATUS) ,
                new SqlParameter("@ENDDATE",SqlDbType.DateTime) ,
                new SqlParameter("@DURATION",SqlDbType.Int)
			};
            if (ID != 0)
            {
                Params[0].Value = ID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (AUTORESPONDERID != 0)
            {
                Params[1].Value = AUTORESPONDERID;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }

            if (MESSAGEID != 0)
            {
                Params[2].Value = MESSAGEID;
            }
            else
            {
                Params[2].Value = DBNull.Value;
            }

            if (STATUS != 0)
            {
                Params[3].Value = STATUS;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }

            if (ENDDATE != null)
            {
                Params[4].Value = ENDDATE;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }

            if (DURATION != 0)
            {
                Params[5].Value = DURATION;
            }
            else
            {
                Params[5].Value = DBNull.Value;
            }
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_MESSAGES_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_MESSAGES_Delete",Params);
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

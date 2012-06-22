using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class AutoresponderPending
	{

	#region Constructor
        public AutoresponderPending()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _AUTOID;
	private int  _CONTACTID;
    private int _MESSAGEID;
	private String _EMAIL;
	private int _STATUS;


	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public int AUTOID
	{
        get { return _AUTOID; }
        set { _AUTOID = value; }
	}
	public string EMAIL
	{
        get { return _EMAIL; }
        set { _EMAIL = value; }
	}
    public int CONTACTID
	{
        get { return _CONTACTID; }
        set { _CONTACTID = value; }
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
				new SqlParameter("@AUTOID",SqlDbType.Int),
				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@STATUS",SqlDbType.Int)
				 
			};
			

				if (ID != 0)
				{
					Params[0].Value = ID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (AUTOID != 0)
				{
					Params[1].Value = AUTOID;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (CONTACTID != 0)
				{
					Params[2].Value = CONTACTID;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (MESSAGEID != 0)
				{
                    Params[3].Value = MESSAGEID;
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

				

				

				if (STATUS != null)
				{
					Params[5].Value = STATUS;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}



                ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_PENDING_Select", Params);
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
				//new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@AUTOID",SqlDbType.Int),
				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@STATUS",SqlDbType.Int)
			};
           

            if (AUTOID != 0)
            {
                Params[0].Value = AUTOID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (CONTACTID != 0)
            {
                Params[1].Value = CONTACTID;
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

            if (EMAIL != null)
            {
                Params[3].Value = EMAIL;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }





            if (STATUS != null)
            {
                Params[4].Value = STATUS;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }

            int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_PENDING_Insert", Params);
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
				//new SqlParameter("@ID",ID),
				//new SqlParameter("@USERID",USERID),
				//new SqlParameter("@NAME",NAME),
				//new SqlParameter("@DESCRIPTION",DESCRIPTION),
				//new SqlParameter("@LISTID",LISTID),
				//new SqlParameter("@FROMNAME",FROMNAME),
				//new SqlParameter("@FROMEMAIL",FROMEMAIL),
				//new SqlParameter("@STATUS",STATUS),
				//new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_Delete",Params);
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

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
				new SqlParameter("@MESSAGEID",SqlDbType.Int) 
			};
			

				if (ID != null)
				{
					Params[0].Value = ID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (AUTORESPONDERID != null)
				{
					Params[1].Value = AUTORESPONDERID;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (MESSAGEID != null)
				{
					Params[2].Value = MESSAGEID;
				}
				else
				{
					Params[2].Value = DBNull.Value;
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
				new SqlParameter("@MESSAGEID",MESSAGEID) 
			};
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
				new SqlParameter("@MESSAGEID",MESSAGEID) 
			};
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

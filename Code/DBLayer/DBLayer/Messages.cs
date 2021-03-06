using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Messages
	{

	#region Constructor
	public Messages()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private string _MESSAGENAME;
	private string _FROM;
	private string _SUBJECT;
	private string _BODY;
	private string _WEBPAGE;
	private bool _TYPE;
	private int _STATUS;
	private System.DateTime _MODIFIEDDATE;
	 Messages  objclsMESSAGES;
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
	public string MESSAGENAME
	{ 
		get { return _MESSAGENAME; }
		set { _MESSAGENAME = value; }
	}
	public string FROM
	{ 
		get { return _FROM; }
		set { _FROM = value; }
	}
	public string SUBJECT
	{ 
		get { return _SUBJECT; }
		set { _SUBJECT = value; }
	}
	public string BODY
	{ 
		get { return _BODY; }
		set { _BODY = value; }
	}
	public string WEBPAGE
	{ 
		get { return _WEBPAGE; }
		set { _WEBPAGE = value; }
	}
	public bool TYPE
	{ 
		get { return _TYPE; }
		set { _TYPE = value; }
	}
	public int STATUS
	{ 
		get { return _STATUS; }
		set { _STATUS = value; }
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
				new SqlParameter("@USERID",SqlDbType.Int),
				new SqlParameter("@MESSAGENAME",SqlDbType.NVarChar),
				new SqlParameter("@FROM",SqlDbType.NVarChar),
				new SqlParameter("@SUBJECT",SqlDbType.NVarChar),
				new SqlParameter("@BODY",SqlDbType.Text),
				new SqlParameter("@WEBPAGE",SqlDbType.NVarChar),
				new SqlParameter("@TYPE",SqlDbType.Bit),
				new SqlParameter("@STATUS",SqlDbType.Int),
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

				if (USERID != null)
				{
					Params[1].Value = USERID;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (MESSAGENAME != null)
				{
					Params[2].Value = MESSAGENAME;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (FROM != null)
				{
					Params[3].Value = FROM;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

				if (SUBJECT != null)
				{
					Params[4].Value = SUBJECT;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

				if (BODY != null)
				{
					Params[5].Value = BODY;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (WEBPAGE != null)
				{
					Params[6].Value = WEBPAGE;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				if (TYPE != null)
				{
					Params[7].Value = TYPE;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

				if (STATUS != null)
				{
					Params[8].Value = STATUS;
				}
				else
				{
					Params[8].Value = DBNull.Value;
				}

				if (MODIFIEDDATE != null)
				{
					Params[9].Value = MODIFIEDDATE;
				}
				else
				{
					Params[9].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_MESSAGES_Select",Params);
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
				new SqlParameter("@USERID",USERID),
				new SqlParameter("@MESSAGENAME",MESSAGENAME),
				new SqlParameter("@FROM",FROM),
				new SqlParameter("@SUBJECT",SUBJECT),
				new SqlParameter("@BODY",BODY),
				new SqlParameter("@WEBPAGE",WEBPAGE),
				new SqlParameter("@TYPE",TYPE),
				new SqlParameter("@STATUS",STATUS),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_MESSAGES_Insert",Params);
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
				new SqlParameter("@USERID",USERID),
				new SqlParameter("@MESSAGENAME",MESSAGENAME),
				new SqlParameter("@FROM",FROM),
				new SqlParameter("@SUBJECT",SUBJECT),
				new SqlParameter("@BODY",BODY),
				new SqlParameter("@WEBPAGE",WEBPAGE),
				new SqlParameter("@TYPE",TYPE),
				new SqlParameter("@STATUS",STATUS),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_MESSAGES_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_MESSAGES_Delete",Params);
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

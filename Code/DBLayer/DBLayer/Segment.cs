using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Segment
	{

	#region Constructor
	public Segment()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private int _LISTID;
	private string _NAME;
	private string _DESCRIPTION;
	private int _TOTALSUBSCRIBES;
	private System.DateTime _MODIFIEDDATE;
	 Segment  objclsSEGMENT;
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
	public int LISTID
	{ 
		get { return _LISTID; }
		set { _LISTID = value; }
	}
	public string NAME
	{ 
		get { return _NAME; }
		set { _NAME = value; }
	}
	public string DESCRIPTION
	{ 
		get { return _DESCRIPTION; }
		set { _DESCRIPTION = value; }
	}
	public int TOTALSUBSCRIBES
	{ 
		get { return _TOTALSUBSCRIBES; }
		set { _TOTALSUBSCRIBES = value; }
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
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@NAME",SqlDbType.NVarChar),
				new SqlParameter("@DESCRIPTION",SqlDbType.NVarChar),
				new SqlParameter("@TOTALSUBSCRIBES",SqlDbType.Int),
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

				if (LISTID != null)
				{
					Params[2].Value = LISTID;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (NAME != null)
				{
					Params[3].Value = NAME;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

				if (DESCRIPTION != null)
				{
					Params[4].Value = DESCRIPTION;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

				if (TOTALSUBSCRIBES != null)
				{
					Params[5].Value = TOTALSUBSCRIBES;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (MODIFIEDDATE != null)
				{
					Params[6].Value = MODIFIEDDATE;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_Select",Params);
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
				new SqlParameter("@LISTID",LISTID),
				new SqlParameter("@NAME",NAME),
				new SqlParameter("@DESCRIPTION",DESCRIPTION),
				new SqlParameter("@TOTALSUBSCRIBES",TOTALSUBSCRIBES),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_Insert",Params);
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
				new SqlParameter("@LISTID",LISTID),
				new SqlParameter("@NAME",NAME),
				new SqlParameter("@DESCRIPTION",DESCRIPTION),
				new SqlParameter("@TOTALSUBSCRIBES",TOTALSUBSCRIBES),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_Delete",Params);
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Lists
	{

	#region Constructor
	public Lists()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private string _LISTNAME;
	private string _DESCRIPTION;
	private bool _NOTIFICATION;
	private string _PUBLICLABEL;
	private int _WELLCOMEMSGID;
	private int _TOTALSUBSCRIBES;
	private System.DateTime _MODIFIEDDATE;
	 Lists  objclsLISTS;
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
	public string LISTNAME
	{ 
		get { return _LISTNAME; }
		set { _LISTNAME = value; }
	}
	public string DESCRIPTION
	{ 
		get { return _DESCRIPTION; }
		set { _DESCRIPTION = value; }
	}
	public bool NOTIFICATION
	{ 
		get { return _NOTIFICATION; }
		set { _NOTIFICATION = value; }
	}
	public string PUBLICLABEL
	{ 
		get { return _PUBLICLABEL; }
		set { _PUBLICLABEL = value; }
	}
	public int WELLCOMEMSGID
	{ 
		get { return _WELLCOMEMSGID; }
		set { _WELLCOMEMSGID = value; }
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
				new SqlParameter("@LISTNAME",SqlDbType.NVarChar),
				new SqlParameter("@DESCRIPTION",SqlDbType.NVarChar),
				new SqlParameter("@NOTIFICATION",SqlDbType.Bit),
				new SqlParameter("@PUBLICLABEL",SqlDbType.NVarChar),
				new SqlParameter("@WELLCOMEMSGID",SqlDbType.Int),
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

				if (LISTNAME != null)
				{
					Params[2].Value = LISTNAME;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (DESCRIPTION != null)
				{
					Params[3].Value = DESCRIPTION;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

				if (NOTIFICATION != null)
				{
					Params[4].Value = NOTIFICATION;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

				if (PUBLICLABEL != null)
				{
					Params[5].Value = PUBLICLABEL;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (WELLCOMEMSGID != null)
				{
					Params[6].Value = WELLCOMEMSGID;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				if (TOTALSUBSCRIBES != null)
				{
					Params[7].Value = TOTALSUBSCRIBES;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

				if (MODIFIEDDATE != null)
				{
					Params[8].Value = MODIFIEDDATE;
				}
				else
				{
					Params[8].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_LISTS_Select",Params);
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
				new SqlParameter("@LISTNAME",LISTNAME),
				new SqlParameter("@DESCRIPTION",DESCRIPTION),
				new SqlParameter("@NOTIFICATION",NOTIFICATION),
				new SqlParameter("@PUBLICLABEL",PUBLICLABEL),
				new SqlParameter("@WELLCOMEMSGID",WELLCOMEMSGID),
				new SqlParameter("@TOTALSUBSCRIBES",TOTALSUBSCRIBES),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_LISTS_Insert",Params);
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
				new SqlParameter("@LISTNAME",LISTNAME),
				new SqlParameter("@DESCRIPTION",DESCRIPTION),
				new SqlParameter("@NOTIFICATION",NOTIFICATION),
				new SqlParameter("@PUBLICLABEL",PUBLICLABEL),
				new SqlParameter("@WELLCOMEMSGID",WELLCOMEMSGID),
				new SqlParameter("@TOTALSUBSCRIBES",TOTALSUBSCRIBES),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_LISTS_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_LISTS_Delete",Params);
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

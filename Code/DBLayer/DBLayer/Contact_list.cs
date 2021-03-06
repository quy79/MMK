using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Contact_list
	{

	#region Constructor
	public Contact_list()
	{}
	#endregion

	#region Private Variables
	private int _CONTACTID;
	private int _LISTID;
	private bool _SUBSCRIBES;
	 Contact_list  objclsCONTACT_LIST;
	#endregion

	#region Public Properties
	public int CONTACTID
	{ 
		get { return _CONTACTID; }
		set { _CONTACTID = value; }
	}
	public int LISTID
	{ 
		get { return _LISTID; }
		set { _LISTID = value; }
	}
	public bool SUBSCRIBES
	{ 
		get { return _SUBSCRIBES; }
		set { _SUBSCRIBES = value; }
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
				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@SUBSCRIBES",SqlDbType.Bit) 
			};
			

				if (CONTACTID != null)
				{
					Params[0].Value = CONTACTID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (LISTID != null)
				{
					Params[1].Value = LISTID;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (SUBSCRIBES != null)
				{
					Params[2].Value = SUBSCRIBES;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACT_LIST_Select",Params);
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
				new SqlParameter("@LISTID",LISTID),
				new SqlParameter("@SUBSCRIBES",SUBSCRIBES) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACT_LIST_Insert",Params);
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
				new SqlParameter("@CONTACTID",CONTACTID),
				new SqlParameter("@LISTID",LISTID),
				new SqlParameter("@SUBSCRIBES",SUBSCRIBES) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACT_LIST_Update",Params);
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
			SqlParameter[] Params = { new SqlParameter("@CONTACTID",CONTACTID) };
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACT_LIST_Delete",Params);
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

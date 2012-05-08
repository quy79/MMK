using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Segment_contact
	{

	#region Constructor
	public Segment_contact()
	{}
	#endregion

	#region Private Variables
	private int _SEGMENTID;
	private int _CONTACTID;
	private bool _SUBSCRIBES;
	 Segment_contact  objclsSEGMENT_CONTACT;
	#endregion

	#region Public Properties
	public int SEGMENTID
	{ 
		get { return _SEGMENTID; }
		set { _SEGMENTID = value; }
	}
	public int CONTACTID
	{ 
		get { return _CONTACTID; }
		set { _CONTACTID = value; }
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
				new SqlParameter("@SEGMENTID",SqlDbType.Int),
				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@SUBSCRIBES",SqlDbType.Bit) 
			};
			

				if (SEGMENTID != null)
				{
					Params[0].Value = SEGMENTID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (CONTACTID != null)
				{
					Params[1].Value = CONTACTID;
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

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CONTACT_Select",Params);
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
				new SqlParameter("@CONTACTID",CONTACTID),
				new SqlParameter("@SUBSCRIBES",SUBSCRIBES) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CONTACT_Insert",Params);
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
				new SqlParameter("@SEGMENTID",SEGMENTID),
				new SqlParameter("@CONTACTID",CONTACTID),
				new SqlParameter("@SUBSCRIBES",SUBSCRIBES) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CONTACT_Update",Params);
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
			SqlParameter[] Params = { new SqlParameter("@SEGMENTID",SEGMENTID) };
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CONTACT_Delete",Params);
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

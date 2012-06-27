using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class SegmentCriterias
	{

	#region Constructor
	public SegmentCriterias()
	{}
	#endregion

	#region Private Variables
    private int _ID;
	private int _SEGMENTID;
    private string _CRITERION;
	private string _CONDITIONNAME;
	private string _CONDITION;
	private string _VALUE;
	SegmentCriterias  objclsSEGMENT_CRITERIAS;
	#endregion

	#region Public Properties
    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
	public int SEGMENTID
	{ 
		get { return _SEGMENTID; }
		set { _SEGMENTID = value; }
	}
    public string CRITERION
    {
        get { return _CRITERION; }
        set { _CRITERION = value; }
    }
	public string CONDITIONNAME
	{ 
		get { return _CONDITIONNAME; }
		set { _CONDITIONNAME = value; }
	}
	public string CONDITION
	{ 
		get { return _CONDITION; }
		set { _CONDITION = value; }
	}
	public string VALUE
	{ 
		get { return _VALUE; }
		set { _VALUE = value; }
	}
	#endregion

	#region Public Methods
    public DataTable SelectBySegmentID()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 
				new SqlParameter("@SEGMENTID",SqlDbType.Int)
			};
            
            Params[0].Value = SEGMENTID;

            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_SEGMENT_CRITERIAS_SelectBySegmentID", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;//throw new Exception(ex.Message);
        }
    }
   
	public DataTable Select()
	{
		DataSet ds;
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@SEGMENTID",SqlDbType.Int),
				new SqlParameter("@CONDITIONNAME",SqlDbType.NVarChar),
				new SqlParameter("@CONDITION",SqlDbType.NChar),
				new SqlParameter("@VALUE",SqlDbType.NChar) 
			};
			

				if (SEGMENTID != null)
				{
					Params[0].Value = SEGMENTID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (CONDITIONNAME != null)
				{
					Params[1].Value = CONDITIONNAME;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (CONDITION != null)
				{
					Params[2].Value = CONDITION;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (VALUE != null)
				{
					Params[3].Value = VALUE;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CRITERIAS_Select",Params);
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
                new SqlParameter("@SEGMENTID",SEGMENTID),
                new SqlParameter("@CRITERION",CRITERION),
				new SqlParameter("@CONDITIONNAME",CONDITIONNAME),
				new SqlParameter("@CONDITION",CONDITION),
				new SqlParameter("@VALUE",VALUE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CRITERIAS_Insert",Params);
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
				new SqlParameter("@CONDITIONNAME",CONDITIONNAME),
				new SqlParameter("@CONDITION",CONDITION),
				new SqlParameter("@VALUE",VALUE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CRITERIAS_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SEGMENT_CRITERIAS_Delete",Params);
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

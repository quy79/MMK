using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Sentemails
	{

	#region Constructor
	public Sentemails()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _AUTORESPONSEID;
	private int _MESSAGEID;
	private int _CONTACTID;
	private bool _OPEN;
	private bool _CLICK;
	private bool _BOUNCES;
	private bool _NOINFO;
	private bool _UNSUBSCRIBES;
	private bool _COMPLAINS_;
	private bool _FORWARDS_;
	private bool _STATUS;
	private string _DESC;
	private System.DateTime _DATESENT;
	 Sentemails  objclsSENTEMAILS;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public int AUTORESPONSEID
	{ 
		get { return _AUTORESPONSEID; }
		set { _AUTORESPONSEID = value; }
	}
	public int MESSAGEID
	{ 
		get { return _MESSAGEID; }
		set { _MESSAGEID = value; }
	}
	public int CONTACTID
	{ 
		get { return _CONTACTID; }
		set { _CONTACTID = value; }
	}
	public bool OPEN
	{ 
		get { return _OPEN; }
		set { _OPEN = value; }
	}
	public bool CLICK
	{ 
		get { return _CLICK; }
		set { _CLICK = value; }
	}
	public bool BOUNCES
	{ 
		get { return _BOUNCES; }
		set { _BOUNCES = value; }
	}
	public bool NOINFO
	{ 
		get { return _NOINFO; }
		set { _NOINFO = value; }
	}
	public bool UNSUBSCRIBES
	{ 
		get { return _UNSUBSCRIBES; }
		set { _UNSUBSCRIBES = value; }
	}
	public bool COMPLAINS_
	{ 
		get { return _COMPLAINS_; }
		set { _COMPLAINS_ = value; }
	}
	public bool FORWARDS_
	{ 
		get { return _FORWARDS_; }
		set { _FORWARDS_ = value; }
	}
	public bool STATUS
	{ 
		get { return _STATUS; }
		set { _STATUS = value; }
	}
	public string DESC
	{ 
		get { return _DESC; }
		set { _DESC = value; }
	}
	public System.DateTime DATESENT
	{ 
		get { return _DATESENT; }
		set { _DATESENT = value; }
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
				new SqlParameter("@AUTORESPONSEID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@OPEN",SqlDbType.Bit),
				new SqlParameter("@CLICK",SqlDbType.Bit),
				new SqlParameter("@BOUNCES",SqlDbType.Bit),
				new SqlParameter("@NOINFO",SqlDbType.Bit),
				new SqlParameter("@UNSUBSCRIBES",SqlDbType.Bit),
				new SqlParameter("@COMPLAINS_",SqlDbType.Bit),
				new SqlParameter("@FORWARDS_",SqlDbType.Bit),
				new SqlParameter("@STATUS",SqlDbType.Bit),
				new SqlParameter("@DESC",SqlDbType.NVarChar),
				new SqlParameter("@DATESENT",SqlDbType.DateTime) 
			};
			

				if (ID != null)
				{
					Params[0].Value = ID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (AUTORESPONSEID != null)
				{
					Params[1].Value = AUTORESPONSEID;
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

				if (CONTACTID != null)
				{
					Params[3].Value = CONTACTID;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

				if (OPEN != null)
				{
					Params[4].Value = OPEN;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

				if (CLICK != null)
				{
					Params[5].Value = CLICK;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (BOUNCES != null)
				{
					Params[6].Value = BOUNCES;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				if (NOINFO != null)
				{
					Params[7].Value = NOINFO;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

				if (UNSUBSCRIBES != null)
				{
					Params[8].Value = UNSUBSCRIBES;
				}
				else
				{
					Params[8].Value = DBNull.Value;
				}

				if (COMPLAINS_ != null)
				{
					Params[9].Value = COMPLAINS_;
				}
				else
				{
					Params[9].Value = DBNull.Value;
				}

				if (FORWARDS_ != null)
				{
					Params[10].Value = FORWARDS_;
				}
				else
				{
					Params[10].Value = DBNull.Value;
				}

				if (STATUS != null)
				{
					Params[11].Value = STATUS;
				}
				else
				{
					Params[11].Value = DBNull.Value;
				}

				if (DESC != null)
				{
					Params[12].Value = DESC;
				}
				else
				{
					Params[12].Value = DBNull.Value;
				}

				if (DATESENT != null)
				{
					Params[13].Value = DATESENT;
				}
				else
				{
					Params[13].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SENTEMAILS_Select",Params);
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
				new SqlParameter("@AUTORESPONSEID",AUTORESPONSEID),
				new SqlParameter("@MESSAGEID",MESSAGEID),
				new SqlParameter("@CONTACTID",CONTACTID),
				new SqlParameter("@OPEN",OPEN),
				new SqlParameter("@CLICK",CLICK),
				new SqlParameter("@BOUNCES",BOUNCES),
				new SqlParameter("@NOINFO",NOINFO),
				new SqlParameter("@UNSUBSCRIBES",UNSUBSCRIBES),
				new SqlParameter("@COMPLAINS_",COMPLAINS_),
				new SqlParameter("@FORWARDS_",FORWARDS_),
				new SqlParameter("@STATUS",STATUS),
				new SqlParameter("@DESC",DESC),
				new SqlParameter("@DATESENT",DATESENT) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SENTEMAILS_Insert",Params);
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
				new SqlParameter("@AUTORESPONSEID",AUTORESPONSEID),
				new SqlParameter("@MESSAGEID",MESSAGEID),
				new SqlParameter("@CONTACTID",CONTACTID),
				new SqlParameter("@OPEN",OPEN),
				new SqlParameter("@CLICK",CLICK),
				new SqlParameter("@BOUNCES",BOUNCES),
				new SqlParameter("@NOINFO",NOINFO),
				new SqlParameter("@UNSUBSCRIBES",UNSUBSCRIBES),
				new SqlParameter("@COMPLAINS_",COMPLAINS_),
				new SqlParameter("@FORWARDS_",FORWARDS_),
				new SqlParameter("@STATUS",STATUS),
				new SqlParameter("@DESC",DESC),
				new SqlParameter("@DATESENT",DATESENT) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SENTEMAILS_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_SENTEMAILS_Delete",Params);
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

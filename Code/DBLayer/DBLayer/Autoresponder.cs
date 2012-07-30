using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Autoresponder
	{

	#region Constructor
	public Autoresponder()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private string _NAME;
	private string _DESCRIPTION;
	private int _LISTID;
	private string _FROMNAME;
	private string _FROMEMAIL;
    private int _DURATION;
    private int _ISSEGGMEMT;
   
	private System.DateTime _MODIFIEDDATE;
	 Autoresponder  objclsAUTORESPONDER;
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
	public int LISTID
	{ 
		get { return _LISTID; }
		set { _LISTID = value; }
	}
	public string FROMNAME
	{ 
		get { return _FROMNAME; }
		set { _FROMNAME = value; }
	}
	public string FROMEMAIL
	{ 
		get { return _FROMEMAIL; }
		set { _FROMEMAIL = value; }
	}
    public int DURATION
    {
        get { return _DURATION; }
        set { _DURATION = value; }
    }
    public int ISSEGMENT
    {
        get { return _ISSEGGMEMT; }
        set { _ISSEGGMEMT = value; }
    }
	#endregion

	#region Public Methods
    public DataTable SelectByUserID()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 
				new SqlParameter("@USERID",SqlDbType.Int)
			};


            Params[0].Value = USERID;
            




            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_SelectByUserID", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
    public DataTable SelectByID()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 
				new SqlParameter("@ID",SqlDbType.Int)
			};


            Params[0].Value = ID;





            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_SelectByID", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            return null;// throw new Exception(ex.Message);
        }
    }
	public DataTable Select()
	{
		DataSet ds;
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@USERID",SqlDbType.Int),
				new SqlParameter("@NAME",SqlDbType.NVarChar),
				new SqlParameter("@DESCRIPTION",SqlDbType.NVarChar),
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@FROMNAME",SqlDbType.NVarChar),
				new SqlParameter("@FROMEMAIL",SqlDbType.NVarChar)
				
			};
			

				if (ID != 0)
				{
					Params[0].Value = ID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

				if (USERID != 0)
				{
					Params[1].Value = USERID;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (NAME != null)
				{
					Params[2].Value = NAME;
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

				if (LISTID != 0)
				{
					Params[4].Value = LISTID;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

				if (FROMNAME != null)
				{
					Params[5].Value = FROMNAME;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}

				if (FROMEMAIL != null)
				{
					Params[6].Value = FROMEMAIL;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				


				

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_Select",Params);
			return ds.Tables[0];
		}
		catch(Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
	public int Insert()
	{
		try
		{
			SqlParameter[] Params = 
			{ 
				new SqlParameter("@USERID",USERID),
				new SqlParameter("@NAME",NAME),
				new SqlParameter("@DESCRIPTION",DESCRIPTION),
				new SqlParameter("@LISTID",LISTID),
				new SqlParameter("@FROMNAME",FROMNAME),
				new SqlParameter("@FROMEMAIL",FROMEMAIL),
                new SqlParameter("@DURATION",DURATION)
				
			};

            DataSet ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_Insert", Params);
            
            if (ds.Tables.Count > 0) return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            return -1;
		}
		catch(Exception ex)
		{
            return -1;
		}
	}
	public bool Update()
	{
		try
		{
            SqlParameter[] Params = 
			{ 
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@USERID",SqlDbType.Int),
				new SqlParameter("@NAME",SqlDbType.NVarChar),
				new SqlParameter("@DESCRIPTION",SqlDbType.NVarChar),
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@FROMNAME",SqlDbType.NVarChar),
				new SqlParameter("@FROMEMAIL",SqlDbType.NVarChar),
                new SqlParameter("@DURATION",SqlDbType.NVarChar)
				
				
			};


            if (ID != 0)
            {
                Params[0].Value = ID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (USERID != 0)
            {
                Params[1].Value = USERID;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }

            if (NAME != null)
            {
                Params[2].Value = NAME;
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

            if (LISTID != 0)
            {
                Params[4].Value = LISTID;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }

            if (FROMNAME != null)
            {
                Params[5].Value = FROMNAME;
            }
            else
            {
                Params[5].Value = DBNull.Value;
            }

            if (FROMEMAIL != null)
            {
                Params[6].Value = FROMEMAIL;
            }
            else
            {
                Params[6].Value = DBNull.Value;
            }
            if (DURATION != null)
            {
                Params[7].Value = DURATION;
            }
            else
            {
                Params[7].Value = DBNull.Value;
            }
           

            

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
            if (ID != null)
            {
                // remove out of OPEN_CLICK_STATUS
                ClickOpenStatus openclickCOntroller = new ClickOpenStatus();
                openclickCOntroller.Delete_By_AutoresponderID(ID);
                // REMOVE out of autoresponder-status
                AutoresponderStatus autoStatusController = new AutoresponderStatus();
                autoStatusController.Delete_By_AutoResponderID(ID);
                // remove out of the autoresponder-messages
                Autoresponder_messages autoMessageController = new Autoresponder_messages();
                autoMessageController.Delete_By_AutoresponderID(ID);

                //pending table
                AutoresponderPending pendingController = new AutoresponderPending();
                pendingController.Delete_By_AutoresponderID(ID);
                // remove out of autoresponder

                SqlParameter[] Params = { new SqlParameter("@ID", ID) };
                Params[0].Value = ID;
                int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_Delete", Params);
                if (result > 0)
                {
                    return true;
                }
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

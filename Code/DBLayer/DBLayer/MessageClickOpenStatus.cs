using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class MessageClickOpenStatus
	{

	#region Constructor
        public MessageClickOpenStatus()
	{}
	#endregion

	#region Private Variables


	private int _ID;
	private int _CONTACTID;
	private int _MESSAGEID;

    private int _LISTID;

    private int _COUNTCLICK;
    private int _COUNTOPEN;
    ClickOpenStatus objclsMessageClickOpenStatus;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
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
    public int LISTID
    {
        get { return _LISTID; }
        set { _LISTID = value; }
    }
	
    public int COUNTCLICK
	{
        get { return _COUNTCLICK; }
        set { _COUNTCLICK = value; }
	}
    public int COUNTOPEN
	{
        get { return _COUNTOPEN; }
        set { _COUNTOPEN = value; }
	}
    
	
	#endregion

	#region Public Methods
	public bool Insert()
	{

         
 

		try
		{
			SqlParameter[] Params = 
			{ 

				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@COUNTCLICK",SqlDbType.Int),
				new SqlParameter("@COUNTOPEN",SqlDbType.Int)

				
			};




            if (CONTACTID != null)
				{
                    Params[0].Value = CONTACTID;
				}
				else
				{
					Params[0].Value = DBNull.Value;
				}

            if (MESSAGEID != null)
            {
                Params[1].Value = MESSAGEID;
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

            if (COUNTCLICK != null)
            {
                Params[3].Value = COUNTCLICK;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }

            if (COUNTOPEN != null)
            {
                Params[4].Value = COUNTOPEN;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }

                int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_MESSAGE_OPEN_CLICK_STATUS_Insert", Params);
                if (result > 0)
                {
                    return true;
                }
                return false;
        }
        catch (Exception ex)
        {
            //throw new Exception(ex.Message);
        }
        return false;
	}
    public DataTable Select()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 

				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@LISTID",SqlDbType.Int)
			
				//new SqlParameter("@COUNTCLICK",SqlDbType.Int),
				//new SqlParameter("@COUNTOPEN",SqlDbType.Int)

				
			};




            if (CONTACTID != null)
            {
                Params[0].Value = CONTACTID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (MESSAGEID != null)
            {
                Params[1].Value = MESSAGEID;
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
            






            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_MESSAGE_OPEN_CLICK_STATUS_Select", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
           /// throw new Exception(ex.Message);
        }
        return null;
    }

    public bool Update()
    {
        try
        {
            SqlParameter[] Params = 
			{ 

				new SqlParameter("@CONTACTID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@COUNTCLICK",SqlDbType.Int),
				new SqlParameter("@COUNTOPEN",SqlDbType.Int)
				
			};




            if (CONTACTID != null)
            {
                Params[0].Value = CONTACTID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (MESSAGEID != null)
            {
                Params[1].Value = MESSAGEID;
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

            if (COUNTCLICK != null)
            {
                Params[3].Value = COUNTCLICK;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }

            if (COUNTOPEN != null)
            {
                Params[4].Value = COUNTOPEN;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }


            int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_MESSAGE_OPEN_CLICK_STATUS_Update", Params);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
           // throw new Exception(ex.Message);
        }
        return false;
    }
	#endregion

	}
}

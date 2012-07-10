using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Contact_message
	{

	#region Constructor
        public Contact_message()
	{}
	#endregion

	#region Private Variables
	private int _CONTACTID;
	private int _MESSAGEID;
    private int _LISTID;

    Contact_message objclsCONTACT_MESSAGE;
	#endregion

	#region Public Properties
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
	
	#endregion

	#region Public Methods
    public DataTable Select()
    {
        DataSet ds;
        try
        {
            SqlParameter[] Params = 
			{ 
				
				
				
			};

            ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CONTACT_MESSAGESENT_Select", Params);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

	
	
	
	public bool Delete()
	{
		try
		{
            SqlParameter[] Params = { 
                                        new SqlParameter("@CONTACTID", CONTACTID) ,
                                        new SqlParameter("@MESSAGEID", MESSAGEID) ,
                                        new SqlParameter("@LISTID", MESSAGEID) 
                                    };
            if (CONTACTID >= 0)
            {
                Params[0].Value = CONTACTID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }
            if (MESSAGEID >= 0)
            {
                Params[1].Value = MESSAGEID;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }
            if (LISTID >= 0)
            {
                Params[2].Value = LISTID;
            }
            else
            {
                Params[2].Value = DBNull.Value;
            }
            int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_CONTACT_MESSAGESENT_Delete", Params);
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

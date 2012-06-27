using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Bounce
	{

	#region Constructor
        public Bounce()
	{}
	#endregion

	#region Private Variables


	private int _ID;
	private int _AUTORESPONDERID;
	private int _MESSAGEID;

	private int _LISTID;

	private System.DateTime _DATEBOUNCE;
    private string _BOUNCEMESSAGE;
        private string _EMAIL;
	 Bounce  objclsBounce;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}


    public int AUTORESPONDERID
	{
        get { return _AUTORESPONDERID; }
        set { _AUTORESPONDERID = value; }
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
    public DateTime DATEBOUNCE
	{
        get { return _DATEBOUNCE; }
        set { _DATEBOUNCE = value; }
	}
    public string BOUNCEMESSAGE
	{
        get { return _BOUNCEMESSAGE; }
        set { _BOUNCEMESSAGE = value; }
	}
    public string EMAIL
    {
        get { return _EMAIL; }
        set { _EMAIL = value; }
    }
	
	#endregion

	#region Public Methods
	public bool Insert()
	{

         
 
	//	DataSet ds;
		try
		{
			SqlParameter[] Params = 
			{ 
				//new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@AUTORESPONDERID",SqlDbType.Int),
				new SqlParameter("@MESSAGEID",SqlDbType.Int),
				new SqlParameter("@LISTID",SqlDbType.Int),
				new SqlParameter("@DATEBOUNCE",SqlDbType.DateTime),
				new SqlParameter("@BOUNCEMESSAGE",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar)
				
			};
			

				

                if (AUTORESPONDERID != null)
				{
                    Params[0].Value = AUTORESPONDERID;
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

                if (DATEBOUNCE != null)
				{
                    Params[3].Value = DATEBOUNCE;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

                if (BOUNCEMESSAGE != null)
				{
                    Params[4].Value = BOUNCEMESSAGE;
				}
				else
				{
					Params[4].Value = DBNull.Value;
				}

                if (EMAIL != null)
				{
                    Params[5].Value = EMAIL;
				}
				else
				{
					Params[5].Value = DBNull.Value;
				}







                
                int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_BOUNCES_Insert", Params);
                if (result > 0)
                {
                    return true;
                }
                return false;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
	}
	
	#endregion

	}
}

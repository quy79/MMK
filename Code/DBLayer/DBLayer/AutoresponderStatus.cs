using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class  AutoresponderStatus
	{

	#region Constructor
        public AutoresponderStatus()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _AUTOID;
	private int  _TOTALCONTACT;
    private int _SUMCONTACTSENT;
	private int _STATUS;


	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public int AUTOID
	{
        get { return _AUTOID; }
        set { _AUTOID = value; }
	}
    public int TOTALCONTACT
    {
	
        get { return _TOTALCONTACT; }
        set { _TOTALCONTACT = value; }
	}
    public int SUMCONTACTSENT
	{
        get { return _SUMCONTACTSENT; }
        set { _SUMCONTACTSENT = value; }
	}
    
	
	public int STATUS
	{ 
		get { return _STATUS; }
		set { _STATUS = value; }
	}
        private int _MESSAGEID;
    public int MESSAGEID
    {
        get { return _MESSAGEID; }
        set { _MESSAGEID = value; }
    }
	
	#endregion

	#region Public Methods
    public DataTable Select()
    {
        DataSet ds;
        try
        {
            lock (this)
            {
                SqlParameter[] Params = 
			{ 
				//new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@AUTOID",SqlDbType.Int),
                new SqlParameter("@MESSAGEID",SqlDbType.Int)
				//new SqlParameter("@SUMCONTACTSENT",SqlDbType.Int),
				//new SqlParameter("@STATUS",SqlDbType.Int),
                //new SqlParameter("@MESSAGEID",SqlDbType.Int)
				 
			};


                if (AUTOID != 0)
                {
                    Params[0].Value = AUTOID;
                }
                else
                {
                    Params[0].Value = DBNull.Value;
                }









                if (MESSAGEID != 0)
                {
                    Params[1].Value = MESSAGEID;
                }
                else
                {
                    Params[1].Value = DBNull.Value;
                }



                ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_STATUS_Select", Params);

                return ds.Tables[0];
            }
        }
        catch (Exception ex)
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
				//new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@AUTOID",SqlDbType.Int),
                new SqlParameter("@TOTALCONTACT",SqlDbType.Int),
				new SqlParameter("@SUMCONTACTSENT",SqlDbType.Int),
				new SqlParameter("@STATUS",SqlDbType.Int),
                new SqlParameter("@MESSAGEID",SqlDbType.Int)
				 
			};



            if (AUTOID != 0)
            {
                Params[0].Value = AUTOID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            
                Params[1].Value = TOTALCONTACT;
            

            
                Params[2].Value = SUMCONTACTSENT;
            
            




            if (STATUS != 0)
            {
                Params[3].Value = STATUS;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }
            if (MESSAGEID != 0)
            {
                Params[4].Value = MESSAGEID;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }

            int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure, "SP_AUTORESPONDER_STATUS_Insert", Params);
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
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@AUTOID",SqlDbType.Int),
                new SqlParameter("@TOTALCONTACT",SqlDbType.Int),
				new SqlParameter("@SUMCONTACTSENT",SqlDbType.Int),
				new SqlParameter("@STATUS",SqlDbType.Int),
                new SqlParameter("@MESSAGEID",SqlDbType.Int)
				 
			};


            if (ID != 0)
            {
                Params[0].Value = ID;
            }
            else
            {
                Params[0].Value = DBNull.Value;
            }

            if (AUTOID != 0)
            {
                Params[1].Value = AUTOID;
            }
            else
            {
                Params[1].Value = DBNull.Value;
            }

            if (TOTALCONTACT != 0)
            {
                Params[2].Value = TOTALCONTACT;
            }
            else
            {
                Params[2].Value = DBNull.Value;
            }

            if (SUMCONTACTSENT != 0)
            {
                Params[3].Value = SUMCONTACTSENT;
            }
            else
            {
                Params[3].Value = DBNull.Value;
            }




            if (STATUS != 0)
            {
                Params[4].Value = STATUS;
            }
            else
            {
                Params[4].Value = DBNull.Value;
            }
            if (MESSAGEID != 0)
            {
                Params[5].Value = MESSAGEID;
            }
            else
            {
                Params[5].Value = DBNull.Value;
            }

			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_STATUS_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_AUTORESPONDER_STATUS_Delete",Params);
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

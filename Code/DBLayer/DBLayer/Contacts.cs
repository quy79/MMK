using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Contacts
	{

	#region Constructor
	public Contacts()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private string _FIRSTNAME;
	private string _LASTNAME;
	private string _PREFIX;
	private string _SUFFIX;
	private string _EMAIL;
	private string _ADDRESS1;
	private string _ADDRESS2;
	private string _CITY;
	private string _PROVINCE;
	private string _ZIP;
	private string _PHONE;
	private string _FAX;
	private bool _REQUIRECONFIRM;
	private System.DateTime _MODIFIEDDATE;
	 Contacts  objclsCONTACTS;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public string FIRSTNAME
	{ 
		get { return _FIRSTNAME; }
		set { _FIRSTNAME = value; }
	}
	public string LASTNAME
	{ 
		get { return _LASTNAME; }
		set { _LASTNAME = value; }
	}
	public string PREFIX
	{ 
		get { return _PREFIX; }
		set { _PREFIX = value; }
	}
	public string SUFFIX
	{ 
		get { return _SUFFIX; }
		set { _SUFFIX = value; }
	}
	public string EMAIL
	{ 
		get { return _EMAIL; }
		set { _EMAIL = value; }
	}
	public string ADDRESS1
	{ 
		get { return _ADDRESS1; }
		set { _ADDRESS1 = value; }
	}
	public string ADDRESS2
	{ 
		get { return _ADDRESS2; }
		set { _ADDRESS2 = value; }
	}
	public string CITY
	{ 
		get { return _CITY; }
		set { _CITY = value; }
	}
	public string PROVINCE
	{ 
		get { return _PROVINCE; }
		set { _PROVINCE = value; }
	}
	public string ZIP
	{ 
		get { return _ZIP; }
		set { _ZIP = value; }
	}
	public string PHONE
	{ 
		get { return _PHONE; }
		set { _PHONE = value; }
	}
	public string FAX
	{ 
		get { return _FAX; }
		set { _FAX = value; }
	}
	public bool REQUIRECONFIRM
	{ 
		get { return _REQUIRECONFIRM; }
		set { _REQUIRECONFIRM = value; }
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
				new SqlParameter("@FIRSTNAME",SqlDbType.NVarChar),
				new SqlParameter("@LASTNAME",SqlDbType.NVarChar),
				new SqlParameter("@PREFIX",SqlDbType.NVarChar),
				new SqlParameter("@SUFFIX",SqlDbType.NVarChar),
				new SqlParameter("@EMAIL",SqlDbType.NVarChar),
				new SqlParameter("@ADDRESS1",SqlDbType.NVarChar),
				new SqlParameter("@ADDRESS2",SqlDbType.NVarChar),
				new SqlParameter("@CITY",SqlDbType.NVarChar),
				new SqlParameter("@PROVINCE",SqlDbType.NVarChar),
				new SqlParameter("@ZIP",SqlDbType.NVarChar),
				new SqlParameter("@PHONE",SqlDbType.NVarChar),
				new SqlParameter("@FAX",SqlDbType.NVarChar),
				new SqlParameter("@REQUIRECONFIRM",SqlDbType.Bit),
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

				if (FIRSTNAME != null)
				{
					Params[1].Value = FIRSTNAME;
				}
				else
				{
					Params[1].Value = DBNull.Value;
				}

				if (LASTNAME != null)
				{
					Params[2].Value = LASTNAME;
				}
				else
				{
					Params[2].Value = DBNull.Value;
				}

				if (PREFIX != null)
				{
					Params[3].Value = PREFIX;
				}
				else
				{
					Params[3].Value = DBNull.Value;
				}

				if (SUFFIX != null)
				{
					Params[4].Value = SUFFIX;
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

				if (ADDRESS1 != null)
				{
					Params[6].Value = ADDRESS1;
				}
				else
				{
					Params[6].Value = DBNull.Value;
				}

				if (ADDRESS2 != null)
				{
					Params[7].Value = ADDRESS2;
				}
				else
				{
					Params[7].Value = DBNull.Value;
				}

				if (CITY != null)
				{
					Params[8].Value = CITY;
				}
				else
				{
					Params[8].Value = DBNull.Value;
				}

				if (PROVINCE != null)
				{
					Params[9].Value = PROVINCE;
				}
				else
				{
					Params[9].Value = DBNull.Value;
				}

				if (ZIP != null)
				{
					Params[10].Value = ZIP;
				}
				else
				{
					Params[10].Value = DBNull.Value;
				}

				if (PHONE != null)
				{
					Params[11].Value = PHONE;
				}
				else
				{
					Params[11].Value = DBNull.Value;
				}

				if (FAX != null)
				{
					Params[12].Value = FAX;
				}
				else
				{
					Params[12].Value = DBNull.Value;
				}

				if (REQUIRECONFIRM != null)
				{
					Params[13].Value = REQUIRECONFIRM;
				}
				else
				{
					Params[13].Value = DBNull.Value;
				}

				if (MODIFIEDDATE != null)
				{
					Params[14].Value = MODIFIEDDATE;
				}
				else
				{
					Params[14].Value = DBNull.Value;
				}

			
			ds = SqlHelper.ExecuteDataset(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Select",Params);
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
				new SqlParameter("@FIRSTNAME",FIRSTNAME),
				new SqlParameter("@LASTNAME",LASTNAME),
				new SqlParameter("@PREFIX",PREFIX),
				new SqlParameter("@SUFFIX",SUFFIX),
				new SqlParameter("@EMAIL",EMAIL),
				new SqlParameter("@ADDRESS1",ADDRESS1),
				new SqlParameter("@ADDRESS2",ADDRESS2),
				new SqlParameter("@CITY",CITY),
				new SqlParameter("@PROVINCE",PROVINCE),
				new SqlParameter("@ZIP",ZIP),
				new SqlParameter("@PHONE",PHONE),
				new SqlParameter("@FAX",FAX),
				new SqlParameter("@REQUIRECONFIRM",REQUIRECONFIRM),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Insert",Params);
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
				new SqlParameter("@FIRSTNAME",FIRSTNAME),
				new SqlParameter("@LASTNAME",LASTNAME),
				new SqlParameter("@PREFIX",PREFIX),
				new SqlParameter("@SUFFIX",SUFFIX),
				new SqlParameter("@EMAIL",EMAIL),
				new SqlParameter("@ADDRESS1",ADDRESS1),
				new SqlParameter("@ADDRESS2",ADDRESS2),
				new SqlParameter("@CITY",CITY),
				new SqlParameter("@PROVINCE",PROVINCE),
				new SqlParameter("@ZIP",ZIP),
				new SqlParameter("@PHONE",PHONE),
				new SqlParameter("@FAX",FAX),
				new SqlParameter("@REQUIRECONFIRM",REQUIRECONFIRM),
				new SqlParameter("@MODIFIEDDATE",MODIFIEDDATE) 
			};
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Update",Params);
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
			int result = SqlHelper.ExecuteNonQuery(Globals.ConnectionString, CommandType.StoredProcedure,"SP_CONTACTS_Delete",Params);
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

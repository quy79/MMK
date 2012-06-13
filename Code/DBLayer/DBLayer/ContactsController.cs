using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class ContactsController
	{

	#region Constructor
	public ContactsController()
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
    private bool _SENDEMAIL;
    private string _CONFIRMCODE;
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

    public bool SENDEMAIL
	{ 
		get { return _SENDEMAIL; }
        set { _SENDEMAIL = value; }
	}

    public string CONFIRMCODE
    {
        get { return _CONFIRMCODE; }
        set { _CONFIRMCODE = value; }
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
		DataTable dt;
		try
		{
			objclsCONTACTS = new Contacts();
			
			objclsCONTACTS.ID = ID;
		
			dt = objclsCONTACTS.Select();
			return dt;
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
			objclsCONTACTS = new Contacts();
			
			objclsCONTACTS.FIRSTNAME = FIRSTNAME;
			objclsCONTACTS.LASTNAME = LASTNAME;
			objclsCONTACTS.PREFIX = PREFIX;
			objclsCONTACTS.SUFFIX = SUFFIX;
			objclsCONTACTS.EMAIL = EMAIL;
			objclsCONTACTS.ADDRESS1 = ADDRESS1;
			objclsCONTACTS.ADDRESS2 = ADDRESS2;
			objclsCONTACTS.CITY = CITY;
			objclsCONTACTS.PROVINCE = PROVINCE;
			objclsCONTACTS.ZIP = ZIP;
			objclsCONTACTS.PHONE = PHONE;
			objclsCONTACTS.FAX = FAX;
            objclsCONTACTS.CONFIRMED = REQUIRECONFIRM;
			objclsCONTACTS.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsCONTACTS.Insert()>0)
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
			objclsCONTACTS = new Contacts();
			
			objclsCONTACTS.ID = ID;
			objclsCONTACTS.FIRSTNAME = FIRSTNAME;
			objclsCONTACTS.LASTNAME = LASTNAME;
			objclsCONTACTS.PREFIX = PREFIX;
			objclsCONTACTS.SUFFIX = SUFFIX;
			objclsCONTACTS.EMAIL = EMAIL;
			objclsCONTACTS.ADDRESS1 = ADDRESS1;
			objclsCONTACTS.ADDRESS2 = ADDRESS2;
			objclsCONTACTS.CITY = CITY;
			objclsCONTACTS.PROVINCE = PROVINCE;
			objclsCONTACTS.ZIP = ZIP;
			objclsCONTACTS.PHONE = PHONE;
			objclsCONTACTS.FAX = FAX;
            objclsCONTACTS.CONFIRMED = REQUIRECONFIRM;
			objclsCONTACTS.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsCONTACTS.Update())
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
			objclsCONTACTS = new Contacts();
			
			objclsCONTACTS.ID = ID;
		
			if(objclsCONTACTS.Delete())
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

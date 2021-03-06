using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class UsersController
	{

	#region Constructor
	public UsersController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private string _FIRSTNAME;
	private string _LASTNAME;
	private string _USERNAME;
	private string _PASSWORD;
	private string _TITLE;
	private string _EMAIL;
	private string _PHONE;
	private string _CITY;
	private string _PROVINCE;
	private string _POSTCODE;
	private string _COUNTRY;
	private System.DateTime _MODIFIEDDATE;
	 Users  objclsUSERS;
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
	public string USERNAME
	{ 
		get { return _USERNAME; }
		set { _USERNAME = value; }
	}
	public string PASSWORD
	{ 
		get { return _PASSWORD; }
		set { _PASSWORD = value; }
	}
	public string TITLE
	{ 
		get { return _TITLE; }
		set { _TITLE = value; }
	}
	public string EMAIL
	{ 
		get { return _EMAIL; }
		set { _EMAIL = value; }
	}
	public string PHONE
	{ 
		get { return _PHONE; }
		set { _PHONE = value; }
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
	public string POSTCODE
	{ 
		get { return _POSTCODE; }
		set { _POSTCODE = value; }
	}
	public string COUNTRY
	{ 
		get { return _COUNTRY; }
		set { _COUNTRY = value; }
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
			objclsUSERS = new Users();
			
			objclsUSERS.ID = ID;
		
			dt = objclsUSERS.Select();
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
			objclsUSERS = new Users();
			
			objclsUSERS.FIRSTNAME = FIRSTNAME;
			objclsUSERS.LASTNAME = LASTNAME;
			objclsUSERS.USERNAME = USERNAME;
			objclsUSERS.PASSWORD = PASSWORD;
			objclsUSERS.TITLE = TITLE;
			objclsUSERS.EMAIL = EMAIL;
			objclsUSERS.PHONE = PHONE;
			objclsUSERS.CITY = CITY;
			objclsUSERS.PROVINCE = PROVINCE;
			objclsUSERS.POSTCODE = POSTCODE;
			objclsUSERS.COUNTRY = COUNTRY;
			objclsUSERS.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsUSERS.Insert())
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
			objclsUSERS = new Users();
			
			objclsUSERS.ID = ID;
			objclsUSERS.FIRSTNAME = FIRSTNAME;
			objclsUSERS.LASTNAME = LASTNAME;
			objclsUSERS.USERNAME = USERNAME;
			objclsUSERS.PASSWORD = PASSWORD;
			objclsUSERS.TITLE = TITLE;
			objclsUSERS.EMAIL = EMAIL;
			objclsUSERS.PHONE = PHONE;
			objclsUSERS.CITY = CITY;
			objclsUSERS.PROVINCE = PROVINCE;
			objclsUSERS.POSTCODE = POSTCODE;
			objclsUSERS.COUNTRY = COUNTRY;
			objclsUSERS.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsUSERS.Update())
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
			objclsUSERS = new Users();
			
			objclsUSERS.ID = ID;
		
			if(objclsUSERS.Delete())
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

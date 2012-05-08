using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Contact_listController
	{

	#region Constructor
	public Contact_listController()
	{}
	#endregion

	#region Private Variables
	private int _CONTACTID;
	private int _LISTID;
	private bool _SUBSCRIBES;
	 Contact_list  objclsCONTACT_LIST;
	#endregion

	#region Public Properties
	public int CONTACTID
	{ 
		get { return _CONTACTID; }
		set { _CONTACTID = value; }
	}
	public int LISTID
	{ 
		get { return _LISTID; }
		set { _LISTID = value; }
	}
	public bool SUBSCRIBES
	{ 
		get { return _SUBSCRIBES; }
		set { _SUBSCRIBES = value; }
	}
	#endregion

	#region Public Methods
	public DataTable Select()
	{
		DataTable dt;
		try
		{
			objclsCONTACT_LIST = new Contact_list();
			
			objclsCONTACT_LIST.CONTACTID = CONTACTID;
		
			dt = objclsCONTACT_LIST.Select();
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
			objclsCONTACT_LIST = new Contact_list();
			
			objclsCONTACT_LIST.LISTID = LISTID;
			objclsCONTACT_LIST.SUBSCRIBES = SUBSCRIBES;
		
			if(objclsCONTACT_LIST.Insert())
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
			objclsCONTACT_LIST = new Contact_list();
			
			objclsCONTACT_LIST.CONTACTID = CONTACTID;
			objclsCONTACT_LIST.LISTID = LISTID;
			objclsCONTACT_LIST.SUBSCRIBES = SUBSCRIBES;
		
			if(objclsCONTACT_LIST.Update())
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
			objclsCONTACT_LIST = new Contact_list();
			
			objclsCONTACT_LIST.CONTACTID = CONTACTID;
		
			if(objclsCONTACT_LIST.Delete())
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

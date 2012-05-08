using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class ListsController
	{

	#region Constructor
	public ListsController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private string _LISTNAME;
	private string _DESCRIPTION;
	private bool _NOTIFICATION;
	private string _PUBLICLABEL;
	private int _WELLCOMEMSGID;
	private int _TOTALSUBSCRIBES;
	private System.DateTime _MODIFIEDDATE;
	 Lists  objclsLISTS;
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
	public string LISTNAME
	{ 
		get { return _LISTNAME; }
		set { _LISTNAME = value; }
	}
	public string DESCRIPTION
	{ 
		get { return _DESCRIPTION; }
		set { _DESCRIPTION = value; }
	}
	public bool NOTIFICATION
	{ 
		get { return _NOTIFICATION; }
		set { _NOTIFICATION = value; }
	}
	public string PUBLICLABEL
	{ 
		get { return _PUBLICLABEL; }
		set { _PUBLICLABEL = value; }
	}
	public int WELLCOMEMSGID
	{ 
		get { return _WELLCOMEMSGID; }
		set { _WELLCOMEMSGID = value; }
	}
	public int TOTALSUBSCRIBES
	{ 
		get { return _TOTALSUBSCRIBES; }
		set { _TOTALSUBSCRIBES = value; }
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
			objclsLISTS = new Lists();
			
			objclsLISTS.ID = ID;
		
			dt = objclsLISTS.Select();
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
			objclsLISTS = new Lists();
			
			objclsLISTS.USERID = USERID;
			objclsLISTS.LISTNAME = LISTNAME;
			objclsLISTS.DESCRIPTION = DESCRIPTION;
			objclsLISTS.NOTIFICATION = NOTIFICATION;
			objclsLISTS.PUBLICLABEL = PUBLICLABEL;
			objclsLISTS.WELLCOMEMSGID = WELLCOMEMSGID;
			objclsLISTS.TOTALSUBSCRIBES = TOTALSUBSCRIBES;
			objclsLISTS.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsLISTS.Insert())
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
			objclsLISTS = new Lists();
			
			objclsLISTS.ID = ID;
			objclsLISTS.USERID = USERID;
			objclsLISTS.LISTNAME = LISTNAME;
			objclsLISTS.DESCRIPTION = DESCRIPTION;
			objclsLISTS.NOTIFICATION = NOTIFICATION;
			objclsLISTS.PUBLICLABEL = PUBLICLABEL;
			objclsLISTS.WELLCOMEMSGID = WELLCOMEMSGID;
			objclsLISTS.TOTALSUBSCRIBES = TOTALSUBSCRIBES;
			objclsLISTS.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsLISTS.Update())
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
			objclsLISTS = new Lists();
			
			objclsLISTS.ID = ID;
		
			if(objclsLISTS.Delete())
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

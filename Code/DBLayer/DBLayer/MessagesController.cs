using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class MessagesController
	{

	#region Constructor
	public MessagesController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private string _MESSAGENAME;
	private string _FROM;
	private string _SUBJECT;
	private string _BODY;
	private string _WEBPAGE;
	private bool _TYPE;
	private int _STATUS;
	private System.DateTime _MODIFIEDDATE;
	 Messages  objclsMESSAGES;
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
	public string MESSAGENAME
	{ 
		get { return _MESSAGENAME; }
		set { _MESSAGENAME = value; }
	}
	public string FROM
	{ 
		get { return _FROM; }
		set { _FROM = value; }
	}
	public string SUBJECT
	{ 
		get { return _SUBJECT; }
		set { _SUBJECT = value; }
	}
	public string BODY
	{ 
		get { return _BODY; }
		set { _BODY = value; }
	}
	public string WEBPAGE
	{ 
		get { return _WEBPAGE; }
		set { _WEBPAGE = value; }
	}
	public bool TYPE
	{ 
		get { return _TYPE; }
		set { _TYPE = value; }
	}
	public int STATUS
	{ 
		get { return _STATUS; }
		set { _STATUS = value; }
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
			objclsMESSAGES = new Messages();
			
			objclsMESSAGES.ID = ID;
		
			dt = objclsMESSAGES.Select();
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
			objclsMESSAGES = new Messages();
			
			objclsMESSAGES.USERID = USERID;
			objclsMESSAGES.MESSAGENAME = MESSAGENAME;
			objclsMESSAGES.FROM = FROM;
			objclsMESSAGES.SUBJECT = SUBJECT;
			objclsMESSAGES.BODY = BODY;
			objclsMESSAGES.WEBPAGE = WEBPAGE;
			objclsMESSAGES.TYPE = TYPE;
			objclsMESSAGES.STATUS = STATUS;
			objclsMESSAGES.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsMESSAGES.Insert())
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
			objclsMESSAGES = new Messages();
			
			objclsMESSAGES.ID = ID;
			objclsMESSAGES.USERID = USERID;
			objclsMESSAGES.MESSAGENAME = MESSAGENAME;
			objclsMESSAGES.FROM = FROM;
			objclsMESSAGES.SUBJECT = SUBJECT;
			objclsMESSAGES.BODY = BODY;
			objclsMESSAGES.WEBPAGE = WEBPAGE;
			objclsMESSAGES.TYPE = TYPE;
			objclsMESSAGES.STATUS = STATUS;
			objclsMESSAGES.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsMESSAGES.Update())
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
			objclsMESSAGES = new Messages();
			
			objclsMESSAGES.ID = ID;
		
			if(objclsMESSAGES.Delete())
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

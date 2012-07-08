using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class AutoresponderController
	{

	#region Constructor
	public AutoresponderController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private string _NAME;
	private string _DESCRIPTION;
	private int _LISTID;
	private string _FROMNAME;
	private string _FROMEMAIL;
	private int _STATUS;
	private System.DateTime _MODIFIEDDATE;
	 Autoresponder  objclsAUTORESPONDER;
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
	public string NAME
	{ 
		get { return _NAME; }
		set { _NAME = value; }
	}
	public string DESCRIPTION
	{ 
		get { return _DESCRIPTION; }
		set { _DESCRIPTION = value; }
	}
	public int LISTID
	{ 
		get { return _LISTID; }
		set { _LISTID = value; }
	}
	public string FROMNAME
	{ 
		get { return _FROMNAME; }
		set { _FROMNAME = value; }
	}
	public string FROMEMAIL
	{ 
		get { return _FROMEMAIL; }
		set { _FROMEMAIL = value; }
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
			objclsAUTORESPONDER = new Autoresponder();
			
			objclsAUTORESPONDER.ID = ID;
		
			dt = objclsAUTORESPONDER.Select();
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
			objclsAUTORESPONDER = new Autoresponder();
			
			objclsAUTORESPONDER.USERID = USERID;
			objclsAUTORESPONDER.NAME = NAME;
			objclsAUTORESPONDER.DESCRIPTION = DESCRIPTION;
			objclsAUTORESPONDER.LISTID = LISTID;
			objclsAUTORESPONDER.FROMNAME = FROMNAME;
			objclsAUTORESPONDER.FROMEMAIL = FROMEMAIL;
			//objclsAUTORESPONDER.STATUS = STATUS;
			//objclsAUTORESPONDER.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsAUTORESPONDER.Insert()>0)
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
			objclsAUTORESPONDER = new Autoresponder();
			
			objclsAUTORESPONDER.ID = ID;
			objclsAUTORESPONDER.USERID = USERID;
			objclsAUTORESPONDER.NAME = NAME;
			objclsAUTORESPONDER.DESCRIPTION = DESCRIPTION;
			objclsAUTORESPONDER.LISTID = LISTID;
			objclsAUTORESPONDER.FROMNAME = FROMNAME;
			objclsAUTORESPONDER.FROMEMAIL = FROMEMAIL;
			//objclsAUTORESPONDER.STATUS = STATUS;
			//objclsAUTORESPONDER.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsAUTORESPONDER.Update())
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
			objclsAUTORESPONDER = new Autoresponder();
			
			objclsAUTORESPONDER.ID = ID;
		
			if(objclsAUTORESPONDER.Delete())
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

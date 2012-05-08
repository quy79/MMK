using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Autoresponder_messagesController
	{

	#region Constructor
	public Autoresponder_messagesController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _AUTORESPONDERID;
	private int _MESSAGEID;
	 Autoresponder_messages  objclsAUTORESPONDER_MESSAGES;
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
	#endregion

	#region Public Methods
	public DataTable Select()
	{
		DataTable dt;
		try
		{
			objclsAUTORESPONDER_MESSAGES = new Autoresponder_messages();
			
			objclsAUTORESPONDER_MESSAGES.ID = ID;
		
			dt = objclsAUTORESPONDER_MESSAGES.Select();
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
			objclsAUTORESPONDER_MESSAGES = new Autoresponder_messages();
			
			objclsAUTORESPONDER_MESSAGES.AUTORESPONDERID = AUTORESPONDERID;
			objclsAUTORESPONDER_MESSAGES.MESSAGEID = MESSAGEID;
		
			if(objclsAUTORESPONDER_MESSAGES.Insert())
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
			objclsAUTORESPONDER_MESSAGES = new Autoresponder_messages();
			
			objclsAUTORESPONDER_MESSAGES.ID = ID;
			objclsAUTORESPONDER_MESSAGES.AUTORESPONDERID = AUTORESPONDERID;
			objclsAUTORESPONDER_MESSAGES.MESSAGEID = MESSAGEID;
		
			if(objclsAUTORESPONDER_MESSAGES.Update())
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
			objclsAUTORESPONDER_MESSAGES = new Autoresponder_messages();
			
			objclsAUTORESPONDER_MESSAGES.ID = ID;
		
			if(objclsAUTORESPONDER_MESSAGES.Delete())
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

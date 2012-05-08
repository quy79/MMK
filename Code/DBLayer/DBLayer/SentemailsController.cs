using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class SentemailsController
	{

	#region Constructor
	public SentemailsController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _AUTORESPONSEID;
	private int _MESSAGEID;
	private int _CONTACTID;
	private bool _OPEN;
	private bool _CLICK;
	private bool _BOUNCES;
	private bool _NOINFO;
	private bool _UNSUBSCRIBES;
	private bool _COMPLAINS_;
	private bool _FORWARDS_;
	private bool _STATUS;
	private string _DESC;
	private System.DateTime _DATESENT;
	 Sentemails  objclsSENTEMAILS;
	#endregion

	#region Public Properties
	public int ID
	{ 
		get { return _ID; }
		set { _ID = value; }
	}
	public int AUTORESPONSEID
	{ 
		get { return _AUTORESPONSEID; }
		set { _AUTORESPONSEID = value; }
	}
	public int MESSAGEID
	{ 
		get { return _MESSAGEID; }
		set { _MESSAGEID = value; }
	}
	public int CONTACTID
	{ 
		get { return _CONTACTID; }
		set { _CONTACTID = value; }
	}
	public bool OPEN
	{ 
		get { return _OPEN; }
		set { _OPEN = value; }
	}
	public bool CLICK
	{ 
		get { return _CLICK; }
		set { _CLICK = value; }
	}
	public bool BOUNCES
	{ 
		get { return _BOUNCES; }
		set { _BOUNCES = value; }
	}
	public bool NOINFO
	{ 
		get { return _NOINFO; }
		set { _NOINFO = value; }
	}
	public bool UNSUBSCRIBES
	{ 
		get { return _UNSUBSCRIBES; }
		set { _UNSUBSCRIBES = value; }
	}
	public bool COMPLAINS_
	{ 
		get { return _COMPLAINS_; }
		set { _COMPLAINS_ = value; }
	}
	public bool FORWARDS_
	{ 
		get { return _FORWARDS_; }
		set { _FORWARDS_ = value; }
	}
	public bool STATUS
	{ 
		get { return _STATUS; }
		set { _STATUS = value; }
	}
	public string DESC
	{ 
		get { return _DESC; }
		set { _DESC = value; }
	}
	public System.DateTime DATESENT
	{ 
		get { return _DATESENT; }
		set { _DATESENT = value; }
	}
	#endregion

	#region Public Methods
	public DataTable Select()
	{
		DataTable dt;
		try
		{
			objclsSENTEMAILS = new Sentemails();
			
			objclsSENTEMAILS.ID = ID;
		
			dt = objclsSENTEMAILS.Select();
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
			objclsSENTEMAILS = new Sentemails();
			
			objclsSENTEMAILS.AUTORESPONSEID = AUTORESPONSEID;
			objclsSENTEMAILS.MESSAGEID = MESSAGEID;
			objclsSENTEMAILS.CONTACTID = CONTACTID;
			objclsSENTEMAILS.OPEN = OPEN;
			objclsSENTEMAILS.CLICK = CLICK;
			objclsSENTEMAILS.BOUNCES = BOUNCES;
			objclsSENTEMAILS.NOINFO = NOINFO;
			objclsSENTEMAILS.UNSUBSCRIBES = UNSUBSCRIBES;
			objclsSENTEMAILS.COMPLAINS_ = COMPLAINS_;
			objclsSENTEMAILS.FORWARDS_ = FORWARDS_;
			objclsSENTEMAILS.STATUS = STATUS;
			objclsSENTEMAILS.DESC = DESC;
			objclsSENTEMAILS.DATESENT = DATESENT;
		
			if(objclsSENTEMAILS.Insert())
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
			objclsSENTEMAILS = new Sentemails();
			
			objclsSENTEMAILS.ID = ID;
			objclsSENTEMAILS.AUTORESPONSEID = AUTORESPONSEID;
			objclsSENTEMAILS.MESSAGEID = MESSAGEID;
			objclsSENTEMAILS.CONTACTID = CONTACTID;
			objclsSENTEMAILS.OPEN = OPEN;
			objclsSENTEMAILS.CLICK = CLICK;
			objclsSENTEMAILS.BOUNCES = BOUNCES;
			objclsSENTEMAILS.NOINFO = NOINFO;
			objclsSENTEMAILS.UNSUBSCRIBES = UNSUBSCRIBES;
			objclsSENTEMAILS.COMPLAINS_ = COMPLAINS_;
			objclsSENTEMAILS.FORWARDS_ = FORWARDS_;
			objclsSENTEMAILS.STATUS = STATUS;
			objclsSENTEMAILS.DESC = DESC;
			objclsSENTEMAILS.DATESENT = DATESENT;
		
			if(objclsSENTEMAILS.Update())
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
			objclsSENTEMAILS = new Sentemails();
			
			objclsSENTEMAILS.ID = ID;
		
			if(objclsSENTEMAILS.Delete())
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

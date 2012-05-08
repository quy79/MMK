using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class SegmentController
	{

	#region Constructor
	public SegmentController()
	{}
	#endregion

	#region Private Variables
	private int _ID;
	private int _USERID;
	private int _LISTID;
	private string _NAME;
	private string _DESCRIPTION;
	private int _TOTALSUBSCRIBES;
	private System.DateTime _MODIFIEDDATE;
	 Segment  objclsSEGMENT;
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
	public int LISTID
	{ 
		get { return _LISTID; }
		set { _LISTID = value; }
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
			objclsSEGMENT = new Segment();
			
			objclsSEGMENT.ID = ID;
		
			dt = objclsSEGMENT.Select();
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
			objclsSEGMENT = new Segment();
			
			objclsSEGMENT.USERID = USERID;
			objclsSEGMENT.LISTID = LISTID;
			objclsSEGMENT.NAME = NAME;
			objclsSEGMENT.DESCRIPTION = DESCRIPTION;
			objclsSEGMENT.TOTALSUBSCRIBES = TOTALSUBSCRIBES;
			objclsSEGMENT.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsSEGMENT.Insert())
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
			objclsSEGMENT = new Segment();
			
			objclsSEGMENT.ID = ID;
			objclsSEGMENT.USERID = USERID;
			objclsSEGMENT.LISTID = LISTID;
			objclsSEGMENT.NAME = NAME;
			objclsSEGMENT.DESCRIPTION = DESCRIPTION;
			objclsSEGMENT.TOTALSUBSCRIBES = TOTALSUBSCRIBES;
			objclsSEGMENT.MODIFIEDDATE = MODIFIEDDATE;
		
			if(objclsSEGMENT.Update())
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
			objclsSEGMENT = new Segment();
			
			objclsSEGMENT.ID = ID;
		
			if(objclsSEGMENT.Delete())
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

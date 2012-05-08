using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DatabaseLayer
{
	public class Segment_contactController
	{

	#region Constructor
	public Segment_contactController()
	{}
	#endregion

	#region Private Variables
	private int _SEGMENTID;
	private int _CONTACTID;
	private bool _SUBSCRIBES;
	 Segment_contact  objclsSEGMENT_CONTACT;
	#endregion

	#region Public Properties
	public int SEGMENTID
	{ 
		get { return _SEGMENTID; }
		set { _SEGMENTID = value; }
	}
	public int CONTACTID
	{ 
		get { return _CONTACTID; }
		set { _CONTACTID = value; }
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
			objclsSEGMENT_CONTACT = new Segment_contact();
			
			objclsSEGMENT_CONTACT.SEGMENTID = SEGMENTID;
		
			dt = objclsSEGMENT_CONTACT.Select();
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
			objclsSEGMENT_CONTACT = new Segment_contact();
			
			objclsSEGMENT_CONTACT.CONTACTID = CONTACTID;
			objclsSEGMENT_CONTACT.SUBSCRIBES = SUBSCRIBES;
		
			if(objclsSEGMENT_CONTACT.Insert())
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
			objclsSEGMENT_CONTACT = new Segment_contact();
			
			objclsSEGMENT_CONTACT.SEGMENTID = SEGMENTID;
			objclsSEGMENT_CONTACT.CONTACTID = CONTACTID;
			objclsSEGMENT_CONTACT.SUBSCRIBES = SUBSCRIBES;
		
			if(objclsSEGMENT_CONTACT.Update())
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
			objclsSEGMENT_CONTACT = new Segment_contact();
			
			objclsSEGMENT_CONTACT.SEGMENTID = SEGMENTID;
		
			if(objclsSEGMENT_CONTACT.Delete())
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

namespace ZetaSpamAssassin
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Collections.Generic;
	using System.Text;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// The different commands to send to SPAMD.
	/// </summary>
	/// <remarks>
	/// Developed 2006-02-16.
	/// For questions and comments, please contact Uwe Keim at
	/// mailto:uwe.keim@zeta-software.de.
	/// Also, see my private webcam and weblog at http://www.magerquark.de
	/// </remarks>
	internal sealed class SpamAssassinCommands
	{
		#region Constant variables.
		// ------------------------------------------------------------------

		public const string Check = "CHECK";
		public const string Symbols = "SYMBOLS";
		public const string Report = "REPORT";
		public const string ReportIfSpam = "REPORT_IFSPAM";
		public const string Skip = "SKIP";
		public const string Ping = "PING";
		public const string Process = "PROCESS";
		public const string Tell = "TELL";

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}
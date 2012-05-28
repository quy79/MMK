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
	/// Exception class for exceptions generated from the SpamAssassinXxx
	/// classes.
	/// </summary>
	/// <remarks>
	/// Developed 2006-02-16.
	/// For questions and comments, please contact Uwe Keim at
	/// mailto:uwe.keim@zeta-software.de.
	/// Also, see my private webcam and weblog at http://www.magerquark.de
	/// </remarks>
	public class SpamAssassinException :
		Exception
	{
		#region Public constructors.
		// ------------------------------------------------------------------

		public SpamAssassinException()
			:
			base()
		{
		}

		public SpamAssassinException(
			string message )
			:
			base( message )
		{
		}

		public SpamAssassinException(
			string message,
			Exception innerException )
			:
		base( message, innerException )
		{
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}
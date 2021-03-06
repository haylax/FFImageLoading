﻿using System;
using System.Diagnostics;

namespace FFImageLoading.Helpers
{
    internal class MiniLogger: IMiniLogger
    {
        public void Debug(string message)
        {
			DebugInternal(message);
        }

		public void Error(string errorMessage)
		{
			Console.WriteLine(errorMessage);
		}

        public void Error(string errorMessage, Exception ex)
        {
			Error(errorMessage + Environment.NewLine + ex.ToString());
        }

		[Conditional("DEBUG")]
		private void DebugInternal(string message)
		{
			System.Diagnostics.Debug.WriteLine(message);
		}
    }
}


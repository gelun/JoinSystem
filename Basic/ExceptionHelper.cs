using System;

namespace Basic
{
	/// <summary>
	/// DNT自定义异常类。
	/// </summary>
	public class ExceptionHelper : Exception
	{
		public ExceptionHelper()
		{
			//
		}


		public ExceptionHelper(string msg) : base(msg)
		{
			//
		}
	}
}

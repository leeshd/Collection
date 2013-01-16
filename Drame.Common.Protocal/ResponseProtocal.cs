using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drame.Common.Protocal
{
	public class ResponseProtocal<T>
	{
		
		public string Error
		{
			get;
			set;
		}
		
		public string Request
		{
			get;
			set;
		}
		
		public T ResponseBody
		{
			get;
			set;
		}
	}
}

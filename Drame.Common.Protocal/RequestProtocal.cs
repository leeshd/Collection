using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drame.Common.Protocal
{
	public class RequestUnit
	{
		public string Source
		{
			get;
			set;
		}
		
		public string Module
		{
			get;
			set;
		}
		
		public Dictionary<string, object> Params;
	}
	
	public class RequestProtocal
	{
		public string UserName
		{
			get;
			set;
		}
		
		public string Password
		{
			get;
			set;
		}
		
		public string RequestType
		{
			get;
			set;
		}
		
		public Dictionary<string, object> ClientInfo;
		
		public RequestUnit Unit
		{
			get;
			set;
		}
	}
}

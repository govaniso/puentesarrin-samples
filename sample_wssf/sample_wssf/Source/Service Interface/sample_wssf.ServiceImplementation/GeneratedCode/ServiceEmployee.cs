//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WCF = global::System.ServiceModel;

namespace sample_wssf.ServiceImplementation
{	
	/// <summary>
	/// Service Class - ServiceEmployee
	/// </summary>
	[WCF::ServiceBehavior(Name = "ServiceEmployee", 
		Namespace = "http://puentesarr.in", 
		InstanceContextMode = WCF::InstanceContextMode.PerSession, 
		ConcurrencyMode = WCF::ConcurrencyMode.Single )]
	public abstract class ServiceEmployeeBase : sample_wssf.ServiceContracts.IServiceContractEmployee
	{
		#region ServiceContractEmployee Members

		public virtual sample_wssf.MessageContracts.selectAllEmployeesResponse SelectAllEmployees()
		{
			return null;
		}

		#endregion		
		
	}
	
	public partial class ServiceEmployee : ServiceEmployeeBase
	{
	}
	
}


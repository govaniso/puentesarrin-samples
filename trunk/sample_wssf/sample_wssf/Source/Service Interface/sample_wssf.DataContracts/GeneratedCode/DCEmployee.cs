//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace sample_wssf.DataContracts
{
	/// <summary>
	/// Data Contract Class - DCEmployee
	/// </summary>
	[WcfSerialization::DataContract(Namespace = "http://puentesarr.in", Name = "DCEmployee")]
	public partial class DCEmployee 
	{
		private int employeeID;
		private string lastName;
		private string firstName;
		
		[WcfSerialization::DataMember(Name = "EmployeeID", IsRequired = false, Order = 0)]
		public int EmployeeID
		{
		  get { return employeeID; }
		  set { employeeID = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "LastName", IsRequired = false, Order = 1)]
		public string LastName
		{
		  get { return lastName; }
		  set { lastName = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "FirstName", IsRequired = false, Order = 2)]
		public string FirstName
		{
		  get { return firstName; }
		  set { firstName = value; }
		}				
	}
}


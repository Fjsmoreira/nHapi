using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V25.Segment;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the RRA_O18_RESPONSE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: RRA_O18_PATIENT (a Group object) optional </li>
///<li>1: RRA_O18_ORDER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class RRA_O18_RESPONSE : AbstractGroup {

	///<summary> 
	/// Creates a new RRA_O18_RESPONSE Group.
	///</summary>
	public RRA_O18_RESPONSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RRA_O18_PATIENT), false, false);
	      this.add(typeof(RRA_O18_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RRA_O18_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns RRA_O18_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public RRA_O18_PATIENT PATIENT { 
get{
	   RRA_O18_PATIENT ret = null;
	   try {
	      ret = (RRA_O18_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RRA_O18_ORDER (a Group object) - creates it if necessary
	///</summary>
	public RRA_O18_ORDER GetORDER() {
	   RRA_O18_ORDER ret = null;
	   try {
	      ret = (RRA_O18_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RRA_O18_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RRA_O18_ORDER GetORDER(int rep) { 
	   return (RRA_O18_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRA_O18_ORDER 
	 */ 
	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RRA_O18_ORDER results 
	 */ 
	public IEnumerable<RRA_O18_ORDER> ORDERs 
	{ 
		get
		{
			for (int rep = 0; rep < ORDERRepetitionsUsed; rep++)
			{
				yield return (RRA_O18_ORDER)this.GetStructure("ORDER", rep);
			}
		}
	}

	///<summary>
	///Adds a new RRA_O18_ORDER
	///</summary>
	public RRA_O18_ORDER AddORDER()
	{
		return this.AddStructure("ORDER") as RRA_O18_ORDER;
	}

	///<summary>
	///Removes the given RRA_O18_ORDER
	///</summary>
	public void RemoveORDER(RRA_O18_ORDER toRemove)
	{
		this.RemoveStructure("ORDER", toRemove);
	}

	///<summary>
	///Removes the RRA_O18_ORDER at the given index
	///</summary>
	public void RemoveORDERAt(int index)
	{
		this.RemoveRepetition("ORDER", index);
	}

}
}

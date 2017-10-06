using System.Collections;
using UnityEngine;

public static class StandardRaycast {
	public static string GetTagFromRaycast(Vector3 origin, Vector3 direction, float length)
	{
		string retVal = "";
		RaycastHit hitInfo;
		if(Physics.Raycast (origin, direction, out hitInfo, length)){
			retVal = hitInfo.collider.tag;
		}
		return retVal;
	}

}

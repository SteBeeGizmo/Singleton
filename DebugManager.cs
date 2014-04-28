using UnityEngine;
using System.Collections;

public class DebugManager : Singleton<DebugManager>
{
	#region Singleton<T> boilerplate
	void Awake()
	{
		// You MUST call the base class onAwake() method
		//	before you exit Awake().
		onAwake();

		/*
		 * Do not exit Awake() without being ready to
		 *	receive calls to all your methods. You cannot
		 *	rely on references to other objects until Start()
		 *	is called, but because Unity's order of initialization
		 *	is not defined within a scene, your singleton
		 *	may receive calls from other objects in between
		 *	Awake() and Start().
		 */
	}
	#endregion

	public void Log(string message, params object[] fields)
	{
		if (!GlobalsManager.Instance.UseLogging)
			return;

		string actual = "oops";
		if (fields == null || fields.Length == 0)
			actual = message;
		else
			actual = string.Format(message, fields);

		Debug.Log (actual);
	}
}

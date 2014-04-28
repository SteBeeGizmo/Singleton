using UnityEngine;
using System.Collections;

public class GlobalsManager : Singleton<GlobalsManager>
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

		UseLogging = LogAlways || Debug.isDebugBuild;
	}
	#endregion


	public bool LogAlways = false;

	public bool UseLogging { get; protected set; }
}

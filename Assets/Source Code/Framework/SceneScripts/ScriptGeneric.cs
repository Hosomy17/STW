using UnityEngine;
using System.Collections;

public abstract class ScriptGeneric : MonoBehaviour
{

    public GameManagerGeneric gameManager;

	void Awake ()
    {
        gameManager = GameManagerGeneric.Instance;
	}
}

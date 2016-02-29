using UnityEngine;
using System.Collections;

public class SceneManagerGeneric : MonoBehaviour
{

    private GameManagerGeneric gameManager;

	void Awake ()
    {
        gameManager = GameManagerGeneric.Instance;
	}
}

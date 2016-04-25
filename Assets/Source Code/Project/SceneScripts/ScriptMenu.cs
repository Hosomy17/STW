using UnityEngine;
using System.Collections;

public class ScriptMenu : MonoBehaviour {

    private GameManagerGeneric gameManager;
	
    void Awake ()
    {
        gameManager = GameManagerGeneric.Instance;
	}

	void Update ()
    {
	
	}
    
    public void StartGame()
    {
        gameManager.LoadScene("Game");
    }

    public void Quit()
    {
        gameManager.CloseGame();
    }

}

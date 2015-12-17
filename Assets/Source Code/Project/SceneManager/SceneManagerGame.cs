using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneManagerGame : SceneManagerGeneric
{
    public Text txtPoints;
    private int totalPoints;

    private GameObject mainMenuCamera;
    private GameObject hudCamera;
    private GameObject button;

    void Awake()
    {
        mainMenuCamera = GameObject.Find("Main Menu Camera");
        hudCamera      = GameObject.Find("HUD Camera");
        button         = GameObject.Find("Button");
        hudCamera.SetActive(false);

        totalPoints    = 0;
    }

    public void GainPoints(int points)
    {
        totalPoints += points;
        this.txtPoints.text = totalPoints.ToString();
    }

    public void StartGame()
    {
        GetComponent<ItenSpawner>().Spawn();

        BehaviourAnimation.Play(mainMenuCamera, "Zoom Out");
        hudCamera.SetActive(true);

        button.GetComponent<GamepadTouch>().enabled = true;
        button.GetComponent<GamepadMainMenu>().enabled = false;
    }
}

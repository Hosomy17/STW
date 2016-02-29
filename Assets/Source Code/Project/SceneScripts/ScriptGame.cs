using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneManagerGame : SceneManagerGeneric
{
    public Text txtPoints;
    private int totalPoints;

    public GameObject mainMenuCamera;
    public GameObject hudCamera;
    public GameObject pauseCamera;
    public GameObject button;
    public GameObject trashCan;


    void Awake()
    {
        pauseCamera.SetActive(false);
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

        trashCan.GetComponent<ClassTrashCan>().lifes = 3;
    }

    private void OnApplicationFocus(bool state)
    {

    }

    private void OnApplicationPause(bool state)
    {
        if (state)
        {
            Pause();
        }
    }
    
    private void OnApplicationQuit()
    {}

    public void Pause()
    {
        Time.timeScale = 0;
        pauseCamera.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Resume()
    {
        pauseCamera.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

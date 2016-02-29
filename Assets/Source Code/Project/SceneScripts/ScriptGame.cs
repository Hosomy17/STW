using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScriptGame : ScriptGeneric
{
    public Text txtPoints;
    private int totalPoints;

    public GameObject button;
    public GameObject trashCan;


    void Awake()
    {
        totalPoints    = 0;
    }

    public void GainPoints(int points)
    {
        totalPoints += points;
        this.txtPoints.text = totalPoints.ToString();
    }

    private void OnApplicationFocus(bool state)
    {

    }

    private void OnApplicationPause(bool state)
    {

    }
    
    private void OnApplicationQuit()
    {
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

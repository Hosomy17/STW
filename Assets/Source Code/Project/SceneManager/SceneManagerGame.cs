using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneManagerGame : SceneManagerGeneric
{
    public Text txtPoints;
    private int totalPoints;

    void Awake()
    {
        totalPoints = 0;
    }

    public void GainPoints(int points)
    {
        totalPoints += points;
        this.txtPoints.text = totalPoints.ToString();
    }
}

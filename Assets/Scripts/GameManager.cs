//using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Score = 0;
    public static int Lives = 3;

    public GUIStyle textStyle;

    private void Awake()
    {
        Score = 0;
        Lives = 3;
    }

    public static void AddScore(int amount)
    {
        Score += amount;
        if (Score >= 500)
        {
            //Score = 0;
            //SpawnInimigo.waitTime = 1.0f;
            SceneLoader.LoadGame();
        }
    }

    public static void LoseLife(int amount)
    {
        Lives -= amount;
        if (Lives <= 0)
        {
            //Lives = 3;
            //SpawnInimigo.waitTime = 1.0f;
            SceneLoader.LoadGame();
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 40), "Score: " + Score, textStyle);
        GUI.Label(new Rect(Screen.width - 140, 20, 120, 40), "Lives: " + Lives, textStyle);
    }
}

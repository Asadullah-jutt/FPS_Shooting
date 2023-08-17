using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreshow : MonoBehaviour
{
    // Start is called before the first frame update

    public Text score;
    public Text highscore;

    private void Start()
    {
        Debug.LogError(PlayerPrefs.GetInt("newScore"));

        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
        // PlayerPrefs.HasKey("HighScore");
        UpdateScore();

    }
    public void UpdateScore()
    {
        int getscore = PlayerPrefs.GetInt("newScore");
        if (!PlayerPrefs.HasKey("newScore"))
        {
            highscore.text = "NO SCORE";
            return;
        }
        score.text = PlayerPrefs.GetInt("newScore").ToString();
        if (getscore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", getscore);
            highscore.text = getscore.ToString();
        }


    }


}


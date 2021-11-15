using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoremanager : MonoBehaviour
{
    public Text HighScore2;
    public Text HighScore3;
    public Text HighScore4;
    public Text HighScore5;
    public Text HighScore6;
    public Text HighScore7;
    public Text HighScore8;
    public Text HighScore9;
    public Text HighScoreAll;

    // Update is called once per frame
    void Update()
    {
        HighScore2.text = PlayerPrefs.GetInt("Score2").ToString();
        HighScore3.text = PlayerPrefs.GetInt("Score3").ToString();
        HighScore4.text = PlayerPrefs.GetInt("Score4").ToString();
        HighScore5.text = PlayerPrefs.GetInt("Score5").ToString();
        HighScore6.text = PlayerPrefs.GetInt("Score6").ToString();
        HighScore7.text = PlayerPrefs.GetInt("Score7").ToString();
        HighScore8.text = PlayerPrefs.GetInt("Score8").ToString();
        HighScore9.text = PlayerPrefs.GetInt("Score9").ToString();
        HighScoreAll.text = PlayerPrefs.GetInt("Score1").ToString();
    }
}

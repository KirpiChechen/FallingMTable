using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{
    public Text scoreText;
    private int score;

    private int currentTable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int.TryParse(scoreText.text, out score);

        currentTable = PlayerPrefs.GetInt("From");

        if (score > PlayerPrefs.GetInt("Score" + currentTable.ToString()))
        {
            PlayerPrefs.SetInt("Score" + currentTable.ToString(), score);
        }
    }
}

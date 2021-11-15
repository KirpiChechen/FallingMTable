using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public OperationManager manager;
    public OperationTimer timer;

    [SerializeField]
    private float score;

    private float plusOne;

    private float point;

    private float levellevel;

    public Slider level;
    private int levelInt;
    public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Score", 0);
        score = PlayerPrefs.GetFloat("Score");
        level.value = PlayerPrefs.GetFloat("LevelLevel" + PlayerPrefs.GetInt("From").ToString());
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = PlayerPrefs.GetInt("Level" + PlayerPrefs.GetInt("From").ToString()).ToString();
        
        if (PlayerPrefs.GetFloat("Score") > score)
        {
            score = PlayerPrefs.GetFloat("Score");

            plusOne = PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString());
            plusOne += 1;
            PlayerPrefs.SetFloat(PlayerPrefs.GetInt("From").ToString(), plusOne);

            levellevel = PlayerPrefs.GetFloat("LevelLevel" + PlayerPrefs.GetInt("From").ToString());
            levellevel += point;
            PlayerPrefs.SetFloat("LevelLevel" + PlayerPrefs.GetInt("From").ToString(), levellevel);

            level.value = PlayerPrefs.GetFloat("LevelLevel" + PlayerPrefs.GetInt("From").ToString());
        }
        

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) < 20f)
        {
            manager.fallTime = 1f;
            timer.operationDelay = 4f;
            point = 1f / 20f;
        }

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) > 20f && PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) < 60f)
        {
            manager.fallTime = 1.2f;
            timer.operationDelay = 3.5f;
            point = 1f / 40f;
        }

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) > 60f && PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) < 120f)
        {
            manager.fallTime = 1.4f;
            timer.operationDelay = 3f;
            point = 1f / 60f;
  
        }

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) > 120f && PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) < 200f)
        {
            manager.fallTime = 1.6f;
            timer.operationDelay = 2.5f;
            point = 1f / 80f;
        }

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) > 200f && PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) < 300f)
        {
            manager.fallTime = 1.8f;
            timer.operationDelay = 2f;
            point = 1f / 100f;
        }

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetInt("From").ToString()) > 420f)
        {
            manager.fallTime = 2f;
            timer.operationDelay = 1.5f;
            point = 1f / 120f;
        }

        if (PlayerPrefs.GetFloat("LevelLevel" + PlayerPrefs.GetInt("From").ToString()) >= 1)
        {
            PlayerPrefs.SetFloat("LevelLevel" + PlayerPrefs.GetInt("From").ToString(), 0);
            levelInt = PlayerPrefs.GetInt("Level" + PlayerPrefs.GetInt("From").ToString());
            levelInt += 1;
            PlayerPrefs.SetInt("Level" + PlayerPrefs.GetInt("From").ToString(), levelInt);
        }
    } //class Updtae
}

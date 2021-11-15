using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public GameObject languageSetting;

    public SpriteRenderer bg;

    public Image trainingButton;
    public Image learningButton;
    public Image exitButton;

    public SpriteRenderer help;

    public Image closeButton;

    [Header("BG")]
    public Sprite kgBG;
    public Sprite ruBG;
    public Sprite engBG;

    [Header("TrainingButtons")]
    public Sprite kgTrainingButton;
    public Sprite ruTrainingButton;
    public Sprite engTrainingButton;

    [Header("LearningButtons")]
    public Sprite kgLearningButton;
    public Sprite ruLearningButton;
    public Sprite engLearningButton;

    [Header("Help")]
    public Sprite kgHelp;
    public Sprite ruHelp;
    public Sprite engHelp;

    [Header("Exit")]
    public Sprite kgExit;
    public Sprite ruExit;
    public Sprite engExit;

    [Header("Close")]
    public Sprite kgClose;
    public Sprite ruClose;
    public Sprite engClose;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("Language") == "")
        {
            languageSetting.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("Language") == "KG")
        {
            bg.sprite = kgBG;
            trainingButton.sprite = kgTrainingButton;
            learningButton.sprite = kgLearningButton;
            exitButton.sprite = kgExit;
            help.sprite = kgHelp;
            closeButton.sprite = kgClose;
        }

        else if (PlayerPrefs.GetString("Language") == "RU")
        {
            bg.sprite = ruBG;
            trainingButton.sprite = ruTrainingButton;
            learningButton.sprite = ruLearningButton;
            exitButton.sprite = ruExit;
            help.sprite = ruHelp;
            closeButton.sprite = ruClose;
        }

        else if (PlayerPrefs.GetString("Language") == "ENG")
        {
            bg.sprite = engBG;
            trainingButton.sprite = engTrainingButton;
            learningButton.sprite = engLearningButton;
            exitButton.sprite = engExit;
            help.sprite = engHelp;
            closeButton.sprite = engClose;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    } //class Update
}

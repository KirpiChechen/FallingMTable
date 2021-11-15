using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDownScript : MonoBehaviour
{
    public List<GameObject> arrows;
    public GameObject languageSettings;

    public GameObject help;

    public GameObject highScore;

    private void Start()
    {
        if (PlayerPrefs.GetInt("From") == 0)
        {
            PlayerPrefs.SetInt("From", 2);
            PlayerPrefs.SetInt("Until", 3);
            arrows[0].SetActive(true);
            PlayerPrefs.SetInt("CurrentArrow", 0);
        }

        arrows[PlayerPrefs.GetInt("CurrentArrow")].SetActive(true);
    }

    public void ChooseTable(int value)
    {
        if (value <= 9)
        {
            arrows[PlayerPrefs.GetInt("CurrentArrow")].SetActive(false);
            arrows[value - 2].SetActive(true);
            PlayerPrefs.SetInt("CurrentArrow", value - 2);

            PlayerPrefs.SetInt("From", value);
            PlayerPrefs.SetInt("Until", value + 1);
        }

        else
        {
            arrows[PlayerPrefs.GetInt("CurrentArrow")].SetActive(false);
            arrows[value - 2].SetActive(true);
            PlayerPrefs.SetInt("CurrentArrow", value - 2);

            PlayerPrefs.SetInt("From", 1);
            PlayerPrefs.SetInt("Until", 10);
        }
    }

    public void StartGame(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void OpenSettings()
    {
        languageSettings.SetActive(true);
        help.SetActive(false);
    }

    public void ChangeLanguage(string language)
    {
        PlayerPrefs.SetString("Language", language);
        languageSettings.SetActive(false);
    }

    public void OpenHelp()
    {
        if (help.activeSelf)
        {
            help.SetActive(false);
        }
        else
        {
            help.SetActive(true);
        }
    }

    public void OpenHighScore()
    {
        highScore.SetActive(true);
        help.SetActive(false);
    }

    public void CloseHighScore()
    {
        highScore.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

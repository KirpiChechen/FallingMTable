using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Text answerText;
    public Text scoreText;

    public string answer;

    public OperationManager manager;

    public Fire fire;

    public GameObject PausPanel;

    public AudioSource destroySound;
    public AudioSource shootSound;

    private void Start()
    {

        if (PlayerPrefs.GetInt("HasPlayed") == 0)
        {
            PlayerPrefs.SetInt("Volume", 1);
            PlayerPrefs.SetInt("HasPlayed", 1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        answerText.text = answer;
        scoreText.text = PlayerPrefs.GetFloat("Score").ToString();

        RemoveOperation();

        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            destroySound.volume = 1;
            shootSound.volume = 1;
        }

        else if (PlayerPrefs.GetInt("Volume") == 0)
        {
            destroySound.volume = 0;
            shootSound.volume = 0;
        }

    }
    public void InputNumber(string number)
    {
        if (answer.Length <= 1)
        {
            answer += number;
        }
        
        //answerText.text = answer;
    }

    public void Remove()
    {
        if (answer != null)
        {
            answer = answer.Remove(answer.Length - 1);
        }
        
    }

    void RemoveOperation()
    {
        if (manager.displays.Count != 0)
        {
            if (manager.displays[0].resultText != null)
            {
                manager.displays[0].resultText.color = Color.white;
            }
            manager.displays[0].operationText.color = Color.white;
            
            if (answer == manager.GetResult())
            {
                fire.Shoot();
                answer = "";
            }

            else if (answer.Length == manager.GetResult().Length && answer != manager.GetResult())
            {
                answer = "";
            }
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        PlayerPrefs.SetInt("Y", 0);
        PausPanel.SetActive(true);
        OperationTimer.gameOver = true;
    }

    public void MainMenu()
    {
        OperationTimer.gameOver = false;
        SceneManager.LoadScene(0);
    }

    public void TurnVolume()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            PlayerPrefs.SetInt("Volume", 0);
        }

        else if (PlayerPrefs.GetInt("Volume") == 0)
        {
            PlayerPrefs.SetInt("Volume", 1);
        }
    }
}

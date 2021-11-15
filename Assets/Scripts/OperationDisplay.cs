using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationDisplay : MonoBehaviour
{
    public Text operationText;

    public Text resultText;

    public float fallTime = .9f;

    private RectTransform rectTransform;

    public GameObject restartButton;

    public GameObject OperationManager;
    private OperationManager manager;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        restartButton = GameObject.FindGameObjectWithTag("RestartButton");
        OperationManager = GameObject.FindGameObjectWithTag("OperationManager");
        manager = OperationManager.GetComponent<OperationManager>();
        
    }

    public void SetOperation(string operation)
    {
        operationText.text = operation;
    }

    private void Update()
    {
        if (resultText != null)
        {
            resultText.text = " = " + manager.GetResult();
        }
        
        transform.Translate(0f, -fallTime * Time.deltaTime, 0f);

        if (rectTransform.anchoredPosition.y <= -75f)
        {
            restartButton.GetComponent<ButtonManager>().PausPanel.SetActive(true);
            PlayerPrefs.SetInt("Y", 0);
            OperationTimer.gameOver = true;
        }

        if (OperationTimer.gameOver)
        {
            manager.RemoveOperation();
        }
    }
}

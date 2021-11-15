using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OperationTimer : MonoBehaviour
{
    public OperationManager manager;

    public float operationDelay = 2.5f;
    private float nextOperationTime;

    public static bool gameOver = false;

    private int count = 1;

    private void Start()
    {
        gameOver = false;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            InfiniteSpawn();
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            TrainingSpawn();
            
            if (count == 20 && manager.operations.Count == 0)
            {
                count = 1;
            }
        }
    }

    private void InfiniteSpawn()
    {
        if (!gameOver)
        {
            if (Time.time >= nextOperationTime)
            {
                nextOperationTime = Time.time + operationDelay;
                manager.AddOperation();

            }
        }
    }

    private void TrainingSpawn()
    {
        if (!gameOver)
        {
            if (count <= 9)
            {
                if (Time.time >= nextOperationTime)
                {
                    nextOperationTime = Time.time + operationDelay;
                    manager.AddTrainingOperation(count);
                    count += 1;

                    if (operationDelay > 1.5f)
                    {
                        operationDelay *= .99f;
                    }
                }
            }

            if (count == 10 && manager.operations.Count == 0)
            {
                StartCoroutine(ShowTestText());
            }
        }

        if (count > 10 && count <= 19)
        {
            if (Time.time >= nextOperationTime)
            {
                manager.AddTrainingOperation(count);
                count += 1;
                nextOperationTime = Time.time + operationDelay;

                if (operationDelay > 1.5f)
                {
                    operationDelay *= .99f;
                }
            }
        }
    }

    IEnumerator ShowTestText()
    {
        yield return new WaitForSeconds(2f);


        count = 11;

        nextOperationTime = Time.time + .1f;
    }

}

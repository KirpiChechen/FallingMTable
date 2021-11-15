using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationGenerator : MonoBehaviour
{
    public static string GetRandomOperation()
    {
        int x = Random.Range(PlayerPrefs.GetInt("From"), PlayerPrefs.GetInt("Until"));
        int y = Random.Range(1, 10);

        string randomOperation = x.ToString() + " * " + y.ToString();
        
        return randomOperation;
    }

    public static string GetSequenceOperation()
    {
        int x = Random.Range(PlayerPrefs.GetInt("From"), PlayerPrefs.GetInt("Until"));
        int y = PlayerPrefs.GetInt("Y");
        y += 1;
        if (y == 10)
        {
            y = 1;
        }
        PlayerPrefs.SetInt("Y", y);

        string randomOperation = x.ToString() + " * " + y.ToString();

        return randomOperation;
    }

}

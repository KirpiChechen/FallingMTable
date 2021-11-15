using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationSpawner : MonoBehaviour
{
    public GameObject operationPrefab;
    public GameObject trainingOperationPrefab;

    public Transform operationCanvas;

    public OperationDisplay SpawnOperation()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 18f);
        GameObject operationObj = Instantiate(operationPrefab, randomPosition, Quaternion.identity, operationCanvas);
        OperationDisplay operationDisplay = operationObj.GetComponent<OperationDisplay>();

        return operationDisplay;
    }

    public OperationDisplay SpawnTrainingOperation()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-4f, 4f), 18f);
        GameObject operationObj = Instantiate(trainingOperationPrefab, randomPosition, Quaternion.identity, operationCanvas);
        OperationDisplay operationDisplay = operationObj.GetComponent<OperationDisplay>();

        return operationDisplay;
    }
}

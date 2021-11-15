using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OperationManager : MonoBehaviour
{
    public List<Operation> operations;

    public List<OperationDisplay> displays;

    private List<string> trainingOperations;

    public OperationSpawner operationSpawner;

    public GameObject explosionEffect;

    public AudioSource destroySound;

    public float fallTime;

    public void AddOperation()
    {
        Operation operation = new Operation(OperationGenerator.GetRandomOperation(), operationSpawner.SpawnOperation());

        operations.Add(operation);
        operation.display.fallTime = fallTime;
        displays.Add(operation.display);
    }

    public void AddTrainingOperation(int count)
    {
        if (count <= 9)
        {
            Operation operation = new Operation(OperationGenerator.GetSequenceOperation(), operationSpawner.SpawnTrainingOperation());

            trainingOperations.Add(operation.operation);

            operations.Add(operation);
            operation.display.fallTime = fallTime;
            displays.Add(operation.display);
        }

        else if (count > 10 && count <= 19)
        {
            Operation operation = new Operation(trainingOperations[0], operationSpawner.SpawnOperation());
            trainingOperations.RemoveAt(0);

            operations.Add(operation);
            operation.display.fallTime = fallTime;
            displays.Add(operation.display);
        }
    }

    public string GetResult()
    {
        int x = 0;
        int y = 0;
        int result;

        foreach (char letter in operations[0].operation)
        {
            int.TryParse(letter.ToString(), out int i);

            if (i != 0)
            {
                if (x == 0)
                {
                    x = i;
                }

                else if (y == 0)
                {
                    y = i;
                }
            }
        }

        result = x * y;

        return result.ToString();
    }

    public void RemoveOperation()
    {
        Instantiate(explosionEffect, displays[0].transform.position, Quaternion.identity);
        destroySound.Play();
        operations.RemoveAt(0);
        Destroy(displays[0].gameObject);
        displays.RemoveAt(0);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Operation
{
    public string operation;

    public OperationDisplay display;

    public Operation(string _operation, OperationDisplay _display)
    {
        operation = _operation;

        display = _display;
        display.SetOperation(operation);
    }
}

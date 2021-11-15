using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public OperationManager manager;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.displays.Count > 0)
        {
            Vector2 direction = manager.displays[0].transform.position - transform.position;
            transform.up = direction;
        }
        
    }
}

using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject _operationManager;
    private OperationManager _manager;

    private float speed = 30f;

    private float score;

    private void Start()
    {
        _operationManager = GameObject.FindGameObjectWithTag("OperationManager");
        _manager = _operationManager.GetComponent<OperationManager>();
    }

    void Update()
    {
        BulletMove();
    }

    private void BulletMove()
    {
        Vector2 direction = _manager.displays[0].transform.position - transform.position;
        transform.up = direction;

        if (_manager.displays.Count != 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, _manager.displays[0].transform.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TrainingOperation")
        {
            score = PlayerPrefs.GetFloat("Score");
            score += 1;
            PlayerPrefs.SetFloat("Score", score);
        }
        
        _manager.RemoveOperation();
        Destroy(gameObject);
    }
}

using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private IScore _score;

    void Start()
    {
        _score = GetComponent<IScore>();
    }

    private void OnCollisionEnter2D()
    {
        Time.timeScale = 0;
    }

    private void OnTriggerEnter2D()
    {
        _score.OperationOfScore();
    }
}

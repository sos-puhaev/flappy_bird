using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        Time.timeScale = 1f;
        _rigidbody2D = GameManager.Instance.RigidBird;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(Vector2.up * 60);
        }
    }
}

using UnityEngine;

public class Pipe : MonoBehaviour
{
    private Camera cmOne;
    private Transform _transform;
    private IEndLineCamera endLineCamera;
    [SerializeField] private float speed = 1;

    void Start()
    {
        cmOne = GameManager.Instance.CameraOne;
        _transform = gameObject.GetComponent<Transform>();
        endLineCamera = new EndLineCamera();
    }

    void Update()
    {
        _transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (endLineCamera.isOutView(gameObject, cmOne, -0.03f))
        {
            _transform.position = new Vector3(
                _transform.position.x * 5.0f, Random.Range(2.5f, -1.5f), 2.0f);
        }
    }
}

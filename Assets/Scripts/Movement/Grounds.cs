using UnityEngine;

public class Grounds : MonoBehaviour
{
    private GameObject grOne;
    private GameObject grTwo;
    private Camera cmOne;
    private Transform _transform;
    private IEndLineCamera endLineCamera;
    private float widthGround;
    [SerializeField] private float speed = 1;

    void Start()
    {
        grOne = GameManager.Instance.GroundOne;
        grTwo = GameManager.Instance.GroundTwo;
        cmOne = GameManager.Instance.CameraOne;

        endLineCamera = new EndLineCamera();
        _transform = GetComponent<Transform>();
        widthGround = grOne.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        _transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (endLineCamera.isOutView(grOne, cmOne, -1.0f))
        {
            grOne.transform.position = new Vector2(grTwo.transform.position.x + widthGround, grOne.transform.position.y);
        }
        if (endLineCamera.isOutView(grTwo, cmOne, -1.0f))
        {
            grTwo.transform.position = new Vector2(grOne.transform.position.x + widthGround, grTwo.transform.position.y);
        }
    }
}

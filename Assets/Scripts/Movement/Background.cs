using UnityEngine;

public class Background : MonoBehaviour
{
    private GameObject bgOne;
    private GameObject bgTwo;
    private Camera mainCamera;
    private IEndLineCamera endLineCamera;
    private Transform _transform;
    private float widthGround;
    [SerializeField] private float speed = 0.4f;


    void Start()
    {
        bgOne = GameManager.Instance.BackgroundOne;
        bgTwo = GameManager.Instance.BackgroundTwo;
        mainCamera = GameManager.Instance.CameraOne;
        endLineCamera = new EndLineCamera();

        _transform = gameObject.GetComponent<Transform>();
        widthGround = bgOne.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        _transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (endLineCamera.isOutView(bgOne, mainCamera, -0.8f))
        {
            bgOne.transform.position = new Vector3(bgTwo.transform.position.x + widthGround, bgOne.transform.position.y, 2.0f);
        }
        if (endLineCamera.isOutView(bgTwo, mainCamera, -0.8f))
        {
            bgTwo.transform.position = new Vector3(bgOne.transform.position.x + widthGround, bgTwo.transform.position.y, 2.0f);
        }
    }
}

using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private GameObject backgroundOne;
    [SerializeField] private GameObject backgroundTwo;
    [SerializeField] private GameObject groundOne;
    [SerializeField] private GameObject groundTwo;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private GameObject bird;
    [SerializeField] private Animator animationBird;
    [SerializeField] private Rigidbody2D _rigidBody2D;


    public GameObject BackgroundOne
    {
        get { return backgroundOne; }
        set { backgroundOne = value; }
    }

    public GameObject BackgroundTwo 
    {
        get { return backgroundTwo; }
        set { BackgroundTwo = value; }
    }

    public GameObject GroundOne
    {
        get { return groundOne; }
        set { groundOne = value; }
    }
    public GameObject GroundTwo
    {
        get { return groundTwo; }
        set { groundTwo = value; }
    }
    public Camera CameraOne
    {
        get { return mainCamera; }
        set { mainCamera = value; }
    }

    public GameObject PipePrefab
    {
        get { return pipePrefab; }
        set { pipePrefab = value; }
    }

    public GameObject Bird
    {
        get { return bird; }
        set { bird = value; }
    }
    public Animator AnimationBird
    {
        get { return animationBird; }
        set { animationBird = value; }
    }

    public Rigidbody2D RigidBird
    {
        get { return _rigidBody2D; }
        set { _rigidBody2D = value; }
    }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}

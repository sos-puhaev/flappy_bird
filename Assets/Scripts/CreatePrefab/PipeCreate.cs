using UnityEngine;

public class PipeCreate : MonoBehaviour
{
    protected GameObject pipePrefab;
    void Start()
    {
        pipePrefab = GameManager.Instance.PipePrefab;
        float position = 11;
        
        for (int i = 0; i <= 2; i++)
        {
            Instantiate(pipePrefab, new Vector3(position, Random.Range(2.8f, -1.5f), 2), Quaternion.identity);
            position += 4f;
        }
    }
}

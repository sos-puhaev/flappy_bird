using UnityEngine;

public interface IEndLineCamera 
{
    bool isOutView(GameObject gameObject, Camera mainCamera, float threshold);
}

using UnityEngine;

public class EndLineCamera : IEndLineCamera
{
    public bool isOutView(GameObject gameObject, Camera mainCamera, float threshold)
    {
        if (gameObject == null || mainCamera == null)
        {
            Debug.LogError("GameObject or Camera is null");
        }
        Vector3 position_object = mainCamera.WorldToViewportPoint(gameObject.transform.position);
        return position_object.x < threshold;
    }
}

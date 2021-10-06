using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLevel3 : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraDistanceBeetweenTarget;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraDistanceBeetweenTarget = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraDistanceBeetweenTarget;
        transform.position = newPosition;
    }
}

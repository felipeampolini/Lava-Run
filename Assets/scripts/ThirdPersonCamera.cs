using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// fonte https://www.youtube.com/watch?v=Ta7v27yySKs

public class ThirdPersonCamera : MonoBehaviour
{

    private const float Y_ANGLE_MIN = -17.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = -5.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivyX = 4.0f;
    private float sensitivyY = 4.0f;

    private void Start(){
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update(){
        if(!Pause.GameIsPaused){
            currentX += Input.GetAxis("Mouse X");
            currentY += Input.GetAxis("Mouse Y");
        }   

        //currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate(){
        Vector3 dir = new Vector3(10, 5, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}

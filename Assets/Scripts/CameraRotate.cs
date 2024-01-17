using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private CameraControl control;
    private float AnglRot;
    [SerializeField] private Transform cam;
    private void CameraRot()
    {
        AnglRot = Mathf.Clamp(AnglRot - control.vector.y, -90, 90);
        cam.localRotation = Quaternion.Euler(AnglRot, 0, 0);
        transform.Rotate(transform.up, control.vector.x);
    }
    private void Update()
    {
        if (control.pressed) { CameraRot(); }
    }
}

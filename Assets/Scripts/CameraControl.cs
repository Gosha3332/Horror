using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private bool pressed = false;
    private Vector2 vector;
    private float sensivity = 3;
    private float AnglRot;
    [SerializeField] private Transform cam;

    public void OnPoiterUP() { pressed = false; }
    public void OnPoiterDOWN() { pressed = true; }
    private void Control()
    {
        if (pressed)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Stationary)
                {
                    vector = Vector2.zero;
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    vector = touch.deltaPosition * sensivity * Time.deltaTime;
                }
            }
        }
    }
    private void CameraRot()
    { 
       AnglRot = Mathf.Clamp(AnglRot - vector.y, -90, 90);
       cam.localRotation = Quaternion.Euler(AnglRot, 0, 0);
       transform.Rotate(transform.up, vector.x);
    }

    private void Update()
    {
        Control();
        if (pressed) { CameraRot(); }
    }
}
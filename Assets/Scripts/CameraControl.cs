using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [HideInInspector] public bool pressed = false;
    [HideInInspector] public Vector2 vector;
    [HideInInspector] private float sensivity = 3;

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
    private void Update()
    {
        Control();
    }
}
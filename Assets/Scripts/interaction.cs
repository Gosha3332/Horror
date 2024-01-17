using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class interaction : MonoBehaviour
{
    private int domashka;
    public void Arm()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            if(hit.collider.GetComponent<DZ>())
            {
                Destroy(GetComponent<DZ>());
                domashka++;        
            }
        }
    }
}

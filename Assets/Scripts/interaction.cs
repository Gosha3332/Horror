using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class interaction : MonoBehaviour
{
    [SerializeField] private DZ destroy;
    private int domashka;
    public void Arm()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            if(hit.collider.GetComponent<DZ>())
            {
                destroy.Object();
                domashka++;        
            }
        }
    }
}

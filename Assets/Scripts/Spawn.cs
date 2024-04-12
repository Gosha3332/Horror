using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private int range;
    [SerializeField] private GameObject Tetrad;
    private void Start()
    {
        range = Random.Range(0,1);
        if(range >= 1) { Instantiate(Tetrad); }
        Tetrad.transform.position = transform.position;
    }


}

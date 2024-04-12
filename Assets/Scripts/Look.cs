using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] private Transform _Player;
    private void look() { transform.LookAt(transform.position); }
}

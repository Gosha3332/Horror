using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Vrag>())
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

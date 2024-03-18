using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource m_Clip;
    private Vector3 OldPosition;
    private void Start()
    {
        StartCoroutine(sound());
        OldPosition = transform.position;
    }
    private IEnumerator sound()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            if (OldPosition != transform.position)
            {                
                m_Clip.Play();
                OldPosition = transform.position;
            }
            else { m_Clip.Stop(); }           
        }
    }
}

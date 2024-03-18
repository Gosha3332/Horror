using UnityEngine;
using UnityEngine.UI;


public class interaction : MonoBehaviour
{
    private int _domashka;
    [SerializeField] private AudioSource _sourse;
    [SerializeField] private DZ dz;
    [SerializeField] private Text _TextDomashka;
    private void FixedUpdate()
    {
        _TextDomashka.text= _domashka.ToString();
    }
    public void Arm()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            if(dz = hit.collider.GetComponent<DZ>())
            {                
                _sourse.Play();
                dz.Ydolit();
                _domashka++;        
            }
        }
    }
}

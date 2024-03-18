using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Vrag : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private GameObject[] obj;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(obj[0].transform.position);
        StartCoroutine(hodit());
    }
    private IEnumerator hodit()
    {
        while (true)
        {
            if (_agent.remainingDistance > _agent.stoppingDistance)
            {
                yield return new WaitForSeconds(1);
                continue;
            }
            for (int i = 1; i < obj.Length; i++)
            {

                if (_agent.remainingDistance <= _agent.stoppingDistance)
                {
                    yield return new WaitForSeconds(2);
                    _agent.SetDestination(obj[i++].transform.position);
                }
            }
        }
    }
}

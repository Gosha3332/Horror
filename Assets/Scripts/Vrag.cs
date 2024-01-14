using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Vrag : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private GameObject[] obj;
    private Vector3 rasstoanie;
    //[SerializeField] private Transform player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(obj[0].transform.position);
        StartCoroutine(hodit());
    }
    private IEnumerator hodit()
    {
        while (true)
        {
            if (agent.remainingDistance > agent.stoppingDistance)
            {
                yield return new WaitForSeconds(1);
                continue;
            }
            for (int i = 1; i < obj.Length; i++)
            {

                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    yield return new WaitForSeconds(2);
                    agent.SetDestination(obj[i++].transform.position);
                }
            }
        }

        //if (rasstoanie >= 6f) { }
    }
}

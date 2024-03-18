using UnityEngine;
using UnityEngine.AI;

public class harassment : MonoBehaviour
{
    private NavMeshAgent _agent;
    private float distance;
    [SerializeField] private Transform Player;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        distance = Vector3.Distance(Player.position, transform.position);
    }

    void Update()
    {
        if (distance <= 7 ) { _agent.SetDestination(Player.position); }
    }
}

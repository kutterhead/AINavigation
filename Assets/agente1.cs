using UnityEngine;
using UnityEngine.AI;

public class agente1 : MonoBehaviour
{
    public NavMeshAgent agent1;
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    [SerializeField] float distanceThreshold = 1f; // Distance threshold to switch targets
    bool flag = false;
    void Start()
    {
        // Set the initial target
        if (flag)
        {
            agent1.SetDestination(target2.position);
        }
        else
        {
            agent1.SetDestination(target1.position);
        }
    }

    void Update()
    {
        // Switch targets when the distance to the current target is less than the threshold

        //agent1.remainingDistance; no lo usamos, puede ser impreciso e inestable.

        if (Vector3.Distance(transform.position, agent1.destination) < distanceThreshold)
        {
           
            flag = !flag;
            if (flag)
            {
                agent1.SetDestination(target2.position);
            }
            else
            {
                agent1.SetDestination(target1.position);
            }
        }
    }
}
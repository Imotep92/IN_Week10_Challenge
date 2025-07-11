using UnityEngine;
using UnityEngine.AI;

public class HavesterUnitScript : MonoBehaviour
{
    NavMeshAgent _harvesterAgent;
    Vector3 currentDestination;

    //need a way point manager for the harvester to follow

    //acces to cropspawn manager to plant crops


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _harvesterAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        HarvesterMovement();
    }

    protected void HarvesterMovement()
    {
        if (Vector3.Distance(currentDestination, transform.position) < 0.5)
        {
            currentDestination = transform.position + (new Vector3(Random.Range(-4, 4), 0, Random.Range(-4, 4)));
        }

        _harvesterAgent.destination = currentDestination;
    }
}

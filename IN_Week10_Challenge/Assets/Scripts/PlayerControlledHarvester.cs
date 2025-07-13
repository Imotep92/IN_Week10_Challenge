using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerControlledHarvester : MonoBehaviour
{
    public static PlayerControlledHarvester _playerControlledHarvester; // Reference to HarvesterUnitScript script


    [SerializeField] private Camera cam;
    [SerializeField] private NavMeshAgent _playerHarvesterAgent;

    void Awake()
    {
        _playerControlledHarvester = this;  // This is PlayerControlledHarvester script
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                _playerHarvesterAgent.SetDestination(hit.point);
            }
        }
    }

}

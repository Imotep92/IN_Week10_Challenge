using UnityEngine;
using UnityEngine.AI;

public class TractorUnitScript : MonoBehaviour
{
    public static TractorUnitScript _tractorUnit; // Reference to HarvesterUnitScript script
    NavMeshAgent _tractorAgent; // NavMesh Agent on the harvester unit
    Vector3 _currentDestination; // the current destination of the harvester unit
    Bounds _bndGround; // boundaries of the NavMesh Surface


    float randomX, randomZ; // random x axis and z axis point on the ground

    
    void Awake()
    {
        _tractorUnit = this;  // This is TractorUnitScript script
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // _cropSpawn = GetComponent<CropSpawnManager>();  // Access to CropSpawnManger.cs

        _tractorAgent = GetComponent<NavMeshAgent>(); // Getting the NavMesh component on the harvester unit
        _bndGround = GameObject.Find("Ground").GetComponent<Renderer>().bounds; // Getting the boundaries of the renderer component on the ground
    }

    // Update is called once per frame
    void Update()
    {
 
        TractorDestination(); // Harvester unit picks a destination
       
    }

    protected void TractorDestination()
    {
        if (_tractorAgent.hasPath == false) // .hasPath is false
        {
            CropSpawnManager._cropSpawn.InstantiateCrop(); // spawn a crop

            randomX = Random.Range(_bndGround.min.x, _bndGround.max.x); // Random x
            randomZ = Random.Range(_bndGround.min.z, _bndGround.max.z);  // Random z

            _currentDestination = new Vector3(randomX, 0, randomZ); // Current Destination is (randomX, 0, randomZ)
        }
        
        _tractorAgent.destination = _currentDestination; // Harvester moves to position
    }

}

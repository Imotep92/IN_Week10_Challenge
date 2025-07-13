using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class CropSpawnManager : MonoBehaviour
{
    public static CropSpawnManager _cropSpawn; // Reference to CropSpawnManager script

    public GameObject[] _cropPrefabs, _vegPrefabs; // Arrays for crops and vegetables

    [SerializeField] int pointValue = 1;

    private GameObject vegPrefab;

    //private bool hasCropSpawned;

    private void Awake()
    {
        _cropSpawn = this;
    }

    private void Update()
    { }



    public void InstantiateCrop()
    {
        int vegIndex = Random.Range(0, _vegPrefabs.Length); // veg Array

        vegPrefab = Instantiate(_vegPrefabs[vegIndex], transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0)); // Spawn vegetables
        Debug.Log("Harvester Unit has planted {vegPrefab._TomatoPrefab}");

        
        Destroy(vegPrefab, 3f); // Spawn vegetables
        Debug.Log("{vegPrefab._TomatoPrefab} has overripened");
    }

     private void OnTriggerEnter(Collider other)
    {
        if (vegPrefab.gameObject.CompareTag("Player"))
        {
            GameObject.Find("GameManager").GetComponent<GameManagerScript>().score++;
            Destroy(vegPrefab.gameObject);
        }
    }

    /*    private void OnTriggerEnter(Collider other)
    {
        //only tag.enemy gets destroyed
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject.Find("Hayley_Bales").GetComponent<playerController>().score++;
            Debug.Log(GameObject.Find("Hayley_Bales").GetComponent<playerController>().score);

            Destroy(gameObject);
            Destroy(other.gameObject);
        }*/
}

using UnityEngine;

public class ReplaceCropScript : MonoBehaviour
{
    public static ReplaceCropScript _replaceCrop; // Reference to ReplaceCropScript script

    private GameObject _tomatoCropPrefab;

    [SerializeField] GameObject _tomatoPrefab;


    private void Awake()
    {
        _replaceCrop = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _tomatoCropPrefab = GameObject.Find("TomatoCropPrefab");
        _tomatoPrefab = GameObject.Find("TomatoPrefab");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Replace(_tomatoCropPrefab, _tomatoPrefab);
        }
    }
    
     void Replace(GameObject _tomatoCropPrefab, GameObject _tomatoPrefab)
{

        Instantiate(_tomatoPrefab, _tomatoCropPrefab.transform.position, Quaternion.identity);
        Destroy(_tomatoCropPrefab);

    }
}

using UnityEngine;
using UnityEngine.UI;

public class SpawnButton : MonoBehaviour
{
    public Button button;
    public GameObject prefab;
    public Transform destination;

    private void Start()
    {
        // Attach the method to the button's onClick event
        button.onClick.AddListener(SpawnPrefab);
    }

    private void SpawnPrefab()
    {
        // Instantiate the prefab at the destination position and rotation
        GameObject spawnedPrefab = Instantiate(prefab, destination.position, destination.rotation);
        // Set the parent of the spawned prefab to the destination object
        spawnedPrefab.transform.SetParent(destination);
    }
}
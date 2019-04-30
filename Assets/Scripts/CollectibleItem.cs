using UnityEngine;

public class CollectibleItem : MonoBehaviour {
    [SerializeField] private string itemName;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected " + itemName);
        Destroy(this.gameObject);
    }

}

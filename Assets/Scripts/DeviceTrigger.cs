using UnityEngine;

public class DeviceTrigger : MonoBehaviour {
    [SerializeField] private GameObject[] targets;

    void OnTriggerEnter(Collider other)
    {
        foreach(GameObject target in targets) {
            target.SendMessage("Activate");
        }

    }
    void OnTriggerExit(Collider other)
    {
        foreach (GameObject target in targets)
        {
            target.SendMessage("Deactivate");
        }
    }
}

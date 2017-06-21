using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int ItemId;

    void OnTriggerEnter(Collider other)
    {
        Debug.LogError("OnTriggerEnter");
    }
}

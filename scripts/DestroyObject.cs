using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Ødelegger game objektet.
        Destroy(gameObject);
    }

}

using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �delegger game objektet.
        Destroy(gameObject);
    }

}

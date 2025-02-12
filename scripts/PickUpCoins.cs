using UnityEngine;

public class PickUpCoins : MonoBehaviour
{
    private AudioSource audioSource;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        meshRenderer.enabled = false;
        Destroy(gameObject, audioSource.clip.length);
    }
}

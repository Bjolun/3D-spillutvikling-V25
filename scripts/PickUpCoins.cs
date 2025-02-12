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
        // Spiller av lydklippet som hører til Audio Source'n vår
        audioSource.Play();
        // Skru av MeshRenderer komponenten slik at det ser ut som myntene blir fjernet umiddelbart
        meshRenderer.enabled = false;
        // Sletter dette game objektet en bestemt tid, i dette tilfelle etter lengden på lydklippet vårt.
        Destroy(gameObject, audioSource.clip.length);
    }
}

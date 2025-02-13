using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    // En statisk instans vi kan nå fra alle andre klasser i spillet vårt.
    public static AudioManager instance { get; private set; }

    // Referanse til en AudioSource komponent
    private AudioSource audioSource;

    // Lydklippene for hvert level lagres i en Array
    [SerializeField] private AudioClip[] levelAudioClips;
    // Lydklippet for det hemmelige rommet
    [SerializeField] private AudioClip secretRoomAudio;

    private void Awake()
    {
        // Sikrer at det kun er en instans av AudioManager i spillet
        if (instance == null)
        {
            instance = this;
        } else
        {
            // Hvis det allerede finnes en instans, destrueres denne for å unngå duplikater
            Destroy(gameObject);
        }

        // Sier hvilken AudioSource som skal spille av lyd
        audioSource = GetComponent<AudioSource>();

        // Gjør at objektet ikke blir destruert ved loading av scener.
        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        // Sier hvilket klipp vi vil spille på start
        audioSource.clip = levelAudioClips[0];
        // spiller lydklippet
        audioSource.Play();
    }

    public void ChangeLevelTrack(int trackIndex)
    {
        // Setter lydklippet til å være det som er på posisjonen til trackIndex i arrayen vår som holder på lydklipp.
        audioSource.clip = levelAudioClips[trackIndex];
        // Spiller av lyden.
        audioSource.Play();
    }

    public void PlaySecretTrack()
    {
        // Setter lydklippet til å være lik det som ligger i secretRoomAudio
        audioSource.clip = secretRoomAudio;
        // Spiller av lyden.
        audioSource.Play();
    }
}

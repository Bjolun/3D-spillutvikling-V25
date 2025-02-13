using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    // En statisk instans vi kan n� fra alle andre klasser i spillet v�rt.
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
            // Hvis det allerede finnes en instans, destrueres denne for � unng� duplikater
            Destroy(gameObject);
        }

        // Sier hvilken AudioSource som skal spille av lyd
        audioSource = GetComponent<AudioSource>();

        // Gj�r at objektet ikke blir destruert ved loading av scener.
        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        // Sier hvilket klipp vi vil spille p� start
        audioSource.clip = levelAudioClips[0];
        // spiller lydklippet
        audioSource.Play();
    }

    public void ChangeLevelTrack(int trackIndex)
    {
        // Setter lydklippet til � v�re det som er p� posisjonen til trackIndex i arrayen v�r som holder p� lydklipp.
        audioSource.clip = levelAudioClips[trackIndex];
        // Spiller av lyden.
        audioSource.Play();
    }

    public void PlaySecretTrack()
    {
        // Setter lydklippet til � v�re lik det som ligger i secretRoomAudio
        audioSource.clip = secretRoomAudio;
        // Spiller av lyden.
        audioSource.Play();
    }
}

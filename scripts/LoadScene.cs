using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        // Holder indeksposisjonen til scenen som er aktiv
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        
        // Holder antall scener -2 (mer om dette i forelesning) slik at vi 
        // kan sjekke om vi er p� siste level i spillet eller ikke
        int lastSceneNumber = SceneManager.sceneCountInBuildSettings - 2;

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Hvis vi treffer noe med obstacle-taggen loader vi scenen
            // vi allerede er i p� nytt.
            SceneManager.LoadScene(currentScene);
        }

        if (collision.gameObject.CompareTag("Finish") && currentScene != lastSceneNumber)
        {
            // hvis if-statement'en over er true �nsker vi � loade neste level.
            // Vi lager derfor en variabel som holder p� sceneindeksen vi er p� n� +1 (neste index)
            int nextScene = currentScene + 1;
            // Loader scene p� indeksposisjonen som blir holdt i nextScene
            SceneManager.LoadScene(nextScene);
            // Spiller av lydklippet for neste scene. Se AudioManager.cs 
            AudioManager.instance.ChangeLevelTrack(nextScene);
        }
        // Hvis vi treffer noe med taggen Finish og er p� siste niv� blir denne true
        else if (collision.gameObject.CompareTag("Finish") && currentScene == lastSceneNumber)
        {
            // Vi gratulerer spilleren med � ha klart alle levlene.
            Debug.Log("Du har klart alle levlene!");
        }
    }
}

using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Range(0f, 1f)]
    public float volume = 1.0f;  // Standardlautst�rke

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Verhindert das Zerst�ren bei Szenenwechsel
        }
        else
        {
            Destroy(gameObject);  // Stellt sicher, dass nur eine Instanz existiert
        }
    }

    public void SetVolume(float newVolume)
    {
        volume = newVolume;
        // Setze die Lautst�rke f�r alle AudioSources
        AudioListener.volume = volume;
    }
}


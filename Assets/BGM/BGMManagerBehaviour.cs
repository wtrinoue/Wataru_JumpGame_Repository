using UnityEngine;

public class BGMManagerBehaviour : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        // 同じオブジェクトにあるAudioSourceを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        audioSource.loop = true; // ループさせたい場合
        audioSource.Play();
    }
}

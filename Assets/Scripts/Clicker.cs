using UnityEngine;

public class Clicker : MonoBehaviour
{
    public static float num = 1;
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseUp()
    {
        GameManager.count += num;
        GameManager.totalScore += num;
        audioSource.PlayOneShot(sound1);
        Debug.Log(GameManager.totalScore);
    }

    public static void BounsTime()
    {
        num = num * 2.0f;
    }

    public static void EndTime()
    {
        num = num * 1.0f;
    }
}

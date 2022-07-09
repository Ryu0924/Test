using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public GameObject obj;
    public static float time;
    public static float i;
    public static float bounsTime;
    public static float lowTime;
    public static float highTime;

    void Start()
    {
        time = 1.0f;
        lowTime = 10.0f;
        highTime = 20.0f;
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 5.0f && 1.0f <= time)
        {
            obj.SetActive(true);
        }
        else if (time < 1.0f)
        {
            obj.SetActive(false);
            i = Random.Range(lowTime, highTime);
            time = i;
        }
        if (0.0f < bounsTime)
        {
            Clicker.BounsTime();
            Pickaxe.BounsTime();
            Hunmer.BounsTime();
            Drill.BounsTime();
            Machine.BounsTime();
            Plant.BounsTime();
            God.BounsTime();
            bounsTime -= Time.deltaTime;
        }
        else if(0.0f >= bounsTime)
        {
            Clicker.EndTime();
            Pickaxe.EndTime();
            Hunmer.EndTime();
            Drill.EndTime();
            Machine.EndTime();
            Plant.EndTime();
            God.EndTime();
            bounsTime = 0.0f;
        }
    }

    public static void Bouns()
    {
        i = Random.Range(lowTime, highTime);
        time = i;
        bounsTime = 10.0f;
    }

    public static void Ascend()
    {
        lowTime *= 0.9f;
        highTime *= 0.9f;
    }
}

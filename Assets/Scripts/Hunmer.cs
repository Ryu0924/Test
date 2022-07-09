using UnityEngine;
using TMPro;

public class Hunmer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hunmerCount;
    [SerializeField] TextMeshProUGUI hunmerPrice;
    public static float incValue = 0.5f;
    public static int hum = 0;
    public static float cps;

    void Update()
    {
        cps = hum * incValue;
        GameManager.count += Time.deltaTime * incValue * hum;
        GameManager.totalScore += Time.deltaTime * incValue * hum;
        hunmerCount.text = "Hunmer:" + hum.ToString();
        hunmerPrice.text = "$" + ButtonClick.hpri.ToString("F0");
        ItemColor();
    }

    public void HunmerClick()
    {
        hunmerPrice.text = ButtonClick.hpri.ToString("F0");
    }

    public void ItemColor()
    {
        if (GameManager.count < ButtonClick.hpri)
        {
            hunmerCount.color = Color.red;
        }
        else
        {
            hunmerCount.color = Color.black;
        }
    }

    public static void BounsTime()
    {
        incValue = 1.0f;
    }

    public static void EndTime()
    {
        incValue = 0.5f;
    }
}


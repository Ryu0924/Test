using UnityEngine;
using TMPro;

public class God : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI godCount;
    [SerializeField] TextMeshProUGUI godPrice;
    public static float incValue = 100.0f;
    public static int god = 0;
    public static float cps;

    void Update()
    {
        cps = god * incValue;
        GameManager.count += Time.deltaTime * incValue * god;
        GameManager.totalScore += Time.deltaTime * incValue * god;
        godCount.text = "God of Mining:" + god.ToString();
        godPrice.text = "$" + ButtonClick.gpri.ToString("F0");
        ItemColor();
    }

    public void GodClick()
    {
        godPrice.text = ButtonClick.gpri.ToString("F0");
    }

    public void ItemColor()
    {
        if (GameManager.count < ButtonClick.gpri)
        {
            godCount.color = Color.red;
        }
        else
        {
            godCount.color = Color.black;
        }
    }

    public static void BounsTime()
    {
        incValue = 200.0f;
    }

    public static void EndTime()
    {
        incValue = 100.0f;
    }
}

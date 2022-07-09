using UnityEngine;
using TMPro;

public class Drill : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI drillCount;
    [SerializeField] TextMeshProUGUI drillPrice;
    public static float incValue = 1.0f;
    public static int dri = 0;
    public static float cps;

    void Update()
    {
        cps = dri * incValue;
        GameManager.count += Time.deltaTime * incValue * dri;
        GameManager.totalScore += Time.deltaTime * incValue * dri;
        drillCount.text = "Drill:" + dri.ToString();
        drillPrice.text = "$" + ButtonClick.dpri.ToString("F0");
        ItemColor();
    }

    public void DrillClick()
    {
        drillPrice.text = ButtonClick.dpri.ToString("F0");
    }

    public void ItemColor()
    {
        if (GameManager.count < ButtonClick.dpri)
        {
            drillCount.color = Color.red;
        }
        else
        {
            drillCount.color = Color.black;
        }
    }

    public static void BounsTime()
    {
        incValue = 2.0f;
    }

    public static void EndTime()
    {
        incValue = 1.0f;
    }
}

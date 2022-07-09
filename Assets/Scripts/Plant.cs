using UnityEngine;
using TMPro;

public class Plant : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI plantCount;
    [SerializeField] TextMeshProUGUI plantPrice;
    public static float incValue = 10.0f;
    public static int pln = 0;
    public static float cps;

    void Update()
    {
        cps = pln * incValue;
        GameManager.count += Time.deltaTime * incValue * pln;
        GameManager.totalScore += Time.deltaTime * incValue * pln;
        plantCount.text = "Plant:" + pln.ToString();
        plantPrice.text = "$" + ButtonClick.plpri.ToString("F0");
        ItemColor();
    }

    public void PlantClick()
    {
        plantPrice.text = ButtonClick.dpri.ToString("F0");
    }

    public void ItemColor()
    {
        if (GameManager.count < ButtonClick.plpri)
        {
            plantCount.color = Color.red;
        }
        else
        {
            plantCount.color = Color.black;
        }
    }

    public static void BounsTime()
    {
        incValue = 20.0f;
    }

    public static void EndTime()
    {
        incValue = 10.0f;
    }
}

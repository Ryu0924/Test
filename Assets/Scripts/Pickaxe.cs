using UnityEngine;
using TMPro;

public class Pickaxe : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pickaxeCount;
    [SerializeField] TextMeshProUGUI pickaxePrice;
    [SerializeField] GameObject pickaxe;

    public static float incValue = 0.1f;
    public static int pick = 0;
    public static float cps;

    void Update()
    {
        cps = pick * incValue;
        GameManager.count += Time.deltaTime * incValue * pick;
        GameManager.totalScore += Time.deltaTime * incValue * pick;
        pickaxeCount.text = "Pickaxe:" + pick.ToString();
        pickaxePrice.text = "$" + ButtonClick.ppri.ToString("F0");
        for(int i = 0; i < pickaxeCount.text.Length; i++)
        {
            pickaxe = GetComponent<GameObject>();
        }
        ItemColor();
    }

    public void PickaxeClick()
    {
        pickaxePrice.text = ButtonClick.ppri.ToString("F0");
    }

    public void ItemColor()
    {
        if (GameManager.count < ButtonClick.ppri)
        {
            pickaxeCount.color = Color.red;
        }
        else
        {
            pickaxeCount.color = Color.black;
        }
    }

    public static void BounsTime()
    {
        incValue = 0.2f;
    }

    public static void EndTime()
    {
        incValue = 0.1f;
    }
}


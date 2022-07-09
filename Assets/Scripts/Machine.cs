using UnityEngine;
using TMPro;

public class Machine : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI machineCount;
    [SerializeField] TextMeshProUGUI machinePrice;
    public static float incValue = 5.0f;
    public static int mac = 0;
    public static float cps;

    void Update()
    {
        cps = mac * incValue;
        GameManager.count += Time.deltaTime * incValue * mac;
        GameManager.totalScore += Time.deltaTime * incValue * mac;
        machineCount.text = "Machine:" + mac.ToString();
        machinePrice.text = "$" + ButtonClick.mpri.ToString("F0");
        ItemColor();
    }

    public void MachineClick()
    {
        machinePrice.text = ButtonClick.dpri.ToString("F0");
    }

    public void ItemColor()
    {
        if (GameManager.count < ButtonClick.mpri)
        {
            machineCount.color = Color.red;
        }
        else
        {
            machineCount.color = Color.black;
        }
    }

    public static void BounsTime()
    {
        incValue = 10.0f;
    }

    public static void EndTime()
    {
        incValue = 5.0f;
    }
}

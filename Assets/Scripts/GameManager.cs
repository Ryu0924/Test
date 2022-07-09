using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static float count = 0.0f;
    public static float totalScore = 0.0f;
    public float totalCps;

    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] TextMeshProUGUI totalCpsText;

    private void Start()
    {
        totalScore = 1000.0f;
    }

    void Update()
    {
        countText.text = "$" + count.ToString("F1");
        totalCps = Pickaxe.cps + Hunmer.cps + Drill.cps + Machine.cps + Plant.cps + God.cps;
        totalCpsText.text = "per second:" + totalCps.ToString("F1");
    }
}

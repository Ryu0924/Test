using UnityEngine;
using TMPro;

public class ResetManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _ascendCount;
    [SerializeField] TextMeshProUGUI _ascend;
    [SerializeField] TextMeshProUGUI _anascend;
    float ascendCount;

    public void Restart()
    {
        if (GameManager.totalScore > 1000)
        {
            ascendCount += 1;
            PlayerPrefs.DeleteAll();
            GameManager.count = 0;
            Clicker.num = 1;
            Pickaxe.pick = 0;
            Hunmer.hum = 0;
            Drill.dri = 0;
            Machine.mac = 0;
            Plant.pln = 0;
            God.god = 0;
            ButtonClick.ppri = 15.0f;
            ButtonClick.pnum = 1.0f;
            ButtonClick.hpri = 65.0f;
            ButtonClick.hnum = 1.0f;
            ButtonClick.dpri = 150.0f;
            ButtonClick.dnum = 1.0f;
            ButtonClick.mpri = 625.0f;
            ButtonClick.mnum = 1.0f;
            ButtonClick.plpri = 3665.0f;
            ButtonClick.plnum = 1.0f;
            ButtonClick.gpri = 15555.0f;
            ButtonClick.gnum = 1.0f;
            _anascend.text = "";
            _ascend.text = "Reincarnation!";
            _ascendCount.text = "ReincarnationÅ~" + ascendCount.ToString();
            RandomManager.Ascend();
            GameManager.totalScore -= 1000.0f;
        }
        else
        {
            _ascend.text = "";
            _anascend.text = "Failure...";
        }
    }
}

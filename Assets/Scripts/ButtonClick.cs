using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public static float pnum, hnum, dnum, mnum, plnum, gnum = 1.0f;
    public static float ppri, hpri, dpri, mpri, plpri, gpri;

    private void Start()
    {
        ppri = 15 * pnum;
        hpri = 65 * hnum;
        dpri = 150 * dnum;
        mpri = 625 * mnum;
        plpri = 3665 * plnum;
        gpri = 15555 * gnum;
    }

    public void PickClick()
    {
        if (ppri <= GameManager.count)
        {
            GameManager.count -= ppri;
            Pickaxe.pick += 1;
            Clicker.num += 0.1f;
            pnum *= 1.5f;
            ppri = 15 * pnum;
        }
        else
        {
            Debug.Log("Gold不足");
        }
    }

    public void HumClick()
    {
        if (hpri <= GameManager.count)
        {
            GameManager.count -= hpri;
            Hunmer.hum += 1;
            Clicker.num += 1.0f;
            hnum *= 1.5f;
            hpri = 65 * hnum;
        }
        else
        {
            Debug.Log("Gold不足");
        }
    }

    public void DriClick()
    {
        if (dpri <= GameManager.count)
        {
            GameManager.count -= dpri;
            Drill.dri += 1;
            Clicker.num += 2.0f;
            dnum *= 1.5f;
            dpri = 150 * dnum;
        }
        else
        {
            Debug.Log("Gold不足");
        }
    }

    public void MacClick()
    {
        if (mpri <= GameManager.count)
        {
            GameManager.count -= mpri;
            Machine.mac += 1;
            Clicker.num *= 1.5f;
            mnum *= 1.5f;
            mpri = 625 * mnum;
        }
        else
        {
            Debug.Log("Gold不足");
        }
    }

    public void PlaClick()
    {
        if (plpri <= GameManager.count)
        {
            GameManager.count -= plpri;
            Plant.pln += 1;
            Clicker.num *= 2.0f;
            plnum *= 1.5f;
            plpri = 3665 * plnum;
        }
        else
        {
            Debug.Log("Gold不足");
        }
    }

    public void GodClick()
    {
        if (gpri <= GameManager.count)
        {
            GameManager.count -= gpri;
            God.god += 1;
            Clicker.num *= 3.5f;
            gnum *= 1.5f;
            gpri = 15555 * gnum;
        }
        else
        {
            Debug.Log("Gold不足");
        }
    }
}

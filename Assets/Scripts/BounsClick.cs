using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounsClick : MonoBehaviour
{
    public GameObject obj;

    private void OnMouseUp()
    {
        RandomManager.Bouns();
        obj.SetActive(false);
    }
}

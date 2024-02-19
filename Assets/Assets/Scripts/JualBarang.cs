using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JualBarang : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Destroy(GameObject.Find("ChairBiasa(Clone)"));
        Destroy(GameObject.Find("CPUBiasa(Clone)"));
        Destroy(GameObject.Find("KeyboardBiasa(Clone)"));
        Destroy(GameObject.Find("MonitorBiasa(Clone)"));
        Destroy(GameObject.Find("MouseBiasa(Clone)"));
        Destroy(GameObject.Find("TableBiasa(Clone)"));

        Destroy(GameObject.Find("ChairSultan(Clone)"));
        Destroy(GameObject.Find("CPUSultan(Clone)"));
        Destroy(GameObject.Find("KeyboardSultan(Clone)"));
        Destroy(GameObject.Find("MonitorSultan(Clone)"));
        Destroy(GameObject.Find("MouseSultan(Clone)"));
        Destroy(GameObject.Find("TableSultan(Clone)"));
    }
}

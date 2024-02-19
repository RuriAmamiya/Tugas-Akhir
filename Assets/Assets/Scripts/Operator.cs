using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    public static bool Belanja = false;
    public GameObject OperatorMenuUI;
    public GameObject CrosshairUI;
    public GameObject Camera;
    public GameObject MainUI;
    public GameObject ShopUI;

    public Movement FPC;

    void Start()
    {
        FPC.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Belanja)
            {
                Keluar();
            } 
            else
            {
                PCOperator();
            }
        }
    }

    public void Keluar ()
    {
        OperatorMenuUI.SetActive(false);
        CrosshairUI.SetActive(true);
        Camera.SetActive(false);
        MainUI.SetActive(true);
        ShopUI.SetActive(false);
        Belanja = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FPC.enabled = true;
    }

    void PCOperator ()
    {
        OperatorMenuUI.SetActive(true);
        CrosshairUI.SetActive(false);
        Camera.SetActive(true);
        MainUI.SetActive(false);
        ShopUI.SetActive(true);
        Belanja = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        FPC.enabled = false;
    }
}

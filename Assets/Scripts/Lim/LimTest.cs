using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimTest : MonoBehaviour
{
    private Camera playerCamera;
    private LayerMask structurLayer;

    private void Awake()
    {
        
    }
    private void Update()
    {
        CheckStructur();
    }
    public void CheckStructur()
    {
        RaycastHit hit;
        Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward,out hit,10f,structurLayer);
        SlimeFarm target = hit.transform.GetComponent<SlimeFarm>();
        if(target != null)
        {
            //target.UpgradeUI.SetActive(true);
        }
    }
}

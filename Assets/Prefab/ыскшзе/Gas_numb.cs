using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas_numb : MonoBehaviour
{
    public GameObject gas;
    public Animator animator;
    public bool On_Gaz=false;
    public void Gaz()
    {
        gas.SetActive(On_Gaz);
    }
    public void On()
    {
        On_Gaz = !On_Gaz;
        animator.SetBool("On", On_Gaz);
        Invoke("Gaz", 0.75f);
    }
}

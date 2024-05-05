
using UnityEngine;

public class Anim_script : MonoBehaviour
{
    public Animator animator_lights,fridge;
    private bool anim = false;
    private bool Door_Left =false,Door_Right=false,Shelf1=false,Shelf2=false;
    public GameObject[] lights;
    public Material material;
    public int numb;
    // Update is called once per frame
    public void CliclEvent(Transform Popal)
    {
        switch (numb)
        {
            case 0:
                anim = !anim;
                animator_lights.SetBool("Anim", anim);
                for (int i = 0; i < lights.Length; i++)
                {
                    lights[i].SetActive(!anim);
                }
                if (anim) { material.DisableKeyword("_EMISSION"); }
                else
                {
                    material.EnableKeyword("_EMISSION");
                }
                break;
                case 1:
                {
                    if(Popal.name== "Door_Left")
                    {
                        Door_Left = !Door_Left;
                        if(!fridge.GetBool("Shelf1"))
                        {
                            fridge.SetBool("lef_shelf", false);
                        }
                        fridge.SetBool("left_Door", Door_Left);
                    }
                    if (Popal.name == "Door_Right")
                    {
                        Door_Right = !Door_Right;
                        if (!fridge.GetBool("Shelf2"))
                        {
                            fridge.SetBool("right_shelf", false);
                        }
                        fridge.SetBool("rigt_Door", Door_Right);
                    }
                    if(Popal.name == "Shelf1" && fridge.GetBool("left_Door"))
                    {
                        Shelf1= !Shelf1;
                        fridge.SetBool("lef_shelf", Shelf1);
                    }
                    if (Popal.name == "Shelf2"&& fridge.GetBool("rigt_Door"))
                    {
                        Shelf2 = !Shelf2;
                        fridge.SetBool("right_shelf", Shelf2);
                    }
                }
                break;
                case 2:
                Popal.transform.GetComponent<Gas_numb>().On();
                break;
        }
    }
}

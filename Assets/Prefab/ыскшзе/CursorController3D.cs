
using UnityEngine;

public class CursorController3D : MonoBehaviour
{
    public float interactionRange = 5f;
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Popal;


        if (Physics.Raycast(ray, out Popal, interactionRange)&&!Input.GetKey(KeyCode.Mouse1))
        {
            transform.position = Popal.point;

            if (Popal.transform.tag == "Clickable"&& Input.GetMouseButtonDown(0))
            {
                Debug.Log("It's :"+ Popal.transform.name);
                if (Popal.transform.GetComponentInParent<Animator>() != null ) 
                {
                   Popal.transform.GetComponent<Anim_script>().CliclEvent(Popal.transform);
                }

            }
        }
       
    }

}


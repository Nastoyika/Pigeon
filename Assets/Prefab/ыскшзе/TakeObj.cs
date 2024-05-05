
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeObj : MonoBehaviour
{
    float distance = 1;
    public GameObject Camera1;
    public Animator animator_lights;
    private bool anim = false;
    public GameObject[] lights;
    public Material material;
    public int numb;
    private void Start()
    {
        
        // Начинаем с кинематикой
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
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
        }
    }
    private void OnMouseDown()
    {
         // Выключаем кинематику при поддержке
    }

    private void OnMouseUp()
    {
        
        
    }

    private void OnMouseDrag()
    {
        distance += -(Input.GetAxis("Mouse ScrollWheel"));
        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mouse);
        if (Input.GetKey(KeyCode.R)) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
        // Задаем позицию Rigidbody непосредственно
        transform.position = objPos;
    }
}

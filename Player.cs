using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public float Movespeed = 3.5f;
    public NavMeshAgent nma = null;

    private void Update()
    {
        switch (Globals.ControlType)
        {
            case 1:
                Keyboard();
                break;
            case 2:
                Mouse();
                break;
        }
    }
    private void Keyboard()
    {
        nma.ResetPath();

        //WASD
        if (Input.GetKey(KeyCode.W) == true)
        {
            this.transform.Translate(Vector3.forward * Movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            this.transform.Translate(Vector3.back * Movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            this.transform.Translate(Vector3.left * Movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            this.transform.Translate(Vector3.right * Movespeed * Time.deltaTime);
        }
    }
    private void Mouse()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) == true)
            {
                nma.SetDestination(hit.point);
            }
        }
    }
}

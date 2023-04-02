using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseclick : MonoBehaviour
{
    public GameObject press_machine,red,green;
    private MachineController mc;
    private BoxCollider gc, rc;
    // Start is called before the first frame update
    void Start()
    {
        mc = press_machine.GetComponent<MachineController>();
        gc = green.GetComponent<BoxCollider>();
        rc = red.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.tag == "red")
                {
                    mc.StopAnim();
                    rc.enabled = false;
                    gc.enabled = true;
                    Debug.Log("Stop");
                }

                if (hit.collider.tag == "green")
                {
                    mc.StartAnim();
                    gc.enabled = false;
                    rc.enabled = true;

                    Debug.Log("Start");
                }
            }
        }
    }
}

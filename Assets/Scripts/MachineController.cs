using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void StartAnim()
    {
        anim.SetTrigger("Start");
    }
    public void StopAnim()
    {
        anim.SetTrigger("Stop");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private Animator pulley_Animator;
    [Space]
    [SerializeField]
    private GameObject pulleyLock,placementLock,t_pulleyLock,t_placementLock;

    [Space]

    [SerializeField]
    private Collider pulleyCollider;

    [SerializeField]
    private Collider onButton, offButton;

    bool isMachineoff = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if(isMachineoff)
        {
            pulleyLock.SetActive(true);
            placementLock.SetActive(false);
            t_placementLock.SetActive(true);
            t_pulleyLock.SetActive(false);
        }
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

    public void Unlocked()
    {
        placementLock.SetActive(true);
        pulleyLock.SetActive(false);
        t_placementLock.SetActive(false);

        pulleyCollider.enabled = true;
    }

    public void LockedMachine()
    {
        t_placementLock.SetActive(false);
        placementLock.SetActive(false);
        t_placementLock.SetActive(true);
        pulleyLock.SetActive(true);

    }

    public void MachineOnOff()
    {
        if (isMachineoff)
        {
            pulley_Animator.SetTrigger("On");
            onButton.enabled = true;
            isMachineoff = false;
            t_pulleyLock.SetActive(false);
        }
        else
        {
            pulley_Animator.SetTrigger("Off");
            onButton.enabled = false;
            isMachineoff = true;
            t_pulleyLock.SetActive(true);
        }
        
    }
}

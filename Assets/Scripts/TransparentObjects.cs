using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TransparentObjects : MonoBehaviour
{
    [SerializeField]
    private UnityEvent events;

    public void CallAllFunctions()
    {
        events.Invoke();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lock"))
        {
            events.Invoke();
            
        }
    }
}

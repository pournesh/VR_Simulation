using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLockPos : MonoBehaviour
{
    private Vector3 startPosition = Vector3.zero;
    private Quaternion startRotation = Quaternion.identity;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    public void ResetPos()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}

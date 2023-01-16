using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoovingCapsule : MonoBehaviour
{
    public float value = 0.01f;
    public float border = 6.0f;

    public Transform target;
    public Transform Capsule;

    [SerializeField] private UI_Class ui_class;

    void Start()
    {
        target.transform.position = Capsule.transform.position;
    }

    public void MoovCaps()
    {
        Capsule.position = Vector3.Lerp(transform.position, target.transform.position, value);
    }
}

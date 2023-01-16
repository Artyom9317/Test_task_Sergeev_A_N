using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class ButtonControler : MonoBehaviour
{
    [SerializeField] private MoovingCapsule moov_caps;

    public void ButtonControl()
    {
        if (Input.GetKey("left"))
        {
            if (moov_caps.target.transform.position.x > moov_caps.border * (-1))
                moov_caps.target.transform.position -= new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey("right"))
        {
            if (moov_caps.target.transform.position.x < moov_caps.border)
                moov_caps.target.transform.position += new Vector3(0.1f, 0f, 0f);
        }
        moov_caps.MoovCaps();
    }
}

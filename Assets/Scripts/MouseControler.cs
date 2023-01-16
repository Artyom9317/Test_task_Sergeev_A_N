using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class MouseControler : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private MoovingCapsule moov_caps;
    public Vector3 targetWorldPosition;

    public void MouseControl()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;
            mouseWorldPosition.y = 0f;
            targetWorldPosition = mouseWorldPosition;
            targetWorldPosition.y = moov_caps.target.transform.position.y;
            targetWorldPosition.z = moov_caps.target.transform.position.z;
            if (mainCamera.ScreenToWorldPoint(Input.mousePosition).x > moov_caps.border)
                targetWorldPosition.x = moov_caps.border;
            if (mainCamera.ScreenToWorldPoint(Input.mousePosition).x < moov_caps.border * (-1))
                targetWorldPosition.x = moov_caps.border * (-1);

            moov_caps.target.transform.position = targetWorldPosition;
        }
        if (Input.GetKey(KeyCode.Mouse0))
            moov_caps.MoovCaps();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    [SerializeField] private ButtonControler bt_ctrl;
    [SerializeField] private MouseControler mouse_ctrl;
    [SerializeField] private UI_Class ui_class;
    
    void Update()
    {
        if (ui_class.CheckPause())
        {
            if (ui_class.Check_Control.value == 0)
                mouse_ctrl.MouseControl();
            if (ui_class.Check_Control.value == 1)
                bt_ctrl.ButtonControl();
        }
    }    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Class : MonoBehaviour
{
    [SerializeField] private Toggle bt_pause;
    [SerializeField] public Dropdown Check_Control;

    [SerializeField] private SaveClass save_class;

    public bool CheckPause()
    {
        if (!bt_pause.isOn)
            return true;
        else
            return false;
    }
    public void SaveChangeControl()
    {
        Observable observable = new Observable();
        Observer observer = new Observer();
        observable.ChangeHappened += observer.HandleEvent;
        observable.Message();
        if (Check_Control.value == 0)
        {
            save_class.Save("MouseControl");
        }
        if (Check_Control.value == 1)
        {
            save_class.Save("ButtonControl");
        }
    }
}

class Observable
{
    public event EventHandler ChangeHappened;
    public void Message() =>
        ChangeHappened?.Invoke(this, EventArgs.Empty);
}

class Observer
{
    public void HandleEvent(object sender, EventArgs args)
    {
        Debug.Log("Control is changed ");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class LoadClass : MonoBehaviour
{
    [SerializeField] private UI_Class ui_class;

    void Start()
    {
        Load();
    }

    public void Load()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("Data/Save.xml");
        if (xmlDoc.SelectSingleNode("Information/Element1").InnerText == "MouseControl")
            ui_class.Check_Control.value = 0;
        if (xmlDoc.SelectSingleNode("Information/Element1").InnerText == "ButtonControl")
            ui_class.Check_Control.value = 1;
    }
}

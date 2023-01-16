using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class SaveClass : MonoBehaviour
{
    public void Save(string control)
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("Information");
        xmlDoc.AppendChild(rootNode);
        XmlNode userNode;
        userNode = xmlDoc.CreateElement("Element1");
        userNode.InnerText = control;
        rootNode.AppendChild(userNode);
        xmlDoc.Save("Data/Save.xml");
    }
}

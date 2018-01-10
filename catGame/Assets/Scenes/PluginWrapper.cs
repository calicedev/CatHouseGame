using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PluginWrapper : MonoBehaviour {

	
	void Start () {
        TextMesh textMesh = GetComponent<TextMesh>();
        var plugin = new AndroidJavaClass("com.example.unityplugin.PluginClass");
        textMesh.text = plugin.CallStatic<string>("GetTextFromPlugin", 7);


    }
	

}

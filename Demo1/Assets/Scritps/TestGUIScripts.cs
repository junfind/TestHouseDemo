﻿using UnityEngine;
using System.Collections;

public class TestGUIScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 100f, Screen.height / 2 - 50f, 200, 100), "Good Luck Jing");
    }
}

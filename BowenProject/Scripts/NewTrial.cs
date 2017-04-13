using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTrial : MonoBehaviour {
    GameObject temp = GameObject.Find("Canvas");
    Text val;
    // Use this for initialization
    void Start () {
       val = AddText("NEWWWWW", temp);
	}
	
	// Update is called once per frame
	void Update () {
		val.transform.position = new Vector3(10,10,0);
	}

    public static Text AddText(string textString, GameObject canvas)
    {
        Text text = canvas.AddComponent<Text>();
        text.text = textString;

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        text.font = ArialFont;
        text.material = ArialFont.material;

        return text;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintGeneral : MonoBehaviour
{
    public string sVal;
    public double dVal;
    private int iVal;

    public Text val;
    public string s;

    public string t;
    public Vector3 pos;

    // Use this for initialization
    void Start()
    {
        t = gameObject.tag;
        pos = gameObject.transform.position;
        switch (t)
        {
            case "Int":
                iVal = Random.Range(-500, 500);
                val.text = iVal.ToString();
                break;
            case "Double":
                dVal = Random.Range(-20.0f,20.0f);
                val.text = dVal.ToString("F2");
                break;
            case "String":
                sVal = "Java";
                val.text = sVal;
                break;
            default:
                sVal = "Goals";
                val.text = sVal;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        val.transform.position = pos;
    }

    
}


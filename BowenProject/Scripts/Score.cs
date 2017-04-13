using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int count;
    public Text countText;

    private void Start()
    {
        count = 0;
        setCountText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("String"))
        {
            Destroy(other.gameObject);
            // other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Strings: " + count.ToString();
    }

}

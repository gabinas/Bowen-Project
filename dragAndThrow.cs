using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndThrow : MonoBehaviour {

    TargetJoint2D joint = new TargetJoint2D();
    Rigidbody2D physicsHandler = new Rigidbody2D();
    private void Awake()
    {
        joint = this.gameObject.GetComponent<TargetJoint2D>();
        joint.enabled = false;
    }

    private void OnMouseDown()
    {
        joint.enabled = true;
       
    }

    private void OnMouseDrag()
    {
        if (joint.enabled == true)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            joint.target = cursorPosition;
        }
    }

    private void OnMouseUp()
    {
        joint.enabled = false;
    }
}

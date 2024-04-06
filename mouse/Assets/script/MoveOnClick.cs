using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEditor;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    public float speed = 1f;

    Vector2 lastMousePos;

    bool moving;
    // Start is called before the first frame update
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            moving = true;
        }
        if (moving && (Vector2)transform.position != lastMousePos)
        {
            float step = speed * Time.deltaTime;
            transform.position =  Vector2.MoveTowards(transform.position, lastMousePos, step);
        }
        else
        {
            moving = false;
        }
    }
}

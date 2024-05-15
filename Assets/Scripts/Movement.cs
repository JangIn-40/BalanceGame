using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); 
        }
    }
}

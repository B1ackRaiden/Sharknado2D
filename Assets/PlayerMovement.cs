using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal"); //These are instance variables, meaning they will
        float y = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(x, y, 0);
        transform.Translate(moveDirection * Time.fixedDeltaTime * speed);
    }
}

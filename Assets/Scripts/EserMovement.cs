using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EserMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public int playerFacing;
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(x, y, 0);
        transform.Translate(moveDirection * Time.fixedDeltaTime * speed);

        //check what way the player is moving
        if (x == 1)
        {
            playerFacing = 1;
            GetComponent<Animator>().Play("RightWalk");
        }
        else if (x == -1)
        {
            playerFacing = -1;
            GetComponent<Animator>().Play("LeftWalk");
        }

        if (y == 1)
        {
            playerFacing = 1;
            GetComponent<Animator>().Play("AwayWalk");
        }
        else if (y == -1)
        {
            playerFacing = -1;
            GetComponent<Animator>().Play("FrontWalk");
        }

        else if (x == 0)
        {
            playerFacing = 0;
            GetComponent<Animator>().Play("IdleStand");
        }
    }
}

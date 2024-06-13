using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderUpCollider : MonoBehaviour
{
    private GameObject OrderUp;

    // Start is called before the first frame update
    void Awake()
    {
        OrderUp = GameObject.Find("OrderCounter");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OrderUp.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OrderUp.SetActive(false);
        }
    }
}

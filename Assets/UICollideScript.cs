using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICollideScript : MonoBehaviour
{
    private GameObject Minigame;

    // Start is called before the first frame update
    void Awake()
    {
        Minigame = GameObject.Find("Panel");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Minigame.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Minigame.SetActive(false);
        }
    }
}

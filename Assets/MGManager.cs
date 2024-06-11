using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGManager : MonoBehaviour
{
    private DropScript DS;
    public int PartsSloted;
    public GameObject Minigame;
    public GameObject Counter;

    // Start is called before the first frame update
    void Start()
    {
        PartsSloted = 0;
        Minigame = GameObject.Find("Panel");
        Counter = GameObject.Find("CounterCollider");
        Minigame.SetActive(false);
    }

    void Update()
    {
        if(PartsSloted == 6)
        {
            Destroy(Minigame);
        }
    }
}

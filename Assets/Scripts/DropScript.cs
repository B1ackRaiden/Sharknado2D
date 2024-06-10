using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropScript : MonoBehaviour
{
    public GameObject matchingImage;
    private RectTransform slottableImage;
    private RectTransform thisRect;
    private Image thisImage;

    // Start is called before the first frame update
    void Start()
    {
        slottableImage = matchingImage.GetComponent<RectTransform>();
        thisRect = GetComponent<RectTransform>();
        thisImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(slottableImage.position, thisRect.position) < 5)
        {
            slottableImage.position = thisRect.position;
            matchingImage.SetActive(false);
            thisImage.color = new Color(255, 255, 255);
        }
    }
}

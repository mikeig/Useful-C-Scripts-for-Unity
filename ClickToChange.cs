using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickToChange : MonoBehaviour, IPointerClickHandler
{
    public bool isClicked;

    public GameObject objToChange;

    public Sprite obj1, obj2;
    // Use this for initialization
    void Start()
    {
        isClicked = false;
        if (!objToChange)
        {
            objToChange = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (objToChange.GetComponent<Image>() is Image)
        {
            Sprite obj11 = obj1;
            Sprite obj21 = obj2;
            (objToChange.GetComponent<Image>()).sprite = isClicked ? obj21 : obj11;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isClicked = !isClicked;
    }
}

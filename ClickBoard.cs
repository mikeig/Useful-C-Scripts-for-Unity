using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBoard : MonoBehaviour, IPointerClickHandler{

    public RectTransform tab;
    public RectTransform container;
    public bool isX;
    public bool isOpen;
    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    isOpen = true;
    //}

    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    isOpen = false;
    //}

    // Use this for initialization
    void Start()
    {
        //container = transform.Find("Container").GetComponent<RectTransform>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = container.localScale;
        if (isX)
        {
            scale.x = Mathf.Lerp(scale.x, isOpen ? 1 : 0, Time.deltaTime * 6);
        }
        else
        {
            scale.y = Mathf.Lerp(scale.y, isOpen ? 1 : 0, Time.deltaTime * 6);
        }
        container.localScale = scale;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isOpen = !isOpen;
        tab.SetAsFirstSibling();
    }
}

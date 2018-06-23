using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeScreen : MonoBehaviour, IPointerClickHandler
{
    public GameObject nextScreen, thisScreen;
    public bool buttonOrNot;

    // private bool isClicked;

    // Use this for initialization
    void Start()
    {
        if (!thisScreen)
        {
            thisScreen = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!buttonOrNot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (thisScreen.activeInHierarchy)
                {
                    thisScreen.SetActive(false);
                }

                if (!nextScreen.activeInHierarchy)
                {
                    nextScreen.SetActive(true);
                }
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (thisScreen.activeInHierarchy)
        {
            thisScreen.SetActive(false);
        }

        if (!nextScreen.activeInHierarchy)
        {
            nextScreen.SetActive(true);
        }
    }
}

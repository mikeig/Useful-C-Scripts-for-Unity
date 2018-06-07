using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tabPanel : MonoBehaviour, IPointerClickHandler
{
    public RectTransform tabButton, panel, tab;
    public bool isOpen;
    public float desiredPos;

    private Vector3 position, tabPanePos;
    private Vector2 size;
    private float width;

	// Use this for initialization
	void Start () {
        tabButton = gameObject.GetComponent<RectTransform>();
        isOpen = false;
        tabPanePos = tab.localPosition;
        size = panel.sizeDelta;

        width = size.x;
        desiredPos = -width - tabPanePos.x;
        Debug.Log(tabButton.position.x);
    }
	
	// Update is called once per frame
	void Update ()
    {
        position = tabButton.localPosition;
        position.x = Mathf.Lerp(position.x, isOpen ? desiredPos : -tabPanePos.x, Time.deltaTime * 6);
        tabButton.localPosition = position;
        Debug.Log(tabButton.position.x);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isOpen = !isOpen;
        tab.SetAsFirstSibling();
    }
}

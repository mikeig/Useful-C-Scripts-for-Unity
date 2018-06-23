using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChangeScene : MonoBehaviour, IPointerClickHandler
{

    public int sceneNum;

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0))
  //      {
            
  //      }
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(sceneNum);
    }
}

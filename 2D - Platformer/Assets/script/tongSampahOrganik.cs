using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class tongSampahOrganik : MonoBehaviour, IDropHandler
{
    public Transform anorganikPosition;
    public Transform berbahayaPosition;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "sampahOrganik")
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log(eventData.pointerDrag);
                Destroy(eventData.pointerDrag);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
        }

        if (eventData.pointerDrag.name == "sampahAnorganik")
        {
            eventData.pointerDrag.transform.position = anorganikPosition.position;
        }

        if (eventData.pointerDrag.name == "sampahBerbahaya")
        {
            eventData.pointerDrag.transform.position = berbahayaPosition.position;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

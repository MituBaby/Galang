using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class tongSampahOrganik : MonoBehaviour, IDropHandler
{
    public Transform kantongPlastik;
    public Transform bungkusKeripik;
    public Transform baterai;
    public Transform monitor;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "kulitPisang" || eventData.pointerDrag.name == "dagingAyam" || eventData.pointerDrag.name == "semangka")
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log(eventData.pointerDrag);
                Destroy(eventData.pointerDrag);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
        }

        if (eventData.pointerDrag.name == "kantongPlastik")
        {
            eventData.pointerDrag.transform.position = kantongPlastik.position;
        }

        if (eventData.pointerDrag.name == "bungkusKeripik")
        {
            eventData.pointerDrag.transform.position = bungkusKeripik.position;
        }

        if (eventData.pointerDrag.name == "baterai")
        {
            eventData.pointerDrag.transform.position = baterai.position;
        }

        if (eventData.pointerDrag.name == "monitor")
        {
            eventData.pointerDrag.transform.position = monitor.position;
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

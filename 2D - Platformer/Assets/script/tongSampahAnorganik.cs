using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tongSampahAnorganik : MonoBehaviour, IDropHandler
{
    public Transform kulitPisang;
    public Transform dagingAyam;
    public Transform semangka;
    public Transform baterai;
    public Transform monitor;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "kantongPlastik" || eventData.pointerDrag.name == "bungkusKeripik")
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log(eventData.pointerDrag);
                Destroy(eventData.pointerDrag);
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
        }

        if (eventData.pointerDrag.name == "kulitPisang")
        {
            eventData.pointerDrag.transform.position = kulitPisang.position;
        }

        if (eventData.pointerDrag.name == "dagingAyam")
        {
            eventData.pointerDrag.transform.position = dagingAyam.position;
        }

        if (eventData.pointerDrag.name == "semangka")
        {
            eventData.pointerDrag.transform.position = semangka.position;
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

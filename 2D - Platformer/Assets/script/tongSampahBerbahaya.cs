using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class tongSampahBerbahaya : MonoBehaviour, IDropHandler
{
    public Transform kulitPisang;
    public Transform dagingAyam;
    public Transform semangka;
    public Transform bungkusKeripik;
    public Transform kantongPlastik;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "baterai" || eventData.pointerDrag.name == "monitor")
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

        if (eventData.pointerDrag.name == "kantongPlastik")
        {
            eventData.pointerDrag.transform.position = kantongPlastik.position;
        }

        if (eventData.pointerDrag.name == "bungkusKeripik")
        {
            eventData.pointerDrag.transform.position = bungkusKeripik.position;
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

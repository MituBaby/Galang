using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tongSampahBerbahaya : MonoBehaviour, IDropHandler
{
    public Transform organikPosition;
    public Transform anorganikPosition;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "sampahBerbahaya")
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

        if (eventData.pointerDrag.name == "sampahOrganik")
        {
            eventData.pointerDrag.transform.position = organikPosition.position;
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

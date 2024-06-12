using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnavailableDrop : MonoBehaviour, IDropHandler
{
    public Transform organikPosition;
    public Transform anorganikPosition;
    public Transform berbahayaPosition;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "sampahOrganik")
        {
            eventData.pointerDrag.transform.position = organikPosition.position;
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

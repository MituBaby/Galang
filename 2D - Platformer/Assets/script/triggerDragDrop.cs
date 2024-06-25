using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDragDrop : MonoBehaviour
{
    public GameObject dragdropToInstantiate;
    public Transform parentTransform;
    public float detectionRange = 2.0f;
    public Transform raycastPoint;
    //public GameObject canvasTele;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject sampah1 = GameObject.Find("sampah1");
        GameObject sampah2 = GameObject.Find("sampah2");
        if (sampah1 != null)
        {
            float distance = Vector2.Distance(transform.position, sampah1.transform.position);
            if (distance <= detectionRange)
            {
                //canvasTele.SetActive(false);
                Destroy(sampah1);
                Time.timeScale = 0;
                InstantiatePrefabAsChild();
            }
        }
        if (sampah2 != null)
        {
            float distance = Vector2.Distance(transform.position, sampah2.transform.position);
            if (distance <= detectionRange)
            {
                //canvasTele.SetActive(false);
                Destroy(sampah2);
                Time.timeScale = 0;
                InstantiatePrefabAsChild();
            }
        }
    }

    void InstantiatePrefabAsChild()
    {
        // Memastikan prefabToInstantiate tidak null
        if (dragdropToInstantiate != null)
        {
            GameObject newObject = Instantiate(dragdropToInstantiate, parentTransform);
        }
        else
        {
            Debug.LogError("Prefab untuk di-instantiate belum diatur!");
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Gambar lingkaran di Scene view untuk melihat jarak deteksi
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}

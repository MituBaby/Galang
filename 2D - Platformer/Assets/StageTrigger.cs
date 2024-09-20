using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public CameraSwitcher cameraSwitcher;
    public List<TriggerConfig> triggers;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var trigger in triggers)
            {
                if (trigger.triggerObject.GetComponent<Collider2D>().IsTouching(other))
                {
                    cameraSwitcher.SwitchToCamera(trigger.targetCameraIndex);
                    break;
                }
            }
        }
    }

    [System.Serializable]
    public class TriggerConfig
    {
        public GameObject triggerObject;
        public int targetCameraIndex;
    }
}


using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour
{
    public List<CinemachineVirtualCamera> cameras;
    public float switchCooldown = 1.0f; // Default cooldown time in seconds

    private int currentCameraIndex = 0;
    private bool canSwitch = true;

    void Start()
    {
        SetCameraPriority(0); // Set the initial camera
    }

    private void SetCameraPriority(int cameraIndex)
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            if (i == cameraIndex)
            {
                cameras[i].Priority = 10; // Set high priority for the active camera
                Debug.Log("Switching to Camera: " + cameras[i].name);
            }
            else
            {
                cameras[i].Priority = 0; // Set low priority for other cameras
            }
        }
    }

    public void SwitchToCamera(int cameraIndex)
    {
        if (cameraIndex < 0 || cameraIndex >= cameras.Count)
        {
            Debug.LogWarning("Invalid camera index: " + cameraIndex);
            return;
        }

        if (canSwitch)
        {
            SetCameraPriority(cameraIndex);
            StartCoroutine(CooldownCoroutine());
        }
    }

    private IEnumerator CooldownCoroutine()
    {
        canSwitch = false;
        yield return new WaitForSeconds(switchCooldown);
        canSwitch = true;
    }
}

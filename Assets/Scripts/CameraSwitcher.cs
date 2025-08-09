using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private bool isCamera1Active = true;

    void Start()
    {
        // ”бедимс€, что активна только одна камера при старте
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        isCamera1Active = !isCamera1Active;

        camera1.enabled = isCamera1Active;
        camera2.enabled = !isCamera1Active;
    }
}


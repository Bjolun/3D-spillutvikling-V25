using Unity.Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField]
    private CinemachineCamera cam1;

    [SerializeField] 
    private CinemachineCamera cam2;

    private bool isCamera1Active = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCamera1Active = !isCamera1Active;

            cam1.Priority = isCamera1Active ? 1 : 0;
            cam2.Priority = isCamera1Active ? 0 : 1;
        }
    }

}

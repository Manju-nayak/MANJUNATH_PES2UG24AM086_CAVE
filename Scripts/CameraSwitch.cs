using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera mainCamera;

    public Transform frontView;
    public Transform stageView;
    public Transform audienceView;
    public Transform switchView;

    public void FrontView()
    {
        mainCamera.transform.SetPositionAndRotation(
            frontView.position,
            frontView.rotation);
    }

    public void StageView()
    {
        mainCamera.transform.SetPositionAndRotation(
            stageView.position,
            stageView.rotation);
    }

    public void AudienceView()
    {
        mainCamera.transform.SetPositionAndRotation(
            audienceView.position,
            audienceView.rotation);
    }

    public void SwitchView()
    {
        mainCamera.transform.SetPositionAndRotation(
            switchView.position,
            switchView.rotation);
    }
}
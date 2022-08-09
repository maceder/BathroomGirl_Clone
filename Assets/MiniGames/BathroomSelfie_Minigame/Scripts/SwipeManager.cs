using UnityEngine;

/// <summary>
/// SwipeDirector den f�rlat�lan iste�e g�re i�lemerin yap�ld��� manager class
/// </summary>
public class SwipeManager : MonoBehaviour
{
    public RawBackgroundManager rawBackgroundManager;
    public ArrowBoxController arrowBoxController;
    public PoseController poseController;

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        if (rawBackgroundManager.currentEnumDirection == data.Direction)
        {
            arrowBoxController.CorrectArrow();
            rawBackgroundManager.RawBackgroundIsPlay(true);
            poseController.ChangePose(data.Direction);
        }
        else
        {
            arrowBoxController.WrongArrow();
        }
    }
}

using UnityEngine;

/// <summary>
/// SwipeDirector den f�rlat�lan iste�e g�re i�lemerin yap�ld��� manager class
/// </summary>
public class SwipeManager : MonoBehaviour
{
    public RawBackgroundManager rawBackgroundManager;
    public PoseController poseController;

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }


    //SwipeDetekt�r'den gelen datan�n k�yaslanmas�
    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        if (rawBackgroundManager.CompareSwipeDirection(data))
        {
            rawBackgroundManager.RawBackgroundIsPlay(true);
            rawBackgroundManager.CorrectSwipeAnimation();
            poseController.ChangePose(data.Direction);
        }
        else
        {
            rawBackgroundManager.WrongSwipeAnimation();
        }
    }
}

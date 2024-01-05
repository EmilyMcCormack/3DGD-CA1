/*https://www.youtube.com/watch?v=Qw8odLHv38Q&t=484s&ab_channel=LlamAcademy>, Accessed On: <01/24>, Using Line Numbers: 6 - 39*/

using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    //Script I was trying to use for a progress bar tutorial that ended up giving an AABB error so I decided to do a simpler progress bar 

    /*[SerializeField]
    private Image ProgressImage;
    [SerializeField]
    private float DefaultSpeed = 1f;
    [SerializeField]
    private UnityEvent<float> OnProgress;
    [SerializeField]
    private UnityEvent OnComplete;

    private Coroutine AnimationCoroutine;

    private void Start()
    {
        if (ProgressImage.type != Image.Type.Filled)
        {
            Debug.LogError($"{name}'s ProgressImage is not of type \"Filled\" so it cannot be used" + 
                $"as a progress bar. Disabling this Progress Bar");
            this.enabled = false; 
        }
    }
    
    public void SetProgress(float progress)
    {
        SetProgress(progress, DefaultSpeed);
    }

    public void SetProgress(float Progress, float Speed)
    {
        if (Progress < 0 || Progress > 1)
        {
            Debug.LogWarning($"Invalid progress passed, expected value is between 0 and 1. Got {Progress}. Clamping");
            Progress = Mathf.Clamp01(Progress);
        }
        if (Progress != ProgressImage.fillAmount)
        {
            if(AnimationCoroutine != null)
            {
                StopCoroutine(AnimationCoroutine);
            }

            AnimationCoroutine = StartCoroutine(AnimateProgress(Progress, Speed);
        }    
    }

    private IEnumerator AnimateProgress(float Progress, float Speed)
    {
        float time = 0;
        float initialProgress = ProgressImage.fillAmount;

        while (time < 1)
        {
            ProgressImage.fillAmount = Mathf.Lerp(initialProgress, Progress, time);
            time += Time.deltaTime * Speed;

            OnProgress?.Invoke(ProgressImage.fillAmount);
            yield return null; 
        }

        ProgressImage.fillAmount = Progress;
        OnProgress?.Invoke(Progress);
        OnComplete?.Invoke(); 
    }*/
}

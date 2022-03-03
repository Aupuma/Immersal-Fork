using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationIntervalManager : MonoBehaviour
{
    [SerializeField] DOTweenAnimation animation;
    [SerializeField] float interval;

    public void WaitForRepeat()
    {
        Invoke("PlayAnimation", interval);
    }

    private void PlayAnimation()
    {
        animation.DORestart();
    }
}

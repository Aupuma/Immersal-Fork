using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextColorFlowAnimation : MonoBehaviour
{
    [SerializeField] TextMeshPro text;
    [SerializeField] Color firstColor;
    [SerializeField] Color secondColor;


    // Start is called before the first frame update
    void Start()
    {
        text.color = firstColor;

        DOTweenTMPAnimator animator = new DOTweenTMPAnimator(text);
        Sequence sequence = DOTween.Sequence();
        sequence.SetLoops(-1,LoopType.Yoyo);
        for (int i = 0; i < animator.textInfo.characterCount; ++i)
        {
            if (!animator.textInfo.characterInfo[i].isVisible) continue;
            Vector3 currCharOffset = animator.GetCharOffset(i);
            sequence.Append(animator.DOColorChar(i, secondColor, 0.15f));
        }

    }
}

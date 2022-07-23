using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameObject virtualCamera02;
    [SerializeField] private GameObject spotLight;
    private float duration = 2f;
    private Ease ease;

    // Start is called before the first frame update
    void Start()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(playerTransform.DOMoveX(playerTransform.position.x - 4, duration).SetEase(ease))
            .PrependInterval(1)
            .Append(playerTransform.DOMoveX(playerTransform.position.x + 4, duration * 2).SetEase(ease))
            .PrependInterval(1)
            .Append(playerTransform.DOMoveX(playerTransform.position.x, duration).SetEase(ease))
            .PrependInterval(0.5f)
            .OnComplete(()=> ActiveOnFinished());
    }

    private void ActiveOnFinished()
    {
        virtualCamera02.SetActive(true);
        spotLight.SetActive(true);
    }
}

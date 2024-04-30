using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Start()
    {
        OpenGate();
        GameEvents.current.eventCradleActive += OpenGate;
        GameEvents.current.eventCradleDeactive += CloseGate;

        CloseGate();
    }

    private void OpenGate()
    {
        animator.SetBool("open", true);
    }

    private void CloseGate()
    {
        animator.SetBool("open", false);
    }
}

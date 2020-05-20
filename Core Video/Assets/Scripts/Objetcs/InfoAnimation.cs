using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAnimation : MonoBehaviour
{
    Animator m_Animator;
    float m_CurrentSpeed;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_CurrentSpeed = m_Animator.GetCurrentAnimatorStateInfo(0).speed;
    }

    // Update is called once per frame
    void Update()
    {
        m_CurrentSpeed = m_Animator.GetCurrentAnimatorStateInfo(0).speed;
        Debug.Log(m_CurrentSpeed);
    }
}

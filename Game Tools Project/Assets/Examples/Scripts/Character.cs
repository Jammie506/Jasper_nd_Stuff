using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour {

    private Animator m_animator;

	void Start ()
    {
        //Initialise Animator
        m_animator = GetComponent<Animator>();
	}
	

    public void Move(float turn, float forward, bool jump)
    {
        //Control Animation Programme
        m_animator.SetFloat("Turn", turn);
        m_animator.SetFloat("Forward", forward);

        if (jump)
        {
            m_animator.SetTrigger("Jump");
        }
        
    }
}
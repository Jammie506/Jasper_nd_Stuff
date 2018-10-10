using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footprint : MonoBehaviour {

    private Animator m_animator;
    private Transform m_rightFootTransform;
    private Transform m_leftFootTransform;

    int scale;
    GameObject m_footprint;

    private void Start()
    {
        m_animator = GetComponent<Animator>();

        m_rightFootTransform = m_animator.GetBoneTransform(HumanBodyBones.RightFoot);
        m_leftFootTransform = m_animator.GetBoneTransform(HumanBodyBones.LeftFoot);
    }

	public void MakeFootprint ()
    {
        Debug.Log("Footprint");

        if (scale > 0) // left foot
        {
            Instantiate(m_footprint, m_leftFootTransform.position, m_leftFootTransform.rotation);
        }
        else // right foot
        {
            Instantiate(m_footprint, m_rightFootTransform.position, m_rightFootTransform.rotation);
        }
	}
}

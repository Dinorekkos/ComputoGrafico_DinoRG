using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMechanic : MonoBehaviour
{
    [SerializeField] private bool m_isAactive;
    [SerializeField] private SkinnedMeshRenderer skin;

    private Material material;
    
    void Start()
    {
        material = skin.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isAactive)
        {
            material.EnableKeyword("ISACTIVE_ON");
            material.DisableKeyword("ISACTIVE_OFF");
        }
        else
        {
            material.EnableKeyword("ISACTIVE_OFF");
            material.DisableKeyword("ISACTIVE_ON");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("star"))
        {
            Debug.Log("Yes");
            m_isAactive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("star"))
        {
            m_isAactive = false;
        }
    }
}

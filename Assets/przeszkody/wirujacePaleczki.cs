using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wirujacePaleczki : MonoBehaviour
{
    Collider2D m_ObjectCollider;
    KulkaHP Kulkahealth;
    void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        m_ObjectCollider = GetComponent<Collider2D>();
        //Here the GameObject's Collider is not a trigger
        m_ObjectCollider.isTrigger = false;
        //Output whether the Collider is a trigger type Collider or not
        Kulkahealth = GameObject.FindGameObjectWithTag("kulka").GetComponent<KulkaHP>();
    }

    void OnCollisionEnter2D()
    {
        //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
        m_ObjectCollider.isTrigger = true;
        Kulkahealth.TakeDamage(1);
        m_ObjectCollider.isTrigger = false;
    }
}

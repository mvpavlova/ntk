using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newfunction : MonoBehaviour
{
    private Animation anim;
    private bool anima = false;
    



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();

    }

    public void Die()
    {
        if (anima == true)
            return;

        anima = true;
        anim.Play("Bear_die");
        Invoke("ResetAnimation", 1.1f);
    }
    public void Attack()
    {
        if (anima == true)
            return;

        anima = true;
        anim.Play("Bear_attack");
        Invoke("ResetAnimation", 2.1f);
    }
    
    public void Walk()
    {
        if (anima == true)
            return;

        anima = true;
        anim.Play("Bear_walk");
        Invoke("ResetAnimation", 1.0f);
    }

    public void ResetAnimation()
    {
        anim.Play("Bear_idle");
        anima = false;

    }
    
  
}

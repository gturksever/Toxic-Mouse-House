using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WheelAnim : MonoBehaviour
{
    public Animator CharAnim;
    private float horizontal;
    
    private float animatorTurnAngle;
    
    
  

    
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        

        animatorTurnAngle = Mathf.Lerp(animatorTurnAngle, -horizontal, 20 * Time.deltaTime);
            CharAnim.SetFloat("turnAngle", animatorTurnAngle);
        
    }
}

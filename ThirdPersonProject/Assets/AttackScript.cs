using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public Animator animator;
    private vThirdPersonMotor motor;


    private void Awake()
    {
        motor = GetComponent<vThirdPersonMotor>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !GetAnimationState("Attack"))
        {
            animator.CrossFadeInFixedTime("Attack", 0.2f);
            motor.moveSpeed = 0;
            //EditorApplication.isPaused = true;
        }
    }

    public bool GetAnimationState(string subStateName)
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);

        return state.IsName(subStateName);
    }
}

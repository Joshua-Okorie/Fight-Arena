using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ComboState
{
    NONE,
    PUNCH1,
    PUNCH2,
    PUNCH3,
    PUNCH4,
    KICK1
}

public class CombatScript : MonoBehaviour
{
    private CharacterAnimation playerAnim;

    private bool activateTimerToReset;
    private float defaultComboTimer = 0.4f;
    private float currentComboTimer;
    private ComboState currentComboState;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<CharacterAnimation>();

        currentComboTimer = defaultComboTimer;
        currentComboState = ComboState.NONE;
    }

    // Update is called once per frame
    void Update()
    {
        PunchCombo();
        //ResetComboState();
    }

    void PunchCombo()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {

            playerAnim.Punch1();
           /* currentComboState++;
            activateTimerToReset = true;
            currentComboTimer = defaultComboTimer;

            if (currentComboState == ComboState.PUNCH1)
            {
                playerAnim.Punch1();
            }

             if (currentComboState == ComboState.PUNCH2)
            {
                playerAnim.Punch2();
            }

             if (currentComboState == ComboState.PUNCH3)
            {
                playerAnim.Punch3();
            }

             if (currentComboState == ComboState.PUNCH4)
            {
                playerAnim.Punch4();
            } */
        }
    }

  /*  void ResetComboState()
    {
        
        if(activateTimerToReset)
        {
            currentComboTimer -= Time.deltaTime;

            if(currentComboTimer <= 0f)
            {
                currentComboState = ComboState.NONE;
                activateTimerToReset = false;
                currentComboTimer = defaultComboTimer;
            }
        } 
    }

    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Walk(bool move)
    {
        playerAnim.SetBool("Walk", move);
    }

    public void Punch1()
    {
        playerAnim.SetTrigger("Punch1");
    }

    public void Punch2()
    {
        playerAnim.SetTrigger("Punch2");
    }
    public void Punch3()
    {
        playerAnim.SetTrigger("Punch3");
    }

    public void Punch4()
    {
        playerAnim.SetTrigger("Punch4");
    }
    public void Kick1()
    {
        playerAnim.SetTrigger("Kick");
    }
}

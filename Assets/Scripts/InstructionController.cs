using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.instance.onCollisionChangeText += ChangeInstruction;
    }

    private void ChangeInstruction()
    {

    }
}

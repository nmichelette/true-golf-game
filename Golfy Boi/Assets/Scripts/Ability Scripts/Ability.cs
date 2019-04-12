using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    [SerializeField]
    private int myValue = 0;

    public abstract void Activate(Rigidbody2D rb2d);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Double Jump", menuName = "Abilities/Double Jump")]
public class Double_Jump : Ability
{
    [SerializeField]
    private float power = 5;

    public override void Activate(Rigidbody2D rb2d)
    {
        Vector2 direction = new Vector2(1, 1.5f);
        rb2d.AddForce(direction * power * 100);
    }
}

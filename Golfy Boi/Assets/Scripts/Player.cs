using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  Player holds all character values
public class Player : MonoBehaviour
{
    public float chargeRate = 5f;
    private float nextTime = 0;
    private float power = 0;
    public float maxPower = 10f;
    public float abilityCooldown = 2.0f;
    public Ability ability;

    // Use this for initialization
    void Start()
    {

    }
}

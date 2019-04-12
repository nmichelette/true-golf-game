using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour
{
    float h, v;
    public float chargeRate = 5f;
    private float nextTime = 0;
    private float power = 0;
    public float maxPower = 10f;
    public float dpadDeadZone = .3f;
    public float abilityCooldown = 0.1f;
    public Ability ability;
    
    private Vector2 direction;
    private LineRenderer lineRenderer;

    public int playernum = 1;
    // Use this for initialization
    void Start ()
    {
        lineRenderer = GetComponentInChildren<LineRenderer>();
	}

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal_P"+playernum);
        v = Input.GetAxisRaw("Vertical_P"+playernum);

        if (Mathf.Abs(h) < dpadDeadZone && Mathf.Abs(v) < dpadDeadZone)
        {
            h = v = 0f;
        }

        var joystickVector = new Vector3(h, v, 0f).normalized * power;
        //lineRenderer.SetPosition(0, transform.position);
        //lineRenderer.SetPosition(1, transform.position + joystickVector);

        Debug.DrawLine(new Vector3(0f, 0f, 0f), new Vector3(3f, 0f, 0f));

        //print("H" + playernum + ": " + h);
        //print("V" + playernum + ": " + v);
        if (Input.GetButtonDown("Fire1_P" + playernum))
        {
            print("Player " + playernum + " jumps");
            direction = new Vector2(h, v);
            GetComponent<Rigidbody2D>().AddForce(-direction * power * 100);
            power = 0;
        }

        if ((h != 0f || v != 0f))
        {
            power += Time.deltaTime * chargeRate;
            if (power > maxPower)
                power = maxPower;
        }
        else
            power = 0f;

        //&& nextTime <= Time.time
        if (Input.GetButtonDown("Fire2_P" + playernum))
        {
            print("Player " + playernum + " uses ability");
            ability.Activate(GetComponent<Rigidbody2D>());
            nextTime = Time.time + abilityCooldown;
        }

    }
}

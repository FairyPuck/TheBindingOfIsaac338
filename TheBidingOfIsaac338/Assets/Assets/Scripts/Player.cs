using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector2 = UnityEngine.Vector2;


public class Player : MonoBehaviour
{
    public int speed;
    public Animator bodyAnimator;
    private float AxisX, AxisY, CryX, CryY;

    public Transform cryPoint;
    public GameObject tearPrefab;
    public float cryForce = 20f;


    void FixedUpdate()
    {
        Vector2 movement = new Vector2(speed * AxisX, speed * AxisY);
        movement *= Time.deltaTime;

        bodyAnimator.SetFloat("Horizontal", movement.x);
        bodyAnimator.SetFloat("Vertical", movement.y);
        bodyAnimator.SetFloat("Speed", movement.magnitude);
        transform.Translate(movement);
    }

    public void OnHorizontal(InputValue val)
    {
        AxisX = val.Get<float>();
    }

    public void OnVertical(InputValue val)
    {
        AxisY = val.Get<float>();
    }

    public void OnCryHorizontal(InputValue val)
    {
        if (CryY == 0)
        {
            CryX = val.Get<float>();
            if (CryX != 0)
            {
                Cry("Horizontal", CryX);
            }
        }
    }

    public void OnCryVertical(InputValue val)
    {
        if (CryX == 0)
        {
            CryY = val.Get<float>();
            if (CryY != 0)
            {
                Cry("Vertical", CryY);
            }
        }
    }

    void Cry(string axis,float value)
    {
        GameObject tear = Instantiate(tearPrefab, cryPoint.position, cryPoint.rotation);
        Rigidbody2D rb = tear.GetComponent<Rigidbody2D>();
        if (axis == "Vertical")
        {
            if (value == 1)
            {
                rb.AddForce(cryPoint.up * cryForce, ForceMode2D.Impulse);
            }
            else rb.AddForce(-cryPoint.up * cryForce, ForceMode2D.Impulse);
        }

        if (axis == "Horizontal")
        {
            if (value == 1)
            {
                rb.AddForce(cryPoint.right * cryForce, ForceMode2D.Impulse);
            }
            else rb.AddForce(-cryPoint.right * cryForce, ForceMode2D.Impulse);
        }
    }
}

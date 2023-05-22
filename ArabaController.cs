using System.Collections.Generic;
using UnityEngine;

public enum Axel
{
    Front,
    Rear
}

[System.Serializable]
public struct Wheel
{
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
}

public class ArabaController : MonoBehaviour
{
    [SerializeField]
    private float maksimumHizlanma = 2000f;
    [SerializeField]
    private float donusHassasiyeti = 1f;
    [SerializeField]
    private float maksimumDonusAcisi = 45f;
    [SerializeField]
    private List<Wheel> wheels;

    private float inputX, inputY;
    private Rigidbody carRigidbody;

    private void Awake()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        Move();
        Turn();
    }

    private void Move()
    {
        foreach (var wheel in wheels)
        {
            wheel.collider.motorTorque = inputY * maksimumHizlanma * 800 * Time.deltaTime;
        }
    }

    private void Turn()
    {
        foreach (var wheel in wheels)
        {
            if (wheel.axel == Axel.Front)
            {
                var steerAngle = inputX * donusHassasiyeti * maksimumDonusAcisi;
                wheel.collider.steerAngle = steerAngle;
            }
        }
    }
}
   






using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

/// <summary>
/// @author Dylan Curran
/// This script controls player movement
/// </summary>
public class PlayerController : MonoBehaviour
{
    public bool _shieldActive;
    public float _speed = 10f;
    public float _health = 100f;
    public float _TurnSpeed = 180f;
    //public AudioSource m_MovementAudio;
    //public AudioClip m_EngineIdling;
    //public AudioClip m_EngineDriving;
    public float _pitchRange = 0.2f;
    public object cube;


    private string _moveVertical;
    private string _moveHorizontal;
    private Rigidbody _rb3d;
    private float _moveVertValue;
    private float _turnValue;
    private float _originalPitch;


    private void Awake()
    {
        //gets rigidbody
        _rb3d = GetComponent<Rigidbody>();
    }


    private void OnEnable()
    {
        //initialises values on start
        _rb3d.isKinematic = false;
        _moveVertValue = 0f;
        _turnValue = 0f;
    }


    private void OnDisable()
    {
        _rb3d.isKinematic = true;
        _shieldActive = false;
    }


    private void Start()
    {
        // takes the axis input for tank
        _moveVertical = "Vertical";
        _moveHorizontal = "Horizontal";
        Debug.Log(_shieldActive);

        //m_OriginalPitch = m_MovementAudio.pitch;
    }
    private void Update()
    {
        // gets the movement value for the axis
        _moveVertValue = Input.GetAxis(_moveVertical);
        _turnValue = Input.GetAxis(_moveHorizontal);

       // EngineAudio();
    }


    private void EngineAudio()
    {
        //if (Mathf.Abs(m_MovementInputValue) < 0.1f && Mathf.Abs(m_TurnInputValue) < 1.0f)
        //{
        //    if (m_MovementAudio.clip == m_EngineDriving)
        //    {
        //        m_MovementAudio.clip = m_EngineIdling;
        //        m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
        //        m_MovementAudio.Play();
        //    }
        //}
        //else
        //{
        //    if (m_MovementAudio.clip == m_EngineIdling)
        //    {
        //        m_MovementAudio.clip = m_EngineDriving;
        //        m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
        //        m_MovementAudio.Play();
        //    }
        //}
    }
    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    /// <summary>
    /// controls movement over time for the tank based on direction
    /// </summary>
    private void Move()
    {
        Vector3 movement = transform.forward * _moveVertValue * _speed * Time.deltaTime;

        _rb3d.MovePosition(_rb3d.position + movement);
    }

    /// <summary>
    /// Turns the tank
    /// </summary>
    private void Turn()
    {
        float turn = _turnValue * _TurnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        _rb3d.MoveRotation(_rb3d.rotation * turnRotation);
    }

    // ask about this later
    private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag.Equals("Box"))
		{
			_speed = 120;
		}
		else
		{
			Debug.Log(_health);
			//_speed = 60;
			_shieldActive = false;
			_health = 100;
		}
    }

    public float GetHealth()
    {
	    return _health;
    }

    public bool GetShield()
    {
	    return _shieldActive;
    }

    public float GetSpeed()
    {
	    return _speed;
    }

}

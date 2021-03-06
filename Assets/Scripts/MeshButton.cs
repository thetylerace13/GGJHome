﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class MeshButton : MonoBehaviour 
{
    #region Variables
    /// <summary>
    /// <para>The object that is enabled/disabled depending on highlight</para>
    /// </summary>
    [SerializeField]
    private GameObject effect;

    /// <summary>
    /// <para>The audio clip to use on OnMouseEnter</para>
    /// </summary>
    [SerializeField]
    private AudioClip enterClip;

    /// <summary>
    /// <para>The audio clip to use on OnMouseDown</para>
    /// </summary>
    [SerializeField]
    private AudioClip downClip;

    /// <summary>
    /// <para>The method that is called when the button is clicked</para>
    /// </summary>
    [SerializeField]
    private UnityEvent OnClick;

    /// <summary>
    /// <para>The Audio Source component attached</para>
    /// </summary>
    private AudioSource _audioSource;
	#endregion

	#region Properties
	
	#endregion
	
	#region Events
	/// <summary>
	/// Awake is called before start
	/// <summary>
	private void Awake() 
	{
        _audioSource = GetComponent<AudioSource>();
		if (effect != null)
        {
            effect.SetActive(false);
        }
	}
	
	/// <summary>
	/// Use this for initialization
	/// <summary>
	private void Start() 
	{
		
	}
	
	/// <summary>
	/// Update is called once per frame
	/// <summary>
	private void Update() 
	{
		
	}
	
	/// <summary>
	/// Use this for physics-related changes
	/// <summary>
	private void FixedUpdate() 
	{
		
	}

    /// <summary>
    /// This is called when the user has pressed the mouse button while over the GUIElement or Collider
    /// </summary>
    private void OnMouseDown()
    {
        OnClick.Invoke();
        if (_audioSource != null && downClip != null)
        {
            _audioSource.clip = downClip;
            _audioSource.Play();
        }
    }

    /// <summary>
    /// This is called when the mouse has entered the GUIElement or Collider
    /// </summary>
    private void OnMouseEnter()
    {
        if (effect != null)
        {
            effect.SetActive(true);
        }
        if (_audioSource != null && enterClip != null)
        {
            _audioSource.clip = enterClip;
            _audioSource.Play();
        }
    }

    /// <summary>
    /// This is called when the mouse is no longer over the GUIElement or Collider
    /// </summary>
    private void OnMouseExit()
    {
        if (effect != null)
        {
            effect.SetActive(false);
        }
    }
    #endregion

    #region Methods

    #endregion

    #region Coroutines

    #endregion
}

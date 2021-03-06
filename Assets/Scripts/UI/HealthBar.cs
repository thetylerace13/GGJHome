﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour 
{
    #region Variables
    /// <summary>
    /// <para>The health to keep track of</para>
    /// </summary>
    [SerializeField]
    private PlayerHealth playerHealth;

    /// <summary>
    /// <para>The slider to show how much health is left</para>
    /// </summary>
    [SerializeField]
    private Slider slider;

    /// <summary>
    /// <para>The slider to show how much health is missing</para>
    /// </summary>
    [SerializeField]
    private Slider inverseSlider;
	#endregion

	#region Properties
	
	#endregion
	
	#region Events
	/// <summary>
	/// Awake is called before start
	/// <summary>
	private void Awake() 
	{

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
        slider.value = playerHealth.m_playerHealth / playerHealth.m_maxHealth;
        inverseSlider.value = 1 - slider.value;
	}
	
	/// <summary>
	/// Use this for physics-related changes
	/// <summary>
	private void FixedUpdate() 
	{
		
	}
	#endregion
	
	#region Methods
	
	#endregion
	
	#region Coroutines
	
	#endregion
}

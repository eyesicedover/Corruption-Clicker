﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyHealth : MonoBehaviour
{

	public int health;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (gameObject.transform.position.y < -10)
		{
			Destroy(gameObject);
		}

	}
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ecosystem : MonoBehaviour
{
    [HideInInspector] public List<GameObject> foxes = new List<GameObject>();
    [HideInInspector] public List<GameObject> rabbits = new List<GameObject>();

    public int FoxesCount => foxes.Count;
    public int RabbitsCount => rabbits.Count;

	private void Start()
	{
		InvokeRepeating("UpdateGraph", 0f, 1f);
	}

	public void RemoveAnimal(GameObject animal)
    {
        if (animal.CompareTag("Fox"))
        {
            foxes.Remove(animal);
        }
        else
        {
            rabbits.Remove(animal);
        }      
    }

    public void AddAnimal(GameObject animal)
    {
        if (animal.CompareTag("Fox"))
        {
            foxes.Add(animal);
        }
        else
        {
            rabbits.Add(animal);
        }     
    }

    private void UpdateGraph()
    {
        Graph.Instance.AddRabbit(RabbitsCount);
		Graph.Instance.AddFox(FoxesCount);
	}

}

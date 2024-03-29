﻿using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
	public int seed;
	[Range(1, 8)]
	public int numLayers = 4;
	public float persistence = 0.5f;
	public float lacunarity = 2f;
	public float scale = 1f;
	public Vector2 offset;
}

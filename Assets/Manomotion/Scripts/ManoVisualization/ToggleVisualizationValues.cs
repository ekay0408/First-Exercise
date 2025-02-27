﻿using UnityEngine;
public class ToggleVisualizationValues : MonoBehaviour
{
	ManoVisualization _manoVisualization;

	private void Start()
	{
		_manoVisualization = GetComponent<ManoVisualization>();
	}

	/// <summary>
	/// Toggles the boolean of showing the background layer.
	/// </summary>
	public void ToggleShowBackgroundLayer()
	{
		_manoVisualization.Show_background = !_manoVisualization.Show_background;
	}

	/// <summary>
	/// Toggles the boolean value for showing the bounding box.
	/// </summary>
	public void ToggleBoundingBox()
	{
		_manoVisualization.Show_bounding_box = !_manoVisualization.Show_bounding_box;
	}
}
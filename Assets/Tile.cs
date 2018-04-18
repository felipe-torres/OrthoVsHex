using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// General definition of a tile. Can be square or hexagonal
/// </summary>
public class Tile : MonoBehaviour
{
	public bool occuppied = false;
	
	private void OnMouseUpAsButton()
	{
		if(!EventSystem.current.IsPointerOverGameObject())
			SelectTile();
	}

	public void SelectTile()
	{
		if(!occuppied)
		{
			occuppied = true;
			StructureLibrary.Instance.PlaceStructure(this.transform);
		}
	}
}

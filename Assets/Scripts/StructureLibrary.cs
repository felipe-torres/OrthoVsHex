using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StructureLibrary : MonoBehaviour
{
	public static StructureLibrary Instance;

	private int selectedStructure;
	public GameObject[] StructurePrefabs;
	public Transform StructureGroup;

	public Image StructureSelectionImage;

	private void Awake()
	{
		Instance = this;
	}

	public void SelectStructure(int id)
	{
		StructureSelectionImage.transform.SetParent(EventSystem.current.currentSelectedGameObject.transform, false);
		selectedStructure = id;
	}

	public void PlaceStructure(Transform t)
	{
		GameObject NewStructure = GameObject.Instantiate(StructurePrefabs[selectedStructure]);
		NewStructure.transform.SetParent(StructureGroup.transform);
		NewStructure.transform.position = t.position;
	}
}

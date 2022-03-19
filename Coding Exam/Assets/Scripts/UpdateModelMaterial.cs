using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script allows you to update the material of a game object that uses a skinned mesh renderer and multiple materials
///
/// </summary>
public class UpdateModelMaterial : MonoBehaviour
{
    public int index = 0;

    /// <summary>
    /// Updates the material on the skinned mesh renderer attached to this game object.
    /// You must specify the index with a previous function first.
    /// </summary>
    /// <param name="newMat"> The new material for the object </param>
    public void UpdateMaterial(Material newMat)
    {
        Material[] newMaterials = GetComponent<SkinnedMeshRenderer>().materials;
        newMaterials[index] = newMat;
        GetComponent<SkinnedMeshRenderer>().materials = newMaterials;
    }

    /// <summary>
    /// Updates the first material attached to the skinned mesh renderer
    /// </summary>
    /// <param name="newMat"> The new material for the object. </param>
    public void UpdateFirstMaterial(Material newMat)
    {
        GetComponent<SkinnedMeshRenderer>().material = newMat;
    }

    /// <summary>
    /// Chooses which material in the skinned mesh renderer this script can change.
    /// </summary>
    /// <param name="index"> The index of the material you would like to change in the skinned mesh renderer. </param>
    public void SetMaterialIndex(int index)
    {
        this.index = index;
    }
}

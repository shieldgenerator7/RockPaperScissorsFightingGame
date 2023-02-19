using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public new string name;
    [TextArea(2, 5)]
    public string description;
    [Range(1, 15)]
    public int maxHealth = 10;
    public List<Ability> abilities;

    /// <summary>
    /// Validate that this player is setup correctly
    /// </summary>
    /// <returns></returns>
    public bool validate()
    {
        //TODO: check that no abilities share the same combo
        //TODO: check that no combos have the exact same list
        return true;
    }
}

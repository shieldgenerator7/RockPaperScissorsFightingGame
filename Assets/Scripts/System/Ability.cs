using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    public new string name;
    [TextArea(2, 5)]
    [Tooltip("User-facing description of ability")]
    public string description;
    [Tooltip("Set to true to ignore combos and just passively test it")]
    public bool passive = false;
    [Tooltip("The list of combos that can activate this ability")]
    public List<Combo> combos;
    [TextArea(5, 50)]
    [Tooltip("The code that says what it does")]
    public string script;
}

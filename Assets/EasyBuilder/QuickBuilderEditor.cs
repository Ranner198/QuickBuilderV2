using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(QuickBuilder))]
public class QuickBuilderEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }



}

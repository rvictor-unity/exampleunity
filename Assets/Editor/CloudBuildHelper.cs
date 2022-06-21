#if UNITY_CLOUD_BUILD
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using UnityEditor;
using UnityEditor.Build;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;

using Unity.Notifications;

public class CloudBuildHelper : MonoBehaviour
{
    public static void PreExportDevelopment(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
        Debug.Log("executed dev pre-export");
    }

    public static void PreExportEnterprise(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
    }

    public static void PreExportProduction(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
    }

    public static void PreExportQA(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
    }

    private static T LoadScriptableObject<T>() where T : ScriptableObject
    {
        Type scriptableObjectType = typeof(T);
        T scriptableObject = default(T);
        string[] guids = AssetDatabase.FindAssets("t:" + scriptableObjectType);
        if (guids.Length >= 1)
        {
            if (guids.Length > 1)
                Debug.LogWarning("Found more than 1 " + scriptableObjectType + " in the project! Returning the first");

            string guidToLoad = guids[0];
            string path = AssetDatabase.GUIDToAssetPath(guidToLoad);
            scriptableObject = AssetDatabase.LoadAssetAtPath<T>(path);
        }
        else
        {
            Debug.LogWarning("Couldn't find any " + typeof(T) + " in the project, trying through Resources...");

            UnityEngine.Object[] vObjects = Resources.FindObjectsOfTypeAll(scriptableObjectType);
            if (vObjects.Length >= 1)
            {
                if (vObjects.Length > 1)
                    Debug.LogWarning("Found more than 1 " + scriptableObjectType + " in the project! Returning the first");

                scriptableObject = (T)vObjects[0];
            }
            else
            {
                Debug.LogError("Couldn't find any " + scriptableObjectType + " through Resources either!");
            }

        }
        
        return scriptableObject;
    }
}
#endif
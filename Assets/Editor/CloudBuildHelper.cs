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

public static class CloudBuildHelper
{
#if UNITY_CLOUD_BUILD
    public static void PreExportDevelopment(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
        Debug.Log($"---> The {nameof(CloudBuildHelper)}.{nameof(PreExportDevelopment)} script is running.");
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
#endif
}
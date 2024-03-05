using UnityEngine;

public static class EMDebugHelper
{
    public static void PrintInfo(string tag, string message)
    {
        Debug.Log($"[Info][{tag}] {message}");
    }

    public static void PrintError(string tag, string message)
    {
        Debug.LogError($"[Error][{tag}] {message}");
    }
}

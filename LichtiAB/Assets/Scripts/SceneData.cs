using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SceneData
{
     public static Vector3 playerPosition = Vector3.zero;
    public static string returnSceneName = "";
       public static void SetReturnScene(string sceneName)
    {
        returnSceneName = sceneName;
    }
}

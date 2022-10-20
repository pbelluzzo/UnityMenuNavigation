using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PedroBelluzzo.UnityMenuNavigation
{
    public class MenuSystemDebugger : MonoBehaviour
    {
        [SerializeField] private bool _enableLogs;

        public static void DebugLog(string message, GameObject sender) 
        {
            Debug.Log(message, sender);
        }

        public static void DebugLogWarning(string message, GameObject sender) 
        {
            Debug.LogWarning(message, sender);
        }

        public static void DebugLogError(string message, GameObject sender) 
        {
            Debug.LogError(message, sender);
        }
    }
}



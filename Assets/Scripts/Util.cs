using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Util
{
    /// <summary>
    ///     Helper function to ovoid having to define a couroutine every time want to call an action after a delay
    /// </summary>
    /// <param name="monoBehaviour"></param>
    /// <param name="time"></param>
    /// <param name="callback"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void DelayedCall(MonoBehaviour monoBehaviour, float time, Action callback)
    {
        monoBehaviour.StartCoroutine(ExecuteCall(time, callback));
    }

    /// <summary>
    ///     Executes callback after delay
    /// </summary>
    /// <param name="time"></param>
    /// <param name="callback"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IEnumerator ExecuteCall(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback?.Invoke();
    }
}

using UnityEngine;
using System.Collections;
using UnityEditor;

public class PlayTools{
    [MenuItem("CONTEXT/PlayerHealth/InitHeathAndSp")]
    static void InitHeathAndSpeed(MenuCommand cmd) {
        Debug.Log(cmd.context.GetType().FullName);
      CompleteProject.PlayerHealth health = cmd.context as CompleteProject.PlayerHealth;
        health.startingHealth = 200;
        health.flashSpeed = 10;

        Debug.Log("Init");
    }

    [MenuItem("CONTEXT/Rigidbody/Clean")]
    static void CleanMassAndGravity(MenuCommand cmd) {
        Rigidbody rgb = cmd.context as Rigidbody;
        rgb.mass = 0;
        rgb.useGravity = false;

    }


}

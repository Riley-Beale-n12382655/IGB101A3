using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    //Pickup and lvl completion
    public int currentPickups = 0;
    public int maxPickups = 0;
    public bool levelComplete = false;
    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    //Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }
    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    public Text pickupText;

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }
    //Loop for playing audio prox events
    private void PlayAudioSamples()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }
}


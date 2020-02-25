using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class oofNoise : MonoBehaviour
{

    public AudioClip oof;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = oof;
        source.playOnAwake = false;

        button.onClick.AddListener(() => playSound());
    }

    // Update is called once per frame
    void playSound()
    {
        source.PlayOneShot(oof);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour {

    private UnityEngine.Video.VideoPlayer videoPlayer;


    [SerializeField]
    private GvrAudioSource audioSource;

    public ParticleSystem particle;
    public GameObject points;

    void Start () {
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();


        if (videoPlayer.clip != null) 
        {
            videoPlayer.EnableAudioTrack (0, true);
        }
    }

    private void Update()
    {
        if(!videoPlayer.isPlaying)
        {
            audioSource.Stop();
            particle.Stop();
            points.SetActive(true);
        }
    }

    public void Play()
    {
        videoPlayer.Play();
        particle.Play();
        audioSource.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
        particle.Pause();
        audioSource.Pause();
    }

    public void Stop()
    {
        videoPlayer.Stop();
        particle.Stop();
        audioSource.Stop();
    }

    public void Restart()
    {
        Stop();
        Play();
    }
}
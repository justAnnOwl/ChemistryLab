using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class MyVideoPlayer : MonoBehaviour
{

    public GameObject playIcon;
    public VideoClip videoToPlay;
    public VideoPlayer videoPlayer;

   /* IEnumerator playyVideo() {

        // Add VideoPlayer to the GameObject
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        // Add AudioSource
    //    audioSource = gameObject.AddComponent<AudioSource>();

        // Disable Play on Awake for both Video and Audio
        videoPlayer.playOnAwake = false; 
        //audioSource.playOnAwake = false;

        // Set video to play then prepare Audio to prevent Buffering
        videoPlayer.clip = videoToPlay; 
       
        // Play Video
        videoPlayer.Play();

        // Play Sound
        //audioSource.Play();
    }*/
   public void MyPlayVideo(){
     //videoPlayer.frameReady += Prepare_frameReady;
        videoPlayer.Play();

    }
    public void MyStopVideo(){
        videoPlayer.Stop();
    }
/*private void Prepare_frameReady(VideoPlayer source, long frameIdx)
    {
        videoPlayer.Pause();
        videoPlayer.sendFrameReadyEvents = false;
    }*/
}

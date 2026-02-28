using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public AudioSource selectAudio;
    public AudioClip hoverAudio;

    public void HoverSound() => selectAudio.PlayOneShot(hoverAudio);
}

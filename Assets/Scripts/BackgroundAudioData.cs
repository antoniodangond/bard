using UnityEngine;

[CreateAssetMenu(fileName = "BackgroundAudioData", menuName = "Scriptable Objects/BackgroundAudioData")]
public class BackgroundAudioData : ScriptableObject
{
    public Sound BackgroundMusic;
    // Volume to set background music when player is in "Instrument" state
    public Sound BackgroundMusicUnderword;
    public Sound BackgroundMusicMausoleum;
    [Range (0f, 1f)]
    public float BackgroundMusicInstrumentVolume;
    // Volume to set background music when player is playing a Melody
    [Range (0f, 1f)]
    public float BackgroundMusicInstrumentMelodyVolume;
    // Volume to set background music when game is paused
    [Range (0f, 1f)]
    public float BackgroundMusicPauseVolume;
    public Sound OverworldAmbience;
    public AudioClip[] AmbienceBreaths;
    public RandomAudioManager RandomAmbienceBreaths;
    public AudioClip[] AmbienceFrogs;
    public RandomAudioManager RandomAmbienceFrogs;
}

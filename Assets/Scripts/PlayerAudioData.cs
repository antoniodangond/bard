using UnityEngine;

[CreateAssetMenu(fileName = "PlayerAudioData", menuName = "Scriptable Objects/PlayerAudioData")]
public class PlayerAudioData : ScriptableObject
{
    [Header("Footsteps")]
    public Sound[] Footsteps;
    [Range (0f, 1f)]
    public float MaxFootstepPitchVariation;
    [Range (0f, 1f)]
    public float MaxFootstepVolumeVariation;

    [Header("Instrument")]
    public Sound NoteA;
    public Sound NoteB;
    public Sound NoteC;
    public Sound NoteE;
    public Sound NoteF;
    public Sound Melody1;
    public Sound Melody2;
    // Time between last note of Melody trigger and Melody being played
    [Range (0f, 1f)]
    public float TimeBeforeMelody;
    // Time before player is moved from InstrumentMelody state to Default state
    [Range (0f, 10f)]
    public float MelodyCooldownTime;

    [Header("Combat")]
    public Sound[] AttackChords;
}

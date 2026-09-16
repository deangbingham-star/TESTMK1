using UnityEngine;
using Unity.Netcode.Components;

public class clientNetworkAnimator : NetworkAnimator
{
    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
}
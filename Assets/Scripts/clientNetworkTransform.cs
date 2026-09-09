using UnityEngine;
using Unity.Netcode.Components;

public class clientNetworkTransform : NetworkTransform
    {
    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
    }
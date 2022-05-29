using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ParticleSystem particle;

    public InputField inputField;
    private float inputValue;

    public void BeginCollision()
    {
        var coll = particle.collision;
        coll.enabled = true;
    }

    public void ChangeEmissionRate()
    {
        particle.emissionRate = inputValue;
    }
}
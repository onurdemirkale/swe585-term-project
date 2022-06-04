using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ParticleSystem particle;

    public InputField inputField;
    private float inputValue = 0;

    private bool collisionToggle = false;
    private bool triggerToggle = false;
    private bool prewarmToggle = false;

    // Prewarm allows creation of particles beforehand.
    public void EnablePrewarm()
    {   
        var main = particle.main;

        if(prewarmToggle)
        {
            main.prewarm = false;
            prewarmToggle = false;
        } 
        else 
        {
            main.prewarm = true;
            prewarmToggle = true;
        }
    }

    // Enable collision between the particles and the floor cube.
    public void ToggleCollision()
    {   
        var collision = particle.collision;

        if(collisionToggle)
        {
            collision.enabled = false;
            collisionToggle = false;
        } 
        else 
        {
            collision.enabled = true;
            collisionToggle = true;
        }
    }

    // Toggle trigger between the particles and the floor cube.
    // Once particles hit the floor when trigger is on, they 
    // are removed.
    public void ToggleTrigger()
    {
        var trigger = particle.trigger;

        if(triggerToggle)
        {
            trigger.enabled = false;
            triggerToggle = false;
        }
        else
        {
            trigger.enabled = true;
            triggerToggle = true;
        }

        
    }

    // Change the emission rate of the particles.
    public void SetEmissionRate()
    {   
        var inputText = inputField.text.ToString();
        inputValue = float.Parse(inputText);
        particle.emissionRate = inputValue;
    }
}
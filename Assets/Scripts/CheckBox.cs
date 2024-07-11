using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckBox : MonoBehaviour
{
    public TMP_Text charhp;
    public GameObject hint;

    public CharacterScript character;
    private IHealthHolder healthHolder;
    private IHealthModifier healthModifier;

    private void Start()
    {
        healthHolder = character as IHealthHolder;
    }

    void OnGUI()
    {
        if (healthModifier != null & Event.current.Equals(Event.KeyboardEvent(KeyCode.E.ToString())))
        {
            healthHolder.ChangeHp(healthModifier.HealthStep);

            charhp.text = healthHolder.HealthPoints.ToString();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        HealthModifier hm = col.GetComponent<HealthModifier>();
        if (col.GetComponent<HealthModifier>() != null)
        {
            healthModifier = hm;
            Interact(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        HealthModifier hm = col.GetComponent<HealthModifier>();
        if (col.GetComponent<HealthModifier>() != null)
        {
            healthModifier = null;
            Interact(false);
        }
    }

    public void Interact(bool active)
    {
        hint.SetActive(active);
    }
}

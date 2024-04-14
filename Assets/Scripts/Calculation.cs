using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculation : MonoBehaviour
{
    private int sifCounter = 0, spellSchools = 0, totalDamage = 0, spellDamage = 0, zeroSpells = 0, twoSpells = 0, threeSpells = 0, sixSpells = 0;

    public GameObject zero, two, three, six, score;
    private const string DAMAGEBASE = "Damage: ";

    private void Start()
    {
        zero.GetComponent<TextMeshProUGUI>().text = "0";
        two.GetComponent<TextMeshProUGUI>().text = "0";
        three.GetComponent<TextMeshProUGUI>().text = "0";
        six.GetComponent<TextMeshProUGUI>().text = "0";
    }
    private int SifCounter
    {
        get { return sifCounter; }
        set
        {
            sifCounter = value;
            CalculateDamage();
        }
    }

    private int SpellSchools
    {
        get { return spellSchools; }
        set
        {
            spellSchools = value;
            CalculateDamage();
        }
    }

    private int SpellDamage
    {
        get { return spellDamage; }
        set
        {
            spellDamage = value;
            CalculateDamage();
        }
    }

    public void CalculateDamage()
    {
        totalDamage = ((sifCounter * (spellSchools + 1)) * (zeroSpells + twoSpells + threeSpells + sixSpells)) + spellDamage;
        score.GetComponent<TextMeshProUGUI>().text = DAMAGEBASE + totalDamage.ToString();
    }

    public void SifSetter(int amount)
    {
        SifCounter = amount;
    }

    public void SpellSchoolSetter(int amount)
    {
        SpellSchools = amount;
    }

    public void SpellDamageAdding(int amount)
    {
        switch (amount)
        {
            case 0:
                zeroSpells++;
                zero.GetComponent<TextMeshProUGUI>().text = zeroSpells.ToString();
                SpellDamage += 0; //Forcing it to update the damage
                break;
            case 2:
                twoSpells++;
                two.GetComponent<TextMeshProUGUI>().text = twoSpells.ToString();
                SpellDamage += 2;
                break;
            case 3:
                threeSpells++;
                three.GetComponent<TextMeshProUGUI>().text = threeSpells.ToString();
                SpellDamage += 3;
                break;
            case 6:
                sixSpells++;
                six.GetComponent<TextMeshProUGUI>().text = sixSpells.ToString();
                SpellDamage += 6;
                break;
        }
    }

    public void SpellDamageSubtracting(int amount)
    {
        switch (amount)
        {
            case 0:
                if (zeroSpells == 0)
                {
                    return;
                }
                zeroSpells--;
                zero.GetComponent<TextMeshProUGUI>().text = zeroSpells.ToString();
                SpellDamage -= 0; //Forcing it to update the damage
                break;
            case 2:
                if (twoSpells == 0)
                {
                    return;
                }
                twoSpells--;
                two.GetComponent<TextMeshProUGUI>().text = twoSpells.ToString();
                SpellDamage -= 2;
                break;
            case 3:
                if (threeSpells == 0)
                {
                    return;
                }
                threeSpells--;
                three.GetComponent<TextMeshProUGUI>().text = threeSpells.ToString();
                SpellDamage -= 3;
                break;
            case 6:
                if (sixSpells == 0)
                {
                    return;
                }
                sixSpells--;
                six.GetComponent<TextMeshProUGUI>().text = sixSpells.ToString();
                SpellDamage -= 6;
                break;
        }
    }

    public void Reset()
    {
        zeroSpells = 0;
        twoSpells = 0;
        threeSpells = 0;
        sixSpells = 0;
        SpellDamage = 0;
        SifCounter = 0;
        SpellSchools = 0;
        zero.GetComponent<TextMeshProUGUI>().text = "0";
        two.GetComponent<TextMeshProUGUI>().text = "0";
        three.GetComponent<TextMeshProUGUI>().text = "0";
        six.GetComponent<TextMeshProUGUI>().text = "0";
        //Get all buttons in scene and set them to interactable
        foreach (Button button in FindObjectsOfType<Button>())
        {
            button.interactable = true;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    public int sifCounter, spellSchools, totalDamage, spells, spellDamage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalDamage = CalculateDamage(sifCounter, spellSchools, spells, spellDamage);
    }

    public int CalculateDamage(int sifCounter, int spellSchools, int spells, int spellDamage)
    {
        return ((sifCounter * (spellSchools + 1)) * spells) + spellDamage;
    }
}

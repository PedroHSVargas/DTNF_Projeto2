using System.Collections.Generic;
using UnityEngine;

public static class CalculaDano
{
    public static void Combate(Unidade user, Unidade target)
    {
        List<ISkill> skills = new List<ISkill>();
        skills.AddRange(user.GetComponentsInChildren<ISkill>());
        skills[Random.Range(0, skills.Count)].Play(user, target);


    }





}

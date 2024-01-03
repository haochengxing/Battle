using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SlgConstants
{
    public enum PlayState
    {
        Play=1,
        Fail=2,
        Winn=3,
        Null=4,
    }
    public enum SoldierState
    {
        Idle=1,
        Move=2,
        Skill=3,
        Win=4,
        Dead=5,
    }
    public enum SkillState
    {
        AtkStart = 1,
        Atk = 2,
        AtkEnd = 3,
        AtkWait = 4,
        Reload = 5,
        StandBy = 6,
        SkillEnd = 7,
    }
    public enum TroopPath
    {
        Up=0,
        Middle=1,
        Down=2,
    }
    public enum Camp
    {
        atk=1,
        def=2,
    }
    public enum Seat
    {
        left=1,
        right=2,
    }
    public enum RotationY
    {
        Left=90,
        Right=270,
    }
}

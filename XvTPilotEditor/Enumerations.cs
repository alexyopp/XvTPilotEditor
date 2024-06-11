namespace XvTPilotEditor
{
    //  List in order of BoP Craft Library (different from order shown on Pilot Statistics)
    //  * - ships not showing on Statistics page in game (in some cases, definitely should, cannot confirm that's true for all, though)
    public enum CraftType : uint
    {
        XWing = 0,
        YWing,
        AWing,
        BWing,                      // BoP
        Z95Headhunter,
        TieFighter,
        TieInterceptor,
        TieBomber,
        TieAdvanced,
        AssaultGunboat,
        TWing,
        R41Starchaser,
        Shuttle,
        EscortShuttle,
        StormtrooperTransport,
        AssaultTransport,
        EscortTransport,
        SystemPatrolCraft,
        CorellianCorvette,
        ModifiedCorvette,           // BoP
        NebulonBFrigate,
        ModifiedFrigate,            //*, BoP
        ImperialStarDestroyer,
        VictoryStarDestroyer,
        Interdictor,
        SuperStarDestroyer,         //*, BoP
        CalamariCruiser,            //*
        LightCalamariCruiser,       // BoP
        StrikeCruiser,
        ModifiedStrikeCruiser,      //*, BoP
        Dreadnaught,
        EscortCarrier,
        Tug,                        //*
        HeavyLifter,
        CombatUtilityVehicle,       //*
        CorellianTransport,
        MuurianTransport,           //*
        BulkFreighter,
        CargoFerry,
        ModularConveyor,
        MediumTransport,            //*, BoP
        ContainerClassA,
        ContainerClassB,            //*
        ContainerClassC,            //*
        ContainerClassD,
        ContainerClassE,
        ContainerClassF,
        ContainerClassG,            //*
        ContainerClassH,            //*
        ContainerClassI,            //*
        XQ1Platform,
        XQ2Platform,
        XQ3Platform,
        XQ4Platform,                //*
        XQ5Platform,
        XQ6Platform,
        Factory,                    //*
        AsteroidHangar,
        AsteroidLaserBattery,       //*
        AsteroidWarheadLauncher,    //*
        Shipyard,                   //*
        GunEmplacement,             //*
        RepairYard,                 //*
        CommSat,                    // Listed twice?
        MineTypeA,
        MineTypeB,
        MineTypeC,
        Probe,                      //*
        NavBuoy1,
        NavBuoy2                    // Not in Craft Library
    }

    public enum Faction : uint
    {
        Rebel = 0,
        Imperial
    }

    public enum GameMode : uint
    {
        Singleplayer = 0,
        Multiplayer,
    }

    public enum MissionCollection : uint
    {
        Tournament = 0,
        Battle,
        Campaign
    }

    public enum MissionEvaluation : uint
    {
        Empty = 0,
        Bad,            // Reprimand             or Lead
        Adequate,       // Adequate Performance  or Copper
        Fair,           // Fair Performance      or Nickel
        Good,           // Good Perfromance      or Bronze
        Excellent,      // Excellent Performance or Silver
        Super           // Top Performance       or Gold
    }

    /*  Alternate Mission Evaluation enumerations
     *  Hoping to use the above combined list; are melee missions really different from combat missions just because they're awarded a ribbon instead of a plaque?
    public enum Ribbons : uint
    {
        Empty = 0,
        Reprimand,
        AdequatePerformance,
        FairPerformance,
        GoodPerformance,
        ExcellentPerformance,
        TopPerformance
    }

    public enum Plaques : uint
    {
        Empty = 0,
        Lead,
        Copper,
        Nickel,
        Bronze,
        Silver,
        Gold
    }
    */

    public enum MissionType : uint
    {
        Exercise = 0,
        Melee,
        Combat
    }

    public enum Page : uint
    {
        Statistics = 0,
        RatingHistory,
        MissionAchievements
    }

    public enum PilotRating : uint  //  i.e., Pilot Rank
    {
        Trainee = 0,
        FlightCadet,
        Officer4thClass,
        Officer3rdClass,
        Officer2ndClass,
        Officer1stClass,
        Veteran4thGrade,
        Veteran3rdGrade,
        Veteran2ndGrade,
        Veteran1stGrade,
        Ace4thLevel,
        Ace3rdLevel,
        Ace2ndLevel,
        Ace1stLevel,
        TopAce4thOrder,
        TopAce3rdOrder,
        TopAce2ndOrder,
        TopAce1stOrder,
        Jedi4thDegree,
        Jedi3rdDegree,
        Jedi2ndDegree,
        Jedi1stDegree,
        JediMaster
    }

    /*  Alternate ordering of Pilot Ratings
     *  Hoping to use the above list, so we can do things like JediMaster > Trainee
    public enum PilotRating : uint
    {
        JediMaster = 0,
        Jedi1stDegree,
        Jedi2ndDegree,
        Jedi3rdDegree,
        Jedi4thDegree,
        TopAce1stOrder,
        TopAce2ndOrder,
        TopAce3rdOrder,
        TopAce4thOrder,
        Ace1stLevel,
        Ace2ndLevel,
        Ace3rdLevel,
        Ace4thLevel,
        Veteran1stGrade,
        Veteran2ndGrade,
        Veteran3rdGrade,
        Veteran4thGrade,
        Officer1stClass,
        Officer2ndClass,
        Officer3rdClass,
        Officer4thClass,
        FlightCadet,
        Trainee
    }*/
}

using System.ComponentModel;

namespace XvTPilotEditor
{
    public static class Constants
    {   public const uint PILOT_NAME_MAX_LENGTH = 12;           // ?
        public const uint RATING_HISTORY_ENTRIES = 100;         // ?
        public const uint MAX_MISSIONS_PER_FACTION = 200;       // ?
        public const uint MAX_CONNECTED_PLAYERS = 8;
    }

    //  List in order of BoP Craft Library (different from order shown on Pilot Statistics)
    //  * - ships not showing on Statistics page in game (in some cases, definitely should, cannot confirm that's true for all, though)
    public enum CraftType : uint
    {
        [Description("X-Wing")]                     XWing = 0,
        [Description("Y-Wing")]                     YWing,
        [Description("A-Wing")]                     AWing,
        [Description("B-Wing")]                     BWing,                      // BoP
        [Description("Z-95 Headhunter")]            Z95Headhunter,
        [Description("TIE Fighter")]                TieFighter,
        [Description("TIE Interceptor")]            TieInterceptor,
        [Description("TIE Bomber")]                 TieBomber,
        [Description("TIE Advanced")]               TieAdvanced,
        [Description("Assault Gunboat")]            AssaultGunboat,
        [Description("T-Wing")]                     TWing,
        [Description("R-41 Starchaser")]            R41Starchaser,
        [Description("Shuttle")]                    Shuttle,
        [Description("Escort Shuttle")]             EscortShuttle,
        [Description("Stormtrooper Transport")]     StormtrooperTransport,
        [Description("Assault Transport")]          AssaultTransport,
        [Description("Escort Transport")]           EscortTransport,
        [Description("System Patrol Craft")]        SystemPatrolCraft,
        [Description("Corellian Corvette")]         CorellianCorvette,
        [Description("Modified Corvette")]          ModifiedCorvette,           // BoP
        [Description("Nebulon-B Frigate")]          NebulonBFrigate,
        [Description("Modified Frigate")]           ModifiedFrigate,            //*, BoP
        [Description("Imperial Star Destroyer")]    ImperialStarDestroyer,
        [Description("Victory Star Destroyer")]     VictoryStarDestroyer,
        [Description("Interdictor")]                Interdictor,
        [Description("Super Star Destroyer")]       SuperStarDestroyer,         //*, BoP
        [Description("Calamari Cruiser")]           CalamariCruiser,            //*
        [Description("Light Calarmari Cruiser")]    LightCalamariCruiser,       // BoP
        [Description("Strike Cruiser")]             StrikeCruiser,
        [Description("Modified Strike Cruiser")]    ModifiedStrikeCruiser,      //*, BoP
        [Description("Dreadnaught")]                Dreadnaught,
        [Description("Escort Carrier")]             EscortCarrier,
        [Description("Tug")]                        Tug,                        //*
        [Description("Heavy Lifter")]               HeavyLifter,
        [Description("Combat Utility Vehicle")]     CombatUtilityVehicle,       //*
        [Description("Corellian Transport")]        CorellianTransport,
        [Description("Muurian Transport")]          MuurianTransport,           //*
        [Description("Bulk Freighter")]             BulkFreighter,
        [Description("Cargo Ferry")]                CargoFerry,
        [Description("Modular Conveyor")]           ModularConveyor,
        [Description("Medium Transport")]           MediumTransport,            //*, BoP
        [Description("Container Class A")]          ContainerClassA,
        [Description("Container Class B")]          ContainerClassB,            //*
        [Description("Container Class C")]          ContainerClassC,            //*
        [Description("Container Class D")]          ContainerClassD,
        [Description("Container Class E")]          ContainerClassE,
        [Description("Container Class F")]          ContainerClassF,
        [Description("Container Class G")]          ContainerClassG,            //*
        [Description("Container Class H")]          ContainerClassH,            //*
        [Description("Container Class I")]          ContainerClassI,            //*
        [Description("XQ1 Platform")]               XQ1Platform,
        [Description("XQ2 Platform")]               XQ2Platform,
        [Description("XQ3 Platform")]               XQ3Platform,
        [Description("XQ4 Platform")]               XQ4Platform,                //*
        [Description("XQ5 Platform")]               XQ5Platform,
        [Description("XQ6 Platform")]               XQ6Platform,
        [Description("Factory")]                    Factory,                    //*
        [Description("Asteroid Hangar")]            AsteroidHangar,
        [Description("Asteroid Laser Battery")]     AsteroidLaserBattery,       //*
        [Description("Asteroid Warhead Launcher")]  AsteroidWarheadLauncher,    //*
        [Description("Shipyard")]                   Shipyard,                   //*
        [Description("Gun Emplacement")]            GunEmplacement,             //*
        [Description("Repair Yard")]                RepairYard,                 //*
        [Description("Comm Sat")]                   CommSat,                    // Listed twice?
        [Description("Mine Type A")]                MineTypeA,
        [Description("Mine Type B")]                MineTypeB,
        [Description("Mine Type C")]                MineTypeC,
        [Description("Probe")]                      Probe,                      //*
        [Description("Nav Buoy 1")]                 NavBuoy1,
        [Description("Nav Buoy 2")]                 NavBuoy2                    // Not in Craft Library
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
        [Description("Trainee")]                Trainee = 0,
        [Description("Flight Cadet")]           FlightCadet,
        [Description("Officer 4th Class")]      Officer4thClass,
        [Description("Officer 3rd Class")]      Officer3rdClass,
        [Description("Officer 2nd Class")]      Officer2ndClass,
        [Description("Officer 1st Class")]      Officer1stClass,
        [Description("Veteran 4th Grade")]      Veteran4thGrade,
        [Description("Veteran 3rd Grade")]      Veteran3rdGrade,
        [Description("Veteran 2nd Grade")]      Veteran2ndGrade,
        [Description("Veteran 1st Grade")]      Veteran1stGrade,
        [Description("Ace 4th Level")]          Ace4thLevel,
        [Description("Ace 3rd Level")]          Ace3rdLevel,
        [Description("Ace 2nd Level")]          Ace2ndLevel,
        [Description("Ace 1st Level")]          Ace1stLevel,
        [Description("Top Ace 4th Order")]      TopAce4thOrder,
        [Description("Top Ace 3rd Order")]      TopAce3rdOrder,
        [Description("Top Ace 2nd Order")]      TopAce2ndOrder,
        [Description("Top Ace 1st Order")]      TopAce1stOrder,
        [Description("Jedi 4th Degree")]        Jedi4thDegree,
        [Description("Jedi 3rd Degree")]        Jedi3rdDegree,
        [Description("Jedi 2nd Degree")]        Jedi2ndDegree,
        [Description("Jedi 1st Degree")]        Jedi1stDegree,
        [Description("Jedi Master")]            JediMaster
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

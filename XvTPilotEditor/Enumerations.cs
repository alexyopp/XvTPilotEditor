using System.ComponentModel;

namespace XvTPilotEditor
{
    public static class Constants
    {   public const uint PILOT_NAME_MAX_LENGTH = 12;
        public const uint PILOT_RATING_NAME_MAX_LENGTH = 32;
        public const uint RATING_HISTORY_ENTRIES = 100;         // TODO: Confirm this is correct
        public const uint MAX_MISSIONS_PER_FACTION = 200;       // TODO: Confirm this is correct
        public const uint MAX_CONNECTED_PLAYERS = 8;
        public const uint MAX_TEAMS = 10;
        public const uint MAX_FLIGHT_GROUPS = 48;
        public const uint PLT_GAME_NAME_MAX_LENGTH = 22;        // TODO: Confirm this is correct (and not actually 32 like it seems to be in Pl2)
        public const uint PL2_GAME_NAME_MAX_LENGTH = 32;
    }

    // TODO: Confirm accuracy of list (right now too long for vanilla XvT, but this could be correct for BoP
    // List in the order used in YOGEME.  Note that it doesn't distinguish between BoP and vanilla; I've tried to indicate where I know ships are BoP specific, but I wouldn't consider this exhaustive yet.
    public enum CraftType : uint
    {
        [Description("None")]                       None = 0,
        [Description("X-Wing")]                     XWing,
        [Description("Y-Wing")]                     YWing,
        [Description("A-Wing")]                     AWing,
        [Description("B-Wing")]                     BWing,                      // BoP
        [Description("TIE Fighter")]                TieFighter,
        [Description("TIE Interceptor")]            TieInterceptor,
        [Description("TIE Bomber")]                 TieBomber,
        [Description("TIE Advanced")]               TieAdvanced,
        [Description("*TIE Defender")]              TieDefender,                // Only in YOGEME, not in Craft Library or Statistics page, starred (*) in YOGEME, not sure why
        [Description("Unused10")]                   Unused10,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Unused11")]                   Unused11,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("*Missile Boat")]              MissileBoat,                // Only in YOGEME, not in Craft Library or Statistics page, starred (*) in YOGEME, not sure why
        [Description("T-Wing")]                     TWing,
        [Description("Z-95 Headhunter")]            Z95Headhunter,
        [Description("R-41 Starchaser")]            R41Starchaser,
        [Description("Assault Gunboat")]            AssaultGunboat,
        [Description("Shuttle")]                    Shuttle,                    // "Lambda Shuttle" in YOGEME
        [Description("Escort Shuttle")]             EscortShuttle,              // "Delta Escort Shuttle" in YOGEME
        [Description("System Patrol Craft")]        SystemPatrolCraft,          // "IPV Patrol Craft" in YOGEME
        [Description("*Scout Craft")]               ScoutCraft,                 // Only in YOGEME, not in Craft Library or Statistics page, starred (*) in YOGEME, not sure why
        [Description("Stormtrooper Transport")]     StormtrooperTransport,      // "Delta Transport" in YOGEME
        [Description("Assault Transport")]          AssaultTransport,           // "Gamma Assault Transport" in YOGEME
        [Description("Escort Transport")]           EscortTransport,            // "Beta Escort Transport" in YOGEME
        [Description("Tug")]                        Tug,                        // Not displayed on Statistics page
        [Description("Combat Utility Vehicle")]     CombatUtilityVehicle,       // Not displayed on Statistics page
        [Description("Container Class A")]          ContainerClassA,
        [Description("Container Class B")]          ContainerClassB,            // Not displayed on Statistics page
        [Description("Container Class C")]          ContainerClassC,            // Not displayed on Statistics page
        [Description("Container Class D")]          ContainerClassD,
        [Description("Heavy Lifter")]               HeavyLifter,
        [Description("Unused31")]                   Unused31,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Bulk Freighter")]             BulkFreighter,
        [Description("Cargo Ferry")]                CargoFerry,
        [Description("Modular Conveyor")]           ModularConveyor,
        [Description("*Container Transport")]       ContainerTransport,         // Only in YOGEME, not in Craft Library or Statistics page, starred (*) in YOGEME, not sure why
        [Description("Medium Transport")]           MediumTransport,            // BoP, Not displayed on Statistics page
        [Description("Muurian Transport")]          MuurianTransport,           // Not displayed on Statistics page, "Murrian Transport" in YOGEME, TODO: Confirm the correct spelling
        [Description("Corellian Transport")]        CorellianTransport,
        [Description("Unused39")]                   Unused39,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Corellian Corvette")]         CorellianCorvette,
        [Description("Modified Corvette")]          ModifiedCorvette,           // BoP
        [Description("Nebulon-B Frigate")]          NebulonBFrigate,
        [Description("Modified Frigate")]           ModifiedFrigate,            // BoP, Not displayed on Statistics page
        [Description("*C-3 Passenger Liner")]       C3PassengerLiner,           // Only in YOGEME, not in Craft Library or Statistics page, starred (*) in YOGEME, not sure why
        [Description("*Carrack Cruiser")]           CarrackCruiser,             // Only in YOGEME, not in Craft Library or Statistics page, starred (*) in YOGEME, not sure why
        [Description("Strike Cruiser")]             StrikeCruiser,
        [Description("Escort Carrier")]             EscortCarrier,
        [Description("Dreadnaught")]                Dreadnaught,
        [Description("Calamari Cruiser")]           CalamariCruiser,            // Not displayed on Statistics page, "MC80a Cruiser" in YOGEME
        [Description("Light Calarmari Cruiser")]    LightCalamariCruiser,       // BoP, "MC40a Light Cruiser" in YOGEME
        [Description("Interdictor")]                Interdictor,
        [Description("Victory Star Destroyer")]     VictoryStarDestroyer,
        [Description("Imperial Star Destroyer")]    ImperialStarDestroyer,      // "Imperator Star Destroyer" in YOGEME
        [Description("Super Star Destroyer")]       SuperStarDestroyer,         // BoP, Not displayed on Statistics page, "Executor Star Destroyer" in YOGEME
        [Description("Container Class E")]          ContainerClassE,
        [Description("Container Class F")]          ContainerClassF,
        [Description("Container Class G")]          ContainerClassG,            // Not displayed on Statistics page
        [Description("Container Class H")]          ContainerClassH,            // Not displayed on Statistics page
        [Description("Container Class I")]          ContainerClassI,            // Not displayed on Statistics page
        [Description("XQ1 Platform")]               XQ1Platform,                // "Platform A" in YOGEME
        [Description("XQ2 Platform")]               XQ2Platform,                // "Platform B" in YOGEME
        [Description("XQ3 Platform")]               XQ3Platform,                // "Platform C" in YOGEME
        [Description("XQ4 Platform")]               XQ4Platform,                // Not displayed on Statistics page, "Platform D" in YOGEME
        [Description("XQ5 Platform")]               XQ5Platform,                // "Platform E" in YOGEME
        [Description("XQ6 Platform")]               XQ6Platform,                // "Platform F" in YOGEME
        [Description("Asteroid Hangar")]            AsteroidHangar,             // TODO: Confirm this is "Asteroid R&D Facility" in YOGEME
        [Description("Asteroid Laser Battery")]     AsteroidLaserBattery,       // Not displayed on Statistics page, "Ast. Laser Battery" in YOGEME
        [Description("Asteroid Warhead Launcher")]  AsteroidWarheadLauncher,    // Not displayed on Statistics page, "Ast. Warhead Battery" in YOGEME
        [Description("Factory")]                    Factory,                    // Not displayed on Statistics page, "X/7 Factory" in YOGEME
        [Description("Comm Sat")]                   CommSat,                    // "Satellite 1" in YOGEME
        [Description("Satellite 2")]                Satellite2,
        [Description("Unused71")]                   Unused71,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously) and we appear to be off-sync now?
        [Description("Unused72")]                   Unused72,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Unused73")]                   Unused73,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Mine Type A")]                MineTypeA,                  // "Mine A" in YOGEME
        [Description("Mine Type B")]                MineTypeB,                  // "Mine B" in YOGEME
        [Description("Mine Type C")]                MineTypeC,                  // "Mine C" in YOGEME
        [Description("Gun Emplacement")]            GunEmplacement,             // Not displayed on Statistics page
        [Description("Unused78")]                   Unused78,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Probe")]                      Probe,                      // Not displayed on Statistics page, "Probe A" in YOGEME
        [Description("Probe B")]                    ProbeB,                     // Only in YOGEME, not in Craft Library or Statistics page
        [Description("Unused81")]                   Unused81,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Nav Buoy 1")]                 NavBuoy1,
        [Description("Nav Buoy 2")]                 NavBuoy2,                   // Not in Craft Library
        [Description("Unused84")]                   Unused84,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Asteroid Field")]             AsteroidField,              // Only in YOGEME, not in Craft Library or Statistics page
        [Description("Planet")]                     Planet,                     // Only in YOGEME, not in Craft Library or Statistics page
        [Description("Unused87")]                   Unused87,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Unused88")]                   Unused88,                   // Only in YOGEME, not in Craft Library or Statistics page, (obviously)
        [Description("Shipyard")]                   Shipyard,                   // Not displayed on Statistics page
        [Description("Repair Yard")]                RepairYard,                 // Not displayed on Statistics page
        [Description("Modified Strike Cruiser")]    ModifiedStrikeCruiser,      // BoP, Not displayed on Statistics page
    }

    /* TODO: Remove this list when confirmed the other is the correct one
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
    }*/

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
        MissionAchievements,
        CombinedRecord,
        PltRecord
    }

    // TODO: Confirm this enumeration is consistent with the game's ordering
    public enum PilotRating : uint  //  i.e., Pilot Rank
    {
        [Description("TargetDrone")]            TargetDrone = 0,
        [Description("GroundCrew")]             GroundCrew,
        [Description("Trainee")]                Trainee,
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

    // TODO: Confirm this enumeration is consistent with the game's ordering
    public enum AIRank : uint
    {
        [Description("Novice")]     Novice = 0,
        [Description("Officer")]    Officer,
        [Description("Veteran")]    Veteran,
        [Description("Ace")]        Ace,
        [Description("Top Ace")]    TopAce,
        [Description("Jedi")]       Jedi
    }
}

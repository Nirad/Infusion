﻿using UltimaRX.Packets;

public static class ItemTypes
{
    public static readonly ModelId Hatchet = (ModelId) 0x0F44;
    public static readonly ModelId Hatchet2 = (ModelId) 0x0F43;
    public static readonly ModelId CopperExecutionersAxe = (ModelId)0x0F45;
    public static readonly ModelId CopperExecutionersAxe2 = (ModelId)0x0F46;
    public static readonly ModelId CopperVikingSword = (ModelId) 0x13B9;
    public static readonly ModelId VeriteVikingSword = (ModelId) 0x13BA;
    public static readonly ModelId Dagger = (ModelId) 0x0F51;

    public static readonly ModelId Corpse = (ModelId) 0x2006;

    public static readonly ModelId PickAxe = (ModelId) 0xE86;

    public static readonly ModelId FishingPole = (ModelId) 0x0DBF;

    public static readonly ModelId[] Hatchets = {Hatchet, Hatchet2, CopperExecutionersAxe, CopperExecutionersAxe2};
    public static readonly ModelId[] Knives = {CopperVikingSword, VeriteVikingSword, Dagger};

    public static readonly ModelId Fish1 = (ModelId) 0x09CF;
    public static readonly ModelId Fish2 = (ModelId) 0x09CD;
    public static readonly ModelId Fish3 = (ModelId) 0x09CC;
    public static readonly ModelId Fish4 = (ModelId) 0x09CE;

    public static readonly ModelId[] Fishes = {Fish1, Fish2, Fish3, Fish4};

    public static readonly ModelId RawFishSteak = (ModelId) 0x097A;

    public static readonly ModelId Feathers = (ModelId) 0x1BD1;
    public static readonly ModelId Bird = (ModelId) 0x0006;
    public static readonly ModelId RippadbleBody = (ModelId) 0x2006;
    public static readonly ModelId RawBird = (ModelId) 0x09B9;
    public static readonly ModelId CookedBird = (ModelId) 0x09B7;
    public static readonly ModelId RawRibs = (ModelId) 0x09F1;
    public static readonly ModelId Ribs = (ModelId) 0x09F2;

    public static readonly ModelId Rabbit = (ModelId) 0x00CD;

    public static readonly ModelId Sheep = (ModelId) 0x00CF;

    public static readonly ModelId Cow = (ModelId) 0x00E7;
    public static readonly ModelId Cow2 = (ModelId) 0x00D8;
    public static readonly ModelId Rat = (ModelId) 0x00EE;
    public static readonly ModelId Dog = (ModelId) 0x00D9;

    public static readonly ModelId[] MassKillSubjects = {Bird, Rabbit, Sheep, Rat, Cow, Cow2, Dog};
    public static readonly ModelId[] RippableBodies = {RippadbleBody};

    public static readonly ModelId[] RawFood = {RawBird, RawFishSteak, RawRibs};
    public static readonly ModelId[] Food = {Ribs, CookedBird};

    public static readonly ModelId Campfire = (ModelId) 0x0DE3;
    public static readonly ModelId Forge = (ModelId)0x0FB1;
    public static readonly ModelId Forge2 = (ModelId)0x198E;

    public static readonly ModelId[] CookingPlaces = {Campfire, Forge, Forge2};

    public static readonly ModelId BackPack = (ModelId) 0xE75;

    public static readonly ModelId OpenWoodenDoor = (ModelId) 0x06E6;
    public static readonly ModelId ClosedWoodenDoor = (ModelId) 0x06E5;
    public static readonly ModelId OpenSteelDoor = (ModelId) 0x0680;
    public static readonly ModelId OpenSteelDoor2 = (ModelId) 0x067E;
    public static readonly ModelId ClosedSteelDoor = (ModelId) 0x067F;
    public static readonly ModelId ClosedSteelDoor2 = (ModelId) 0x067D;

    public static readonly ModelId[] Doors = {OpenWoodenDoor, ClosedWoodenDoor, OpenSteelDoor, ClosedSteelDoor};
    public static readonly ModelId[] ClosedDoors = {ClosedSteelDoor, ClosedSteelDoor2, ClosedWoodenDoor};
    public static readonly ModelId[] OpenDoors = {OpenSteelDoor, OpenSteelDoor2, OpenWoodenDoor};

    public static readonly ModelId PileOfHides = (ModelId) 0x1078;
    public static readonly ModelId Furs = (ModelId) 0x11F6;
    public static readonly ModelId Logs = (ModelId) 0x1BDD;

    public static readonly ModelId PotionKeg = (ModelId) 0x1AD6;
    public static readonly Color NightSightKegColor = (Color) 0x0980;
    public static readonly ModelId Bottle = (ModelId) 0x0F0E;
    public static readonly Color EmptyBottleColor = (Color) 0x0000;
    public static readonly Color GreaterHealBottleColor = (Color) 0x0160;

    public static readonly ModelId HouseMenu = (ModelId) 0x0BD1;

    public static readonly ModelId Torso1 = (ModelId) 0x1DAD;
    public static readonly ModelId Torso2 = (ModelId) 0x1CEB;
    public static readonly ModelId Torso3 = (ModelId) 0x1DB2;
    public static readonly ModelId Torso4 = (ModelId)0x1CE3;
    public static readonly ModelId Torso5 = (ModelId)0x1DA2;
    public static readonly ModelId Torso6 = (ModelId)0x1CEE;
    public static readonly ModelId Torso7 = (ModelId)0x1CEF;
    public static readonly ModelId Torso8 = (ModelId)0x1CE4;

    public static readonly ModelId[] Torsos = new ModelId[] {Torso1, Torso2, Torso3, Torso4, Torso5, Torso6, Torso7, Torso8,
        (ModelId)0x1DA3, (ModelId)0x1DA1, (ModelId)0x1D9F, (ModelId) 0x1DA0, (ModelId)0x1CE7, (ModelId)0x1CE2, (ModelId)0x1CEC, (ModelId)0x1CE8, (ModelId)0x1CE0, (ModelId)0x1CDD, (ModelId)0x1CE5, (ModelId)0x1CE1 };

    public static readonly ModelId Torch = (ModelId) 0x0F64;
}
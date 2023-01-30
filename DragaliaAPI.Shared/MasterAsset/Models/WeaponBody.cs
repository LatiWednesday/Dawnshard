﻿using DragaliaAPI.Shared.Definitions.Enums;

namespace DragaliaAPI.Shared.MasterAsset.Models;

/// <summary>
/// Weapon body MasterAsset model.
/// </summary>
/// <param name="Id">Unique weapon ID.</param>
/// <param name="WeaponType">Weapon type (sword, bow, etc...)</param>
/// <param name="Rarity">Weapon rarity.</param>
/// <param name="ElementalType">Weapon element.</param>
/// <param name="MaxLimitOverCount">Max unbind count.</param>
/// <param name="MaxEquipableCount">Max copy count/</param>
/// <param name="BaseHp"></param>
/// <param name="MaxHp1"></param>
/// <param name="MaxHp2"></param>
/// <param name="MaxHp3"></param>
/// <param name="BaseAtk"></param>
/// <param name="MaxAtk1"></param>
/// <param name="MaxAtk2"></param>
/// <param name="MaxAtk3"></param>
/// <param name="LimitOverCountPartyPower1"></param>
/// <param name="LimitOverCountPartyPower2"></param>
/// <param name="CrestSlotType1BaseCount"></param>
/// <param name="CrestSlotType1MaxCount"></param>
/// <param name="CrestSlotType2BaseCount"></param>
/// <param name="CrestSlotType2MaxCount"></param>
/// <param name="CrestSlotType3BaseCount"></param>
/// <param name="CrestSlotType3MaxCount"></param>
/// <param name="WeaponPassiveAbilityGroupId"></param>
/// <param name="WeaponBodyBuildupGroupId"></param>
/// <param name="MaxWeaponPassiveCharaCount">Seems to be 0/1 for bonus available/unavailable respectively.</param>
/// <param name="WeaponPassiveEffHp">Weapon bonus HP magnitude</param>
/// <param name="WeaponPassiveEffAtk">Weapon bonus Str magnitude</param>
/// <param name="RewardWeaponSkinId1"></param>
/// <param name="RewardWeaponSkinId2"></param>
/// <param name="RewardWeaponSkinId3"></param>
/// <param name="RewardWeaponSkinId4"></param>
/// <param name="RewardWeaponSkinId5"></param>
public record WeaponBody(
    WeaponBodies Id,
    WeaponTypes WeaponType,
    int Rarity,
    UnitElement ElementalType,
    int MaxLimitOverCount,
    int MaxEquipableCount,
    int BaseHp,
    int MaxHp1,
    int MaxHp2,
    int MaxHp3,
    int BaseAtk,
    int MaxAtk1,
    int MaxAtk2,
    int MaxAtk3,
    int LimitOverCountPartyPower1,
    int LimitOverCountPartyPower2,
    int CrestSlotType1BaseCount,
    int CrestSlotType1MaxCount,
    int CrestSlotType2BaseCount,
    int CrestSlotType2MaxCount,
    int CrestSlotType3BaseCount,
    int CrestSlotType3MaxCount,
    int WeaponPassiveAbilityGroupId,
    int WeaponBodyBuildupGroupId,
    int MaxWeaponPassiveCharaCount,
    float WeaponPassiveEffHp,
    float WeaponPassiveEffAtk,
    int RewardWeaponSkinId1,
    int RewardWeaponSkinId2,
    int RewardWeaponSkinId3,
    int RewardWeaponSkinId4,
    int RewardWeaponSkinId5
);
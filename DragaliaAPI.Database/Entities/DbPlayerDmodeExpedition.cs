﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DragaliaAPI.Shared.Definitions.Enums;
using Microsoft.EntityFrameworkCore;

namespace DragaliaAPI.Database.Entities;

[PrimaryKey(nameof(DeviceAccountId))]
public class DbPlayerDmodeExpedition : IDbHasAccountId
{
    /// <inheritdoc />
    public virtual DbPlayer? Owner { get; set; }

    /// <inheritdoc />
    [ForeignKey(nameof(Owner))]
    [Required]
    public required string DeviceAccountId { get; set; }

    [Column("CharaId1")]
    public Charas CharaId1 { get; set; }

    [Column("CharaId2")]
    public Charas CharaId2 { get; set; }

    [Column("CharaId3")]
    public Charas CharaId3 { get; set; }

    [Column("CharaId4")]
    public Charas CharaId4 { get; set; }

    [Column("StartTime")]
    public DateTimeOffset StartTime { get; set; }

    [Column("State")]
    public ExpeditionState State { get; set; } = ExpeditionState.Waiting;

    [Column("TargetFloor")]
    public int TargetFloor { get; set; }

    public void Clear()
    {
        CharaId1 = 0;
        CharaId2 = 0;
        CharaId3 = 0;
        CharaId4 = 0;
    }
}

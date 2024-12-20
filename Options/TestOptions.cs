﻿namespace Options;

public class TestOptions
{
    /// <summary>
    /// this is boolean option
    /// </summary>
    public bool? ThisIsBoolOption { get; set; }

    /// <summary>
    /// this is string option
    /// </summary>
    public string? StringOption { get; set; }

    /// <summary>
    /// this is int option
    /// </summary>
    public int? IntOption { get; set; }

    /// <summary>
    /// this is decimal option
    /// </summary>
    public decimal? DecimalOption { get; set; }

    /// <summary>
    /// this is float option
    /// </summary>
    public float? FloatOption { get; set; }

    /// <summary>
    /// this is short option
    /// </summary>
    public short? ShortOption { get; set; }

    /// <summary>
    /// this is long option
    /// </summary>
    public long? LongOption { get; set; }

    /// <summary>
    /// this is timespan option
    /// </summary>
    public TimeSpan? TimespanOption { get; set; }

    /// <summary>
    /// this is datetime option
    /// </summary>
    public DateTime? DateTimeOption { get; set; }
}

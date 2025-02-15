﻿using System;

namespace ClosedXML.Excel
{
    [Flags]
    public enum XLClearOptions
    {
        Contents                = 1 << 0,
        NormalFormats           = 1 << 2,
        ConditionalFormats      = 1 << 3,
        Comments                = 1 << 4,
        DataValidation          = 1 << 5,
        MergedRanges            = 1 << 6,
        Sparklines              = 1 << 7,

        AllFormats = NormalFormats | ConditionalFormats,
        AllContents = Contents | Comments,
        All = Contents | NormalFormats | ConditionalFormats | Comments | DataValidation | MergedRanges | Sparklines
    }

    internal static class XLClearOptionsExtensions
    {
        public static XLCellsUsedOptions ToCellsUsedOptions(this XLClearOptions options)
        {
            return (XLCellsUsedOptions)options;
        }
    }
}

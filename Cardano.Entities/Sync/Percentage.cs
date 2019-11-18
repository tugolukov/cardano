﻿namespace Cardano.Entities.Sync
{
    /// <summary>
    /// The sync percentage, from 0% to 100%.
    /// </summary>
    public class Percentage : SyncBase
    {
        /// <inheritdoc />
        public Percentage() => Unit = "percent";
    }
}
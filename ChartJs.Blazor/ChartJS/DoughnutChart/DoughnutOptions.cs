﻿
namespace ChartJs.Blazor.ChartJS.DoughnutChart
{
    using System;
    using ChartJs.Blazor.ChartJS.Common;
    using ChartJs.Blazor.ChartJS.Common.Properties;

    /// <summary>
    /// The options-subconfig of a <see cref="DoughnutChartConfig"/>.
    /// </summary>
    public class DoughnutOptions : BaseChartConfigOptions
    {
        /// <summary>
        /// Gets or sets the percentage of the chart that is cut out of the middle.
        /// </summary>
        public int CutoutPercentage { get; set; } = 50;

        /// <summary>
        /// Gets or sets the animation the chart uses.
        /// </summary>
        public DoughnutAnimation Animation { get; set; }

        /// <summary>
        /// Gets or sets the starting angle to draw arcs from.
        /// </summary>
        public double Rotation { get; set; } = -0.5 * Math.PI;

        /// <summary>
        /// Gets or sets the sweep to allow arcs to cover
        /// </summary>
        public double Circumferences { get; set; } = 2 * Math.PI;
    }
}
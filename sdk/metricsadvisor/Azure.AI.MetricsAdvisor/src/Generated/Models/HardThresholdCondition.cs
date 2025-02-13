// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The HardThresholdCondition. </summary>
    public partial class HardThresholdCondition
    {
        /// <summary> Initializes a new instance of HardThresholdCondition. </summary>
        /// <param name="lowerBound">
        /// lower bound
        ///
        /// should be specified when anomalyDetectorDirection is Both or Down
        /// </param>
        /// <param name="upperBound">
        /// upper bound
        ///
        /// should be specified when anomalyDetectorDirection is Both or Up
        /// </param>
        /// <param name="anomalyDetectorDirection"> detection direction. </param>
        /// <param name="suppressCondition"></param>
        internal HardThresholdCondition(double? lowerBound, double? upperBound, AnomalyDetectorDirection anomalyDetectorDirection, SuppressCondition suppressCondition)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
            AnomalyDetectorDirection = anomalyDetectorDirection;
            SuppressCondition = suppressCondition;
        }
    }
}

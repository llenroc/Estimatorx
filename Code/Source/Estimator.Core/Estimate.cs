﻿using System;

namespace Estimator.Core
{
    /// <summary>
    /// An estimate based on number of tasks for a project <see cref="Factor"/>.
    /// </summary>
    public class Estimate : ModelBase
    {
        /// <summary>
        /// Gets or sets the name of the estimate .
        /// </summary>
        /// <value>
        /// The name of the estimate.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description for the estimate.
        /// </summary>
        /// <value>
        /// The description for the estimate.
        /// </value>
        public string Description { get; set; }

        
        /// <summary>
        /// Gets or sets the number of very simple tasks.
        /// </summary>
        /// <value>
        /// The number of very simple tasks.
        /// </value>
        public byte? VerySimple { get; set; }
        
        /// <summary>
        /// Gets or sets the number of simple tasks.
        /// </summary>
        /// <value>
        /// The number of simple tasks.
        /// </value>
        public byte? Simple { get; set; }
        
        /// <summary>
        /// Gets or sets the number of medium tasks.
        /// </summary>
        /// <value>
        /// The number of medium tasks.
        /// </value>
        public byte? Medium { get; set; }
        
        /// <summary>
        /// Gets or sets the number of complex tasks.
        /// </summary>
        /// <value>
        /// The number of complex tasks.
        /// </value>
        public byte? Complex { get; set; }
        
        /// <summary>
        /// Gets or sets the number of very complex tasks.
        /// </summary>
        /// <value>
        /// The number of very complex tasks.
        /// </value>
        public byte? VeryComplex { get; set; }


        /// <summary>
        /// Gets or sets the total number of tasks for this estimate.
        /// </summary>
        /// <value>
        /// The total number of tasks for this estimate.
        /// </value>
        public int TotalTasks { get; set; }

        /// <summary>
        /// Gets or sets the total number hours for this estimate based on the <see cref="Factor"/>.
        /// </summary>
        /// <value>
        /// The total number hours for this estimate based on the <see cref="Factor"/>.
        /// </value>
        public int TotalHours { get; set; }


        /// <summary>
        /// Gets or sets the factor identifier for this estimate.
        /// </summary>
        /// <value>
        /// The factor identifier for this estimate.
        /// </value>
        public Guid FactorId { get; set; }
    }
}
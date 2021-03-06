﻿using System;

namespace Estimatorx.Core
{
    public class TemplateSummary
    {
        /// <summary>
        /// Gets or sets the identifier for the model.
        /// </summary>
        /// <value>
        /// The identifier for the model.
        /// </value>
        public string Id { get; set; }


        /// <summary>
        /// Gets or sets the name of the template.
        /// </summary>
        /// <value>
        /// The name of the template.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description for the template.
        /// </summary>
        /// <value>
        /// The description for the template.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or set the organization this project belongs to.
        /// </summary>
        public string OrganizationId { get; set; }


        /// <summary>
        /// Gets or sets the system create date.
        /// </summary>
        /// <value>
        /// The system create date.
        /// </value>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the system create user.
        /// </summary>
        /// <value>
        /// The system create user.
        /// </value>
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets the system update date.
        /// </summary>
        /// <value>
        /// The system update date.
        /// </value>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the system update user.
        /// </summary>
        /// <value>
        /// The system update user.
        /// </value>
        public string Updater { get; set; }

    }
}
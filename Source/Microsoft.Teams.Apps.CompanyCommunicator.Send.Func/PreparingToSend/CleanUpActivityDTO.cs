﻿// <copyright file="CleanUpActivityDTO.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Send.Func.PreparingToSend
{
    using System;
    using Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories.NotificationData;

    /// <summary>
    /// DTO class used by the Activity7CleanUp as parameter type.
    /// </summary>
    public class CleanUpActivityDTO
    {
        /// <summary>
        /// Gets or sets new sent notification data entity.
        /// </summary>
        public NotificationDataEntity NotificationDataEntity { get; set; }

        /// <summary>
        /// Gets or sets Exception.
        /// </summary>
        public Exception Exception { get; set; }
    }
}
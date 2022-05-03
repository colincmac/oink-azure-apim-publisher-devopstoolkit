﻿// --------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License.
// --------------------------------------------------------------------------

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions
{
    public class APITemplateOAuth2
    {
        public string AuthorizationServerId { get; set; }

        public string Scope { get; set; }
    }
}

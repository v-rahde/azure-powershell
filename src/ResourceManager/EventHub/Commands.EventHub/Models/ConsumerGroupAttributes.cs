﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.EventHub.Models;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.EventHub.Models
{

    public class ConsumerGroupAttributes
    {
        public ConsumerGroupAttributes()
        { }

        public ConsumerGroupAttributes(ConsumerGroupResource consumerGroupResourceResource)
        {
            if (consumerGroupResourceResource != null)
            {
                Name = consumerGroupResourceResource.Name;
                Location = consumerGroupResourceResource.Location;
                CreatedAt = consumerGroupResourceResource.CreatedAt;
                EventHubPath = consumerGroupResourceResource.EventHubPath;
                UpdatedAt = consumerGroupResourceResource.UpdatedAt;
                UserMetadata = consumerGroupResourceResource.UserMetadata;
            }
        }

        /// <summary>
        /// The path of the event hub.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The path of the event hub.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Exact time the Event was created.
        /// </summary>
        public DateTime? CreatedAt { get;}
        
        /// <summary>
        /// The exact time the message has been updated.
        /// </summary>
        public DateTime? UpdatedAt { get; }

        /// <summary>
        /// The path of the event hub.
        /// </summary>
        public string EventHubPath { get; set; }

        /// <summary>
        /// The user metadata.
        /// </summary>
        public string UserMetadata { get; set; }

    }
}

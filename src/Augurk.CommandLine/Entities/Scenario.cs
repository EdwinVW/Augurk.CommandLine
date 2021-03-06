﻿/*
 Copyright 2017, Augurk
 
 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at
 
 http://www.apache.org/licenses/LICENSE-2.0
 
 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
*/

using System.Collections.Generic;

namespace Augurk.CommandLine.Entities
{
    /// <summary>
    /// Represents a feature scenario
    /// </summary>
    public class Scenario
    {
        /// <summary>
        /// Gets or sets the title of this scenario.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of this scenario.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the tags of this scenario.
        /// </summary>
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the steps of this scenario.
        /// </summary>
        public IEnumerable<Step> Steps { get; set; }

        /// <summary>
        /// Gets or sets the example sets for this scenario.
        /// </summary>
        public IEnumerable<ExampleSet> ExampleSets { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="SourceLocation"/> for this scenario.
        /// </summary>
        public SourceLocation Location { get; set; }
    }
}
